// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.MerchantOrder.Shipment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.DataStructures.MerchantOrder
{
  public struct Shipment
  {
    private int id;
    private string shipmentType;
    private string shipmentMode;
    private string pickingType;
    private string status;
    private string substatus;
    private object item;
    private DateTime dateCreated;
    private DateTime lastModified;
    private DateTime dateFirstPrinted;
    private string serviceId;
    private int senderId;
    private int receiverId;
    private Address address;

    public int ID
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

    public string ShipmentType
    {
      get
      {
        return this.shipmentType;
      }
      set
      {
        this.shipmentType = value;
      }
    }

    public string ShipmentMode
    {
      get
      {
        return this.shipmentMode;
      }
      set
      {
        this.shipmentMode = value;
      }
    }

    public string PickingType
    {
      get
      {
        return this.pickingType;
      }
      set
      {
        this.pickingType = value;
      }
    }

    public string Status
    {
      get
      {
        return this.status;
      }
      set
      {
        this.status = value;
      }
    }

    public string Substatus
    {
      get
      {
        return this.substatus;
      }
      set
      {
        this.substatus = value;
      }
    }

    public object Item
    {
      get
      {
        return this.item;
      }
      set
      {
        this.item = value;
      }
    }

    public DateTime DateCreated
    {
      get
      {
        return this.dateCreated;
      }
      set
      {
        this.dateCreated = value;
      }
    }

    public DateTime LastModified
    {
      get
      {
        return this.lastModified;
      }
      set
      {
        this.lastModified = value;
      }
    }

    public DateTime DateFirstPrinted
    {
      get
      {
        return this.dateFirstPrinted;
      }
      set
      {
        this.dateFirstPrinted = value;
      }
    }

    public string ServiceId
    {
      get
      {
        return this.serviceId;
      }
      set
      {
        this.serviceId = value;
      }
    }

    public int SenderId
    {
      get
      {
        return this.senderId;
      }
      set
      {
        this.senderId = value;
      }
    }

    public int ReceiverId
    {
      get
      {
        return this.receiverId;
      }
      set
      {
        this.receiverId = value;
      }
    }

    public Address Address
    {
      get
      {
        return this.address;
      }
      set
      {
        this.address = value;
      }
    }
  }
}
