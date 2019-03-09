// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Card.CardPaymentMethod
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer.Card
{
  public struct CardPaymentMethod
  {
    private string _id;
    private string _name;
    private string _payment_type_id;
    private string _thumbnail;
    private string _secure_thumbnail;

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

    public string PaymentTypeId
    {
      get
      {
        return this._payment_type_id;
      }
      set
      {
        this._payment_type_id = value;
      }
    }

    public string Thumbnail
    {
      get
      {
        return this._thumbnail;
      }
      set
      {
        this._thumbnail = value;
      }
    }

    public string SecureThumbnail
    {
      get
      {
        return this._secure_thumbnail;
      }
      set
      {
        this._secure_thumbnail = value;
      }
    }
  }
}
