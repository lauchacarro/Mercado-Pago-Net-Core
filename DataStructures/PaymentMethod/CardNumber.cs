// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.PaymentMethod.CardNumber
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.PaymentMethod
{
  public struct CardNumber
  {
    private string _length;
    private string _validation;

    public string Length
    {
      get
      {
        return this._length;
      }
      set
      {
        this._length = value;
      }
    }

    public string Validation
    {
      get
      {
        return this._validation;
      }
      set
      {
        this._validation = value;
      }
    }
  }
}
