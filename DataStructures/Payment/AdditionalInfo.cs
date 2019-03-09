// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.AdditionalInfo
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.Collections.Generic;

namespace MercadoPago.DataStructures.Payment
{
  public struct AdditionalInfo
  {
    private string _ip_address;
    private List<Item> _items;
    private AdditionalInfoPayer? _payer;
    private Shipment? _shipments;
    private MercadoPago.DataStructures.Payment.Barcode? _barcode;

    public List<Item> Items
    {
      get
      {
        return this._items;
      }
      set
      {
        this._items = value;
      }
    }

    public AdditionalInfoPayer? Payer
    {
      get
      {
        return this._payer;
      }
      set
      {
        this._payer = value;
      }
    }

    public Shipment? Shipments
    {
      get
      {
        return this._shipments;
      }
      set
      {
        this._shipments = value;
      }
    }

    public MercadoPago.DataStructures.Payment.Barcode? Barcode
    {
      get
      {
        return this._barcode;
      }
      set
      {
        this._barcode = value;
      }
    }

    public string IpAddress
    {
      get
      {
        return this._ip_address;
      }
      set
      {
        this._ip_address = value;
      }
    }
  }
}
