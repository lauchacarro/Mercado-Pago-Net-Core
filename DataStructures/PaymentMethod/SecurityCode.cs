// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.PaymentMethod.SecurityCode
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.PaymentMethod
{
  public struct SecurityCode
  {
    private SecurityCodeMode _mode;
    private int _length;
    private SecurityCodeCardLocation _card_location;

    public SecurityCodeMode Mode
    {
      get
      {
        return this._mode;
      }
      set
      {
        this._mode = value;
      }
    }

    public int Length
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

    public SecurityCodeCardLocation CardLocation
    {
      get
      {
        return this._card_location;
      }
      set
      {
        this._card_location = value;
      }
    }
  }
}
