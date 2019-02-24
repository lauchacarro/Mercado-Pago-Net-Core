// Decompiled with JetBrains decompiler
// Type: MercadoPago.CustomDeserializationContractResolver
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace MercadoPago
{
  public class CustomDeserializationContractResolver : DefaultContractResolver
  {
    protected override JsonProperty CreateProperty(
      MemberInfo member,
      MemberSerialization memberSerialization)
    {
      try
      {
        JsonProperty property = base.CreateProperty(member, memberSerialization);
        if (!property.Writable)
        {
          PropertyInfo propertyInfo = member as PropertyInfo;
          if (property != null)
          {
            bool flag = propertyInfo.GetSetMethod(true) != null;
            property.Writable = flag;
          }
        }
        return property;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
