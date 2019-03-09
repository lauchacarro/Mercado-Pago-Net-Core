// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.MerchantOrder.Item
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.MerchantOrder
{
  public struct Item
  {
    private string id;
    private string categoryId;
    [RegularExpression("^.{3,3}$")]
    private string currencyId;
    private string description;
    private string pictureUrl;
    private int quantity;
    private float unitPrice;
    private string title;

    public string ID
    {
      get
      {
        return this.id;
      }
      set
      {
        this.id = value;
      }
    }

    public string CategoryId
    {
      get
      {
        return this.categoryId;
      }
      set
      {
        this.categoryId = value;
      }
    }

    public string CurrencyId
    {
      get
      {
        return this.currencyId;
      }
      set
      {
        this.currencyId = value;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
      set
      {
        this.description = value;
      }
    }

    public string PictureUrl
    {
      get
      {
        return this.pictureUrl;
      }
      set
      {
        this.pictureUrl = value;
      }
    }

    public int Quantity
    {
      get
      {
        return this.quantity;
      }
      set
      {
        this.quantity = value;
      }
    }

    public float UnitPrice
    {
      get
      {
        return this.unitPrice;
      }
      set
      {
        this.unitPrice = value;
      }
    }

    public string Title
    {
      get
      {
        return this.title;
      }
      set
      {
        this.title = value;
      }
    }
  }
}
