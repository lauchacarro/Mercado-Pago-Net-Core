// Decompiled with JetBrains decompiler
// Type: MercadoPago.Core.MPIPN
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;
using System.Reflection;

namespace MercadoPago.Core
{
  public class MPIPN
  {
    public static Type GetType(string resourceClassName)
    {
      Type type1 = Type.GetType(resourceClassName);
      if (type1 != null)
        return type1;
      foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        Type type2 = assembly.GetType(resourceClassName);
        if (type2 != null)
          return type2;
      }
      return (Type) null;
    }

    public static MPBase Manage<T>(string topic, string id) where T : MPBase
    {
      if (string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(id))
        throw new MPException("Topic and Id can not be null in the IPN request.");
      try
      {
        Type type = MPIPN.GetType(topic);
        if (!type.IsSubclassOf(typeof (MPBase)))
          throw new MPException(type.Name + " does not extend from MPBase");
        return (MPBase) type.GetMethod("Load", new Type[1]
        {
          typeof (string)
        }).Invoke(Activator.CreateInstance(type, (object[]) null), new object[1]
        {
          (object) id
        });
      }
      catch (Exception ex)
      {
        throw new MPException(ex.Message);
      }
    }

    public class Topic
    {
      public static string merchantOrder
      {
        get
        {
          return "MercadoPago.Resources.MerchantOrder";
        }
      }

      public static string payment
      {
        get
        {
          return "MercadoPago.Resources.Payment";
        }
      }
    }
  }
}
