// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.PaymentMethod.Bin
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.PaymentMethod
{
  public struct Bin
  {
    private string _pattern;
    private string _exclusion_pattern;
    private string _installments_pattern;

    public string Pattern
    {
      get
      {
        return this._pattern;
      }
      set
      {
        this._pattern = value;
      }
    }

    public string ExclusionPattern
    {
      get
      {
        return this._exclusion_pattern;
      }
      set
      {
        this._exclusion_pattern = value;
      }
    }

    public string InstallmentsPattern
    {
      get
      {
        return this._installments_pattern;
      }
      set
      {
        this._installments_pattern = value;
      }
    }
  }
}
