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
    private static string UserToken = (string) null;
    public static string RefreshToken = (string) null;
    private static string _clientSecret = (string) null;
    private static string _clientId = (string) null;
    private static string _accessToken = (string) null;
    private static string _appId = (string) null;
    private static string _baseUrl = "https://api.mercadopago.com";
    private const string DEFAULT_BASE_URL = "https://api.mercadopago.com";

    public static string ClientSecret
    {
      get
      {
        return SDK._clientSecret;
      }
      set
      {
        if (!string.IsNullOrEmpty(SDK._clientSecret))
          throw new MPConfException("clientSecret setting can not be changed");
        SDK._clientSecret = value;
      }
    }

    public static string ClientId
    {
      get
      {
        return SDK._clientId;
      }
      set
      {
        if (!string.IsNullOrEmpty(SDK._clientId))
          throw new MPConfException("clientId setting can not be changed");
        SDK._clientId = value;
      }
    }

    public static string AccessToken
    {
      get
      {
        return SDK._accessToken;
      }
      set
      {
        if (!string.IsNullOrEmpty(SDK._accessToken))
          throw new MPConfException("accessToken setting can not be changed");
        SDK._accessToken = value;
      }
    }

    public static string AppId
    {
      get
      {
        return SDK._appId;
      }
      set
      {
        if (!string.IsNullOrEmpty(SDK._appId))
          throw new MPConfException("appId setting can not be changed");
        SDK._appId = value;
      }
    }

    public static string BaseUrl
    {
      get
      {
        return SDK._baseUrl;
      }
    }

    public static void SetConfiguration(IDictionary<string, string> configurationParams)
    {
      if (configurationParams == null)
        throw new ArgumentException("Invalid configurationParams parameter");
      configurationParams.TryGetValue("clientSecret", out SDK._clientSecret);
      configurationParams.TryGetValue("clientId", out SDK._clientId);
      configurationParams.TryGetValue("accessToken", out SDK._accessToken);
      configurationParams.TryGetValue("appId", out SDK._appId);
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

    public static void CleanConfiguration()
    {
      SDK._clientSecret = (string) null;
      SDK._clientId = (string) null;
      SDK._accessToken = (string) null;
      SDK._appId = (string) null;
      SDK._baseUrl = "https://api.mercadopago.com";
    }

    public static void SetBaseUrl(string baseUrl)
    {
      SDK._baseUrl = baseUrl;
    }

    //private static string GetConfigValue(System.Configuration.Configuration config, string key)
    //{
    //  string str = (string) null;
    //  KeyValueConfigurationElement setting = config.AppSettings.Settings[key];
    //  if (setting != null)
    //    str = setting.Value;
    //  return str;
    //}

    public static string GetAccessToken()
    {
      if (string.IsNullOrEmpty(SDK.AccessToken))
        SDK.AccessToken = MPCredentials.GetAccessToken();
      return SDK.AccessToken;
    }

    public static void SetAccessToken(string accessToken)
    {
      if (!string.IsNullOrEmpty(SDK.AccessToken))
        throw new MPException("Access_Token setting cannot be changed.");
      SDK.AccessToken = accessToken;
    }

    public static string GetUserToken()
    {
      return SDK.UserToken;
    }

    public static JToken Get(string uri)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.GET, uri, PayloadType.JSON, (JObject) null);
    }

    public static JToken Post(string uri, JObject payload)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.POST, uri, PayloadType.JSON, payload);
    }

    public static JToken Put(string uri, JObject payload)
    {
      return new MPRESTClient().ExecuteGenericRequest(HttpMethod.PUT, uri, PayloadType.JSON, payload);
    }
  }
}
