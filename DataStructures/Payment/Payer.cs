// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Payer
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
  public struct Payer
  {
    private EntityType? _entity_type;
    private PayerType? _type;
    private string _id;
    private string _email;
    private MercadoPago.DataStructures.Payment.Identification? _identification;
    private MercadoPago.DataStructures.Payment.Phone? _phone;
    private string _first_name;
    private string _last_name;
    private MercadoPago.DataStructures.Payment.Address? _address;

    public EntityType? Entity_type
    {
      get
      {
        return this._entity_type;
      }
      set
      {
        this._entity_type = value;
      }
    }

    public PayerType? Type
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }

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

    public MercadoPago.DataStructures.Payment.Identification? Identification
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

    public MercadoPago.DataStructures.Payment.Phone? Phone
    {
      get
      {
        return this._phone;
      }
      private set
      {
        this._phone = value;
      }
    }

    public string FirstName
    {
      get
      {
        return this._first_name;
      }
      set
      {
        this._first_name = value;
      }
    }

    public string LastName
    {
      get
      {
        return this._last_name;
      }
      set
      {
        this._last_name = value;
      }
    }

    public MercadoPago.DataStructures.Payment.Address? Address
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
  }
}
