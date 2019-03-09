// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.MerchantOrder.Address
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.MerchantOrder
{
  public struct Address
  {
    [StringLength(256)]
    private string zipCode;
    [StringLength(256)]
    private string streetName;
    private int streetNumber;
    [StringLength(256)]
    private string floor;
    [StringLength(256)]
    private string apartment;

    public string ZipCode
    {
      get
      {
        return this.zipCode;
      }
      set
      {
        this.zipCode = value;
      }
    }

    public string StreetName
    {
      get
      {
        return this.streetName;
      }
      set
      {
        this.streetName = value;
      }
    }

    public int StreetNumber
    {
      get
      {
        return this.streetNumber;
      }
      set
      {
        this.streetNumber = value;
      }
    }

    public string Floor
    {
      get
      {
        return this.floor;
      }
      set
      {
        this.floor = value;
      }
    }

    public string Apartment
    {
      get
      {
        return this.apartment;
      }
      set
      {
        this.apartment = value;
      }
    }
  }
}
