// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Card.SecurityCode
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer.Card
{
  public struct SecurityCode
  {
    private int? _length;
    private string _card_location;

    public int? Length
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

    public string CardLocation
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
