// Decompiled with JetBrains decompiler
// Type: MercadoPago.GETEndpoint
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago
{
  public class GETEndpoint : BaseEndpoint
  {
    public GETEndpoint(string path)
      : base(path, HttpMethod.GET, 0, 0)
    {
    }

    public GETEndpoint(string path, int requestTimeout)
      : base(path, HttpMethod.GET, requestTimeout, 0)
    {
    }

    public GETEndpoint(string path, int requestTimeout, int retries)
      : base(path, HttpMethod.GET, requestTimeout, retries)
    {
    }
  }
}
