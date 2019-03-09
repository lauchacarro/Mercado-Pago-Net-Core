// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.CardHolder
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Payment
{
  public struct CardHolder
  {
    private string _name;
    private MercadoPago.DataStructures.Payment.Identification? _identification;

    public string Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    public MercadoPago.DataStructures.Payment.Identification? Identification
    {
      get
      {
        return this._identification;
      }
      set
      {
        this._identification = value;
      }
    }
  }
}
