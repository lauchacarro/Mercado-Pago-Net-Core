// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Error
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer
{
  public struct Error
  {
    private string code;
    private string description;
    private string field;

    public string Code
    {
      get
      {
        return this.code;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
    }

    public string Field
    {
      get
      {
        return this.field;
      }
    }
  }
}
