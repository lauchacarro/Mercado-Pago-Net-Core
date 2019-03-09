// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.CustomerAddress
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.DataStructures.Customer
{
  public struct CustomerAddress
  {
    private string _id;
    private string _phone;
    private string _name;
    private string _floor;
    private string _apartment;
    private string _street_name;
    private string _street_number;
    private string _zip_code;
    private MercadoPago.DataStructures.Customer.City? _city;
    private MercadoPago.DataStructures.Customer.State? _state;
    private MercadoPago.DataStructures.Customer.Country? _country;
    private MercadoPago.DataStructures.Customer.Neighborhood? _neighborhood;
    private MercadoPago.DataStructures.Customer.Municipality? _municipality;
    private string _comments;
    private DateTime? _date_created;
    private Verification _verifications;
    private bool _live_mode;

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

    public string Phone
    {
      get
      {
        return this._phone;
      }
      set
      {
        this._phone = value;
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

    public string Floor
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

    public string Apartment
    {
      get
      {
        return this._apartment;
      }
      set
      {
        this._apartment = value;
      }
    }

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

    public string StreetNumber
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

    public MercadoPago.DataStructures.Customer.City? City
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

    public MercadoPago.DataStructures.Customer.State? State
    {
      get
      {
        return this._state;
      }
      set
      {
        this._state = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Country? Country
    {
      get
      {
        return this._country;
      }
      set
      {
        this._country = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Neighborhood? Neighborhood
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

    public MercadoPago.DataStructures.Customer.Municipality? Municipality
    {
      get
      {
        return this._municipality;
      }
      set
      {
        this._municipality = value;
      }
    }

    public string Comments
    {
      get
      {
        return this._comments;
      }
      set
      {
        this._comments = value;
      }
    }

    public DateTime? DateCreated
    {
      get
      {
        return this._date_created;
      }
      set
      {
        this._date_created = value;
      }
    }

    public Verification Verifications
    {
      get
      {
        return this._verifications;
      }
      set
      {
        this._verifications = value;
      }
    }

    public bool LiveMode
    {
      get
      {
        return this._live_mode;
      }
      set
      {
        this._live_mode = value;
      }
    }
  }
}
