// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Card.Identification
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer.Card
{
  public struct Identification
  {
    private int? _number;
    private string _subtype;
    private string _type;

    public int? Number
    {
      get
      {
        return this._number;
      }
      set
      {
        this._number = value;
      }
    }

    public string Subtype
    {
      get
      {
        return this._subtype;
      }
      set
      {
        this._subtype = value;
      }
    }

    public string Type
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }
  }
}
