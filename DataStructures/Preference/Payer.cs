// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.Payer
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct Payer
  {
    [StringLength(256)]
    private string _name;
    [StringLength(256)]
    private string _surname;
    [StringLength(256)]
    private string _email;
    private MercadoPago.DataStructures.Preference.Phone? _phone;
    private MercadoPago.DataStructures.Preference.Identification? _identification;
    private MercadoPago.DataStructures.Preference.Address? _address;
    private DateTime? _date_created;

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

    public string Surname
    {
      get
      {
        return this._surname;
      }
      set
      {
        this._surname = value;
      }
    }

    public string Email
    {
      get
      {
        return this._email;
      }
      set
      {
        this._email = value;
      }
    }

    public MercadoPago.DataStructures.Preference.Phone? Phone
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

    public MercadoPago.DataStructures.Preference.Identification? Identification
    {
      get
      {
        return this._identification;
      }
      set
      {
        this._identification = value;
      }
    }

    public MercadoPago.DataStructures.Preference.Address? Address
    {
      get
      {
        return this._address;
      }
      set
      {
        this._address = value;
      }
    }

    public DateTime? Date_created
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
  }
}
