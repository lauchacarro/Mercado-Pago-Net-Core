// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.Shipment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using System.Collections.Generic;

namespace MercadoPago.DataStructures.Preference
{
  public struct Shipment
  {
    private ShipmentMode? _mode;
    private bool _local_pick_up;
    private string _dimensions;
    private int _default_shipping_method;
    private List<int> _free_methods;
    private float _cost;
    private bool _free_shipping;
    private MercadoPago.DataStructures.Preference.ReceiverAddress? _receiver_address;

    public ShipmentMode? Mode
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

    public bool LocalPickUp
    {
      get
      {
        return this._local_pick_up;
      }
      set
      {
        this._local_pick_up = value;
      }
    }

    public string Dimensions
    {
      get
      {
        return this._dimensions;
      }
      set
      {
        this._dimensions = value;
      }
    }

    public int DefaultShippingMethod
    {
      get
      {
        return this._default_shipping_method;
      }
      set
      {
        this._default_shipping_method = value;
      }
    }

    public List<int> FreeMethods
    {
      get
      {
        return this._free_methods;
      }
      set
      {
        this._free_methods = value;
      }
    }

    public float Cost
    {
      get
      {
        return this._cost;
      }
      set
      {
        this._cost = value;
      }
    }

    public bool FreeShipping
    {
      get
      {
        return this._free_shipping;
      }
      set
      {
        this._free_shipping = value;
      }
    }

    public MercadoPago.DataStructures.Preference.ReceiverAddress? ReceiverAddress
    {
      get
      {
        return this._receiver_address;
      }
      set
      {
        this._receiver_address = value;
      }
    }
  }
}
