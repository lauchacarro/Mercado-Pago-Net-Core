// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPCredentials
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace MercadoPago
{
  public class MPCredentials
  {
    public static string GetAccessToken()
    {
      if (string.IsNullOrEmpty(SDK.ClientId) || string.IsNullOrEmpty(SDK.ClientSecret))
        throw new MPException("\"client_id\" and \"client_secret\" can not be \"null\" when getting the \"access_token\"");
      MPAPIResponse mpapiResponse = new MPRESTClient().ExecuteRequest(HttpMethod.POST, SDK.BaseUrl + "/oauth/token", PayloadType.X_WWW_FORM_URLENCODED, new JObject()
      {
        {
          "grant_type",
          (JToken) "client_credentials"
        },
        {
          "client_id",
          (JToken) SDK.ClientId
        },
        {
          "client_secret",
          (JToken) SDK.ClientSecret
        }
      }, (WebHeaderCollection) null, 0, 0);
      JObject containerToken = JObject.Parse(mpapiResponse.StringResponse.ToString());
      if (mpapiResponse.StatusCode != 200)
        throw new MPException("Can not retrieve the \"access_token\"");
      List<JToken> tokens1 = containerToken.FindTokens("access_token");
      List<JToken> tokens2 = containerToken.FindTokens("refresh_token");
      if (tokens1 == null || tokens1.Count != 1)
        throw new MPException("Can not retrieve the \"access_token\"");
      string str = tokens1.First<JToken>().ToString();
      if (tokens2 != null && tokens2.Count == 1)
        SDK.RefreshToken = tokens2.First<JToken>().ToString();
      return str;
    }

    public static string RefreshAccessToken()
    {
      if (string.IsNullOrEmpty(SDK.RefreshToken))
        throw new MPException("\"RefreshToken\" can not be \"null\". Refresh access token could not be completed.");
      MPAPIResponse mpapiResponse = new MPRESTClient().ExecuteRequest(HttpMethod.POST, SDK.BaseUrl + "/oauth/token", PayloadType.X_WWW_FORM_URLENCODED, new JObject()
      {
        {
          "client_secret",
          (JToken) SDK.ClientSecret
        },
        {
          "grant_type",
          (JToken) "refresh_token"
        },
        {
          "refresh_token",
          (JToken) SDK.RefreshToken
        }
      }, (WebHeaderCollection) null, 0, 0);
      JObject containerToken = JObject.Parse(mpapiResponse.StringResponse.ToString());
      if (mpapiResponse.StatusCode != 200)
        throw new MPException("Can not retrieve the new \"access_token\"");
      List<JToken> tokens = containerToken.FindTokens("access_token");
      if (tokens != null && tokens.Count == 1)
        return tokens.First<JToken>().ToString();
      throw new MPException("Can not retrieve the new \"access_token\"");
    }
  }
}
