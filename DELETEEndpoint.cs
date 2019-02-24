// Decompiled with JetBrains decompiler
// Type: MercadoPago.DELETEEndpoint
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago
{
  public class DELETEEndpoint : BaseEndpoint
  {
    public DELETEEndpoint(string path)
      : base(path, HttpMethod.DELETE, 0, 0)
    {
    }

    public DELETEEndpoint(string path, int requestTimeout)
      : base(path, HttpMethod.DELETE, requestTimeout, 0)
    {
    }

    public DELETEEndpoint(string path, int requestTimeout, int retries)
      : base(path, HttpMethod.DELETE, requestTimeout, retries)
    {
    }
  }
}
