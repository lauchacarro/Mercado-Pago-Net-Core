// Decompiled with JetBrains decompiler
// Type: MercadoPago.CustomSerializationContractResolver
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace MercadoPago
{
  public class CustomSerializationContractResolver : DefaultContractResolver
  {
    protected override JsonProperty CreateProperty(
      MemberInfo member,
      MemberSerialization memberSerialization)
    {
      JsonProperty property = base.CreateProperty(member, memberSerialization);
      property.ShouldSerialize = (Predicate<object>) (propInstance => property.Writable);
      if (!property.Readable)
      {
        PropertyInfo propertyInfo = member as PropertyInfo;
        if (property != null)
        {
          bool flag = propertyInfo.GetGetMethod(true) != null;
          property.Readable = flag;
        }
      }
      return property;
    }
  }
}
