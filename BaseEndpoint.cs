// Decompiled with JetBrains decompiler
// Type: MercadoPago.BaseEndpoint
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago
{
  public class BaseEndpoint : Attribute
  {
    public string Path { get; protected set; }

    public HttpMethod HttpMethod { get; set; }

    public PayloadType PayloadType { get; set; }

    public int Retries { get; protected set; }

    public int RequestTimeout { get; protected set; }

    public BaseEndpoint(string path, HttpMethod methodType, int requestTimeout, int retries)
    {
      this.Path = path;
      this.HttpMethod = methodType;
      this.RequestTimeout = requestTimeout;
      this.Retries = retries == 0 ? 1 : retries;
      this.PayloadType = PayloadType.JSON;
    }
  }
}
