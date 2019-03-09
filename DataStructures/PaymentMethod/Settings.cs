// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.PaymentMethod.Settings
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.PaymentMethod
{
  public struct Settings
  {
    private Bin _bin;
    private CardNumber _card_number;
    private SecurityCode _security_code;

    public Bin Bin
    {
      get
      {
        return this._bin;
      }
      set
      {
        this._bin = value;
      }
    }

    public CardNumber CardNumber
    {
      get
      {
        return this._card_number;
      }
      set
      {
        this._card_number = value;
      }
    }

    public SecurityCode SecurityCode
    {
      get
      {
        return this._security_code;
      }
      set
      {
        this._security_code = value;
      }
    }
  }
}
