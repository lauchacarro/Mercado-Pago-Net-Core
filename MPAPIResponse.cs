// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPAPIResponse
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace MercadoPago
{
  public class MPAPIResponse
  {
    public bool IsFromCache;

    public string HttpMethod { get; protected set; }

    public string Url { get; protected set; }

    public HttpWebRequest Request { get; protected set; }

    public string Payload { get; protected set; }

    public HttpWebResponse Response { get; protected set; }

    public int StatusCode { get; protected set; }

    public string StatusDescription { get; protected set; }

    public string StringResponse { get; protected set; }

    public JObject JsonObjectResponse { get; protected set; }

    public MPAPIResponse(
      MercadoPago.HttpMethod httpMethod,
      HttpWebRequest request,
      JObject payload,
      HttpWebResponse response)
    {
      this.Request = request;
      this.Response = response;
      this.ParseRequest(httpMethod, request, payload);
      this.ParseResponse(response);
      Trace.WriteLine("Server response: " + this.StringResponse);
    }

    private void ParseRequest(MercadoPago.HttpMethod httpMethod, HttpWebRequest request, JObject payload)
    {
      this.HttpMethod = httpMethod.ToString();
      this.Url = request.RequestUri.ToString();
      if (payload == null)
        return;
      this.Payload = payload.ToString();
    }

    private void ParseResponse(HttpWebResponse response)
    {
      this.StatusCode = (int) response.StatusCode;
      this.StatusDescription = response.StatusDescription;
      if (response.GetResponseStream() == null)
        return;
      try
      {
        Stream responseStream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
        this.StringResponse = streamReader.ReadToEnd();
        streamReader.Close();
        responseStream.Close();
      }
      catch (Exception ex)
      {
        throw new MPException(ex.Message);
      }
      try
      {
        this.JsonObjectResponse = JObject.Parse(this.StringResponse);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error parsing jsonObect");
      }
    }
  }
}
