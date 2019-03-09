// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPRESTClient
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MercadoPago
{
  public class MPRESTClient
  {
    public int ProxyPort = -1;
    public string ProxyHostName;

    public MPRESTClient()
    {
      MPRESTClient mprestClient = new MPRESTClient((string) null, -1);
    }

    public MPRESTClient(string proxyHostName, int proxyPort)
    {
      this.ProxyHostName = proxyHostName;
      this.ProxyPort = proxyPort;
    }

    public JToken ExecuteGenericRequest(
      HttpMethod httpMethod,
      string path,
      PayloadType payloadType,
      JObject payload, SDK sdk)
    {
      if (sdk.GetAccessToken() != null)
        path = sdk.BaseUrl + path + "?access_token=" + sdk.GetAccessToken();
      MPRequest request = this.CreateRequest(httpMethod, path, payloadType, payload, (WebHeaderCollection) null, 0, 0);
      if (((IEnumerable<HttpMethod>) new HttpMethod[2]
      {
        HttpMethod.POST,
        HttpMethod.PUT
      }).Contains<HttpMethod>(httpMethod))
      {
        Stream requestStream = request.Request.GetRequestStream();
        requestStream.Write(request.RequestPayload, 0, request.RequestPayload.Length);
        requestStream.Close();
      }
      try
      {
        using (HttpWebResponse response = (HttpWebResponse) request.Request.GetResponse())
          return JToken.Parse(new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd());
      }
      catch (WebException ex)
      {
        return JToken.Parse(new StreamReader((ex.Response as HttpWebResponse).GetResponseStream(), Encoding.UTF8).ReadToEnd());
      }
    }

    public MPAPIResponse ExecuteRequest(
      HttpMethod httpMethod,
      string path,
      PayloadType payloadType,
      JObject payload,
      WebHeaderCollection colHeaders,
      int requestTimeout,
      int retries)
    {
      Trace.WriteLine("Payload " + (object) httpMethod + " request to " + path + " : " + (object) payload);
      try
      {
        return this.ExecuteRequestCore(httpMethod, path, payloadType, payload, colHeaders, requestTimeout, retries);
      }
      catch (Exception ex)
      {
        throw new MPRESTException(ex.Message);
      }
    }

    public MPAPIResponse ExecuteRequestCore(
      HttpMethod httpMethod,
      string path,
      PayloadType payloadType,
      JObject payload,
      WebHeaderCollection colHeaders,
      int connectionTimeout,
      int retries)
    {
      MPRequest request = this.CreateRequest(httpMethod, path, payloadType, payload, colHeaders, connectionTimeout, retries);
      string empty = string.Empty;
      if (((IEnumerable<HttpMethod>) new HttpMethod[2]
      {
        HttpMethod.POST,
        HttpMethod.PUT
      }).Contains<HttpMethod>(httpMethod))
      {
        Stream requestStream = request.Request.GetRequestStream();
        requestStream.Write(request.RequestPayload, 0, request.RequestPayload.Length);
        requestStream.Close();
      }
      try
      {
        using (HttpWebResponse response = (HttpWebResponse) request.Request.GetResponse())
          return new MPAPIResponse(httpMethod, request.Request, payload, response);
      }
      catch (WebException ex)
      {
        if (ex.Status == WebExceptionStatus.ProtocolError)
        {
          HttpWebResponse response = ex.Response as HttpWebResponse;
          return new MPAPIResponse(httpMethod, request.Request, payload, response);
        }
        if (--retries != 0)
          return this.ExecuteRequestCore(httpMethod, path, payloadType, payload, colHeaders, connectionTimeout, retries);
        throw;
      }
    }

    public MPRequest CreateRequest(
      HttpMethod httpMethod,
      string path,
      PayloadType payloadType,
      JObject payload,
      WebHeaderCollection colHeaders,
      int connectionTimeout,
      int retries)
    {
      if (string.IsNullOrEmpty(path))
        throw new MPRESTException("Uri can not be an empty string.");
      if (httpMethod.Equals((object) HttpMethod.GET))
      {
        if (payload != null)
          throw new MPRESTException("Payload not supported for this method.");
      }
      else if (!httpMethod.Equals((object) HttpMethod.POST))
      {
        if (httpMethod.Equals((object) HttpMethod.PUT))
        {
          if (payload == null)
            throw new MPRESTException("Must include payload for this method.");
        }
        else if (httpMethod.Equals((object) HttpMethod.DELETE) && payload != null)
          throw new MPRESTException("Payload not supported for this method.");
      }
      MPRequest mpRequest = new MPRequest();
      mpRequest.Request = (HttpWebRequest) WebRequest.Create(path);
      mpRequest.Request.Method = httpMethod.ToString();
      if (connectionTimeout > 0)
        mpRequest.Request.Timeout = connectionTimeout;
      if (colHeaders != null)
      {
        foreach (object colHeader in (NameObjectCollectionBase) colHeaders)
          mpRequest.Request.Headers.Add(colHeader.ToString(), colHeaders[colHeader.ToString()]);
      }
      mpRequest.Request.ContentType = "application/json";
      mpRequest.Request.UserAgent = "MercadoPago DotNet SDK/1.0.30";
      mpRequest.Request.Headers.Add("x-product-id", "BC32BHVTRPP001U8NHL0");
      if (payload != null)
      {
        byte[] bytes;
        if (payloadType != PayloadType.JSON)
        {
          Dictionary<string, string> source = payload.ToObject<Dictionary<string, string>>();
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.Append(string.Format("{0}={1}", (object) source.First<KeyValuePair<string, string>>().Key, (object) source.First<KeyValuePair<string, string>>().Value));
          source.Remove(source.First<KeyValuePair<string, string>>().Key);
          foreach (KeyValuePair<string, string> keyValuePair in source)
            stringBuilder.Append(string.Format("&{0}={1}", (object) keyValuePair.Key, (object) keyValuePair.Value.ToString()));
          bytes = Encoding.ASCII.GetBytes(stringBuilder.ToString());
        }
        else
          bytes = Encoding.ASCII.GetBytes(payload.ToString());
        mpRequest.Request.ContentLength = (long) bytes.Length;
        mpRequest.Request.ContentType = payloadType == PayloadType.JSON ? "application/json" : "application/x-www-form-urlencoded";
        mpRequest.RequestPayload = bytes;
      }
      return mpRequest;
    }
  }
}
