// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Address
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer
{
  public struct Address
  {
    private string _id;
    private string _zip_code;
    private string _street_name;
    private string _street_number;

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
  }
}
