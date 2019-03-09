// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Item
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.DataStructures.Payment
{
  public struct Item
  {
    private string _id;
    private string _title;
    private string _description;
    private string _picture_url;
    private string _category_id;
    private int? _quantity;
    private Decimal? _unit_price;

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

    public string Title
    {
      get
      {
        return this._title;
      }
      set
      {
        this._title = value;
      }
    }

    public string Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }

    public string PictureUrl
    {
      get
      {
        return this._picture_url;
      }
      set
      {
        this._picture_url = value;
      }
    }

    public string CategoryId
    {
      get
      {
        return this._category_id;
      }
      set
      {
        this._category_id = value;
      }
    }

    public int? Quantity
    {
      get
      {
        return this._quantity;
      }
      set
      {
        this._quantity = value;
      }
    }

    public Decimal? UnitPrice
    {
      get
      {
        return this._unit_price;
      }
      set
      {
        this._unit_price = value;
      }
    }
  }
}
