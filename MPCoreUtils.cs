// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPCoreUtils
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace MercadoPago
{
  public static class MPCoreUtils
  {
    public static List<JToken> FindTokens(this JToken containerToken, string name)
    {
      List<JToken> matches = new List<JToken>();
      MPCoreUtils.FindTokens(containerToken, name, matches);
      return matches;
    }

    private static void FindTokens(JToken containerToken, string name, List<JToken> matches)
    {
      if (containerToken.Type == JTokenType.Object)
      {
        foreach (JProperty child in containerToken.Children<JProperty>())
        {
          if (child.Name == name)
            matches.Add(child.Value);
          MPCoreUtils.FindTokens(child.Value, name, matches);
        }
      }
      else
      {
        if (containerToken.Type != JTokenType.Array)
          return;
        foreach (JToken child in containerToken.Children())
          MPCoreUtils.FindTokens(child, name, matches);
      }
    }

    public static JObject GetJsonFromResource<T>(T resource) where T : MPBase
    {
      JsonSerializer jsonSerializer1 = new JsonSerializer();
      jsonSerializer1.NullValueHandling = NullValueHandling.Ignore;
      CustomSerializationContractResolver contractResolver = new CustomSerializationContractResolver();
      contractResolver.NamingStrategy = (NamingStrategy) new SnakeCaseNamingStrategy();
      jsonSerializer1.ContractResolver = (IContractResolver) contractResolver;
      JsonSerializer jsonSerializer2 = jsonSerializer1;
      jsonSerializer2.Converters.Add((JsonConverter) new IsoDateTimeConverter()
      {
        DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffK"
      });
      return JObject.FromObject((object) resource, jsonSerializer2);
    }

    public static MPBase GetResourceFromJson<T>(Type type, JObject jObj) where T : MPBase
    {
      JsonSerializer jsonSerializer1 = new JsonSerializer();
      jsonSerializer1.NullValueHandling = NullValueHandling.Ignore;
      CustomDeserializationContractResolver contractResolver = new CustomDeserializationContractResolver();
      contractResolver.NamingStrategy = (NamingStrategy) new SnakeCaseNamingStrategy();
      jsonSerializer1.ContractResolver = (IContractResolver) contractResolver;
      JsonSerializer jsonSerializer2 = jsonSerializer1;
      jsonSerializer2.Converters.Add((JsonConverter) new IsoDateTimeConverter()
      {
        DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffK"
      });
      T obj = jObj.ToObject<T>(jsonSerializer2);
      //obj.DumpLog();
      return (MPBase) obj;
    }

    public static MPBase GetResourceFromJson<T>(string json) where T : MPBase
    {
      JsonSerializer jsonSerializer = new JsonSerializer();
      T obj = JsonConvert.DeserializeObject<T>(json);
      //obj.DumpLog();
      return (MPBase) obj;
    }

    public static BadParamsError GetBadParamsError(string raw)
    {
      return JObject.Parse(raw).ToObject<BadParamsError>(new JsonSerializer()
      {
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = (IContractResolver) new CustomDeserializationContractResolver()
      });
    }

    public static JArray GetArrayFromJsonElement<T>(JObject jsonElement) where T : MPBase
    {
      JArray jarray = (JArray) null;
      if (jsonElement != null)
        jarray = JArray.Parse(jsonElement["results"].ToString());
      return jarray;
    }

    public static JArray GetJArrayFromStringResponse<T>(string stringResponse) where T : MPBase
    {
      return JArray.Parse(stringResponse);
    }
  }
}
