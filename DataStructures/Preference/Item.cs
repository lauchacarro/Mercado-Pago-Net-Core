// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.Item
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct Item
  {
    [StringLength(256)]
    private string _id;
    [StringLength(256)]
    private string _title;
    [StringLength(256)]
    private string _description;
    [StringLength(600)]
    private string _pictureU_url;
    [StringLength(256)]
    private int? _category_id;
    private int? _quantity;
    [StringLength(3)]
    private CurrencyId _currency_id;
    [RegularExpression("^\\d+\\.\\d{0,2}$")]
    [Range(0.0, 1E+16)]
    private Decimal unit_price;

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
        return this._pictureU_url;
      }
      set
      {
        this._pictureU_url = value;
      }
    }

    public int? CategoryId
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

    public CurrencyId CurrencyId
    {
      get
      {
        return this._currency_id;
      }
      set
      {
        this._currency_id = value;
      }
    }

    public Decimal UnitPrice
    {
      get
      {
        return this.unit_price;
      }
      set
      {
        this.unit_price = value;
      }
    }
  }
}
