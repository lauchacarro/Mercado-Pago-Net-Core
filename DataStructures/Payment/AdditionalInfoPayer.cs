// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.AdditionalInfoPayer
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.DataStructures.Payment
{
  public struct AdditionalInfoPayer
  {
    private string _first_name;
    private string _last_name;
    private MercadoPago.DataStructures.Payment.Phone? _phone;
    private MercadoPago.DataStructures.Payment.Address? _address;
    private DateTime? _registration_date;

    public string FirstName
    {
      set
      {
        this._first_name = value;
      }
      get
      {
        return this._first_name;
      }
    }

    public string LastName
    {
      set
      {
        this._last_name = value;
      }
      get
      {
        return this._last_name;
      }
    }

    public MercadoPago.DataStructures.Payment.Phone? Phone
    {
      set
      {
        this._phone = value;
      }
      get
      {
        return this._phone;
      }
    }

    public MercadoPago.DataStructures.Payment.Address? Address
    {
      set
      {
        this._address = value;
      }
      get
      {
        return this._address;
      }
    }

    public DateTime? RegistrationDate
    {
      set
      {
        this._registration_date = value;
      }
      get
      {
        return this._registration_date;
      }
    }
  }
}
