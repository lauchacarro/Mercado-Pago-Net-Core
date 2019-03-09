// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Source
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
  public struct Source
  {
    private string _id;
    private string _name;
    private RefundUserType _type;

    public string Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

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

    public RefundUserType Type
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
