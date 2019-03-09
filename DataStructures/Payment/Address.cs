// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Address
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Payment
{
  public struct Address
  {
    [StringLength(256)]
    private string _street_name;
    private int _street_number;
    [StringLength(256)]
    private string _zip_code;
    private string _neighborhood;
    private string _city;
    private string _federal_unit;

    public string StreetName
    {
      get
      {
        return this._street_name;
      }
      set
      {
        this._street_name = value;
      }
    }

    public int StreetNumber
    {
      get
      {
        return this._street_number;
      }
      set
      {
        this._street_number = value;
      }
    }

    public string ZipCode
    {
      get
      {
        return this._zip_code;
      }
      set
      {
        this._zip_code = value;
      }
    }

    public string Neighborhood
    {
      get
      {
        return this._neighborhood;
      }
      set
      {
        this._neighborhood = value;
      }
    }

    public string City
    {
      get
      {
        return this._city;
      }
      set
      {
        this._city = value;
      }
    }

    public string FederalUnit
    {
      get
      {
        return this._federal_unit;
      }
      set
      {
        this._federal_unit = value;
      }
    }
  }
}
