// Decompiled with JetBrains decompiler
// Type: MercadoPago.SDK
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace MercadoPago
{
  public class SDK
  {
    private  string UserToken = (string) null;
    public  string RefreshToken = (string) null;
    private  string _clientSecret = (string) null;
    private  string _clientId = (string) null;
    private  string _accessToken = (string) null;
    private  string _appId = (string) null;
    private  string _baseUrl = "https://api.mercadopago.com";
    private const string DEFAULT_BASE_URL = "https://api.mercadopago.com";

    public  string ClientSecret
    {
      get
      {
        return this._clientSecret;
      }
      set
      {

                this._clientSecret = value;
      }
    }

    public  string ClientId
    {
      get
      {
        return this._clientId;
      }
      set
      {

                this._clientId = value;
      }
    }

    public  string AccessToken
    {
      get
      {
        return this._accessToken;
      }
      set
      {

                this._accessToken = value;
      }
    }

    public  string AppId
    {
      get
      {
        return this._appId;
      }
      set
      {

                this._appId = value;
      }
    }

    public  string BaseUrl
    {
      get
      {
        return this._baseUrl;
      }
    }

    public  void SetConfiguration(IDictionary<string, string> configurationParams)
    {
      if (configurationParams == null)
        throw new ArgumentException("Invalid configurationParams parameter");
      configurationParams.TryGetValue("clientSecret", out this._clientSecret);
      configurationParams.TryGetValue("clientId", out this._clientId);
      configurationParams.TryGetValue("accessToken", out this._accessToken);
      configurationParams.TryGetValue("appId", out this._appId);
    }

    //public static void SetConfiguration(System.Configuration.Configuration config)
    //{
    //  if (config == null)
    //    throw new ArgumentException("config parameter cannot be null");
    //  SDK._clientSecret = SDK.GetConfigValue(config, "ClientSecret");
    //  SDK._clientId = SDK.GetConfigValue(config, "ClientId");
    //  SDK._accessToken = SDK.GetConfigValue(config, "AccessToken");
    //  SDK._appId = SDK.GetConfigValue(config, "AppId");
    //}

    public  void CleanConfiguration()
    {
            this._clientSecret = (string) null;
            this._clientId = (string) null;
            this._accessToken = (string) null;
            this._appId = (string) null;
            this._baseUrl = "https://api.mercadopago.com";
    }

    public  void SetBaseUrl(string baseUrl)
    {
            this._baseUrl = baseUrl;
    }

    //private static string GetConfigValue(System.Configuration.Configuration config, string key)
    //{
    //  string str = (string) null;
    //  KeyValueConfigurationElement setting = config.AppSettings.Settings[key];
    //  if (setting != null)
    //    str = setting.Value;
    //  return str;
    //}

    public  string GetAccessToken()
    {
      if (string.IsNullOrEmpty(this.AccessToken))
                this.AccessToken = MPCredentials.GetAccessToken(this);
      return this.AccessToken;
    }

    public  void SetAccessToken(string accessToken)
    {
      if (!string.IsNullOrEmpty(this.AccessToken))
        throw new MPException("Access_Token setting cannot be changed.");
            this.AccessToken = accessToken;
    }

    public  string GetUserToken()
    {
      return this.UserToken;
    }

    public  JToken Get(string uri)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.GET, uri, PayloadType.JSON, (JObject) null, this);
    }

    public  JToken Post(string uri, JObject payload)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.POST, uri, PayloadType.JSON, payload, this);
    }

    public  JToken Put(string uri, JObject payload)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.PUT, uri, PayloadType.JSON, payload, this);
    }
  }
}
