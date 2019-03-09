// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Order
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
  public struct Order
  {
    private OrderType? _type;
    private long? _id;

    public OrderType? Type
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

    public long? Id1
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
  }
}
