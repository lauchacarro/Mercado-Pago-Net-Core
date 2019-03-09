// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Card
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.Customer.Card;
using System;
using System.Collections.Generic;

namespace MercadoPago.Resources
{
  public class Card : MPBase
  {
    private string _id;
    private string _customer_id;
    private int? _expiration_month;
    private int? _expiration_year;
    private string _first_six_digits;
    private string _last_four_digits;
    private CardPaymentMethod? _payment_method;
    private MercadoPago.DataStructures.Customer.Card.SecurityCode? _security_code;
    private MercadoPago.DataStructures.Customer.Card.Issuer? _issuer;
    private MercadoPago.DataStructures.Customer.Card.CardHolder? _card_holder;
    private DateTime? _date_created;
    private DateTime? _date_last_updated;
    private string _token;

        public Card(SDK sdk) : base(sdk)
        {
        }

        public static List<MercadoPago.Resources.Card> All(string customerId, SDK sdk)
    {
      return MercadoPago.Resources.Card.All(customerId, MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/v1/customers/:customer_id/cards")]
    public static List<MercadoPago.Resources.Card> All(string customerId, bool useCache, SDK sdk)
    {
      return MPBase.ProcessMethodBulk<MercadoPago.Resources.Card>(typeof (MercadoPago.Resources.Card), nameof (All), customerId, useCache, sdk);
    }

    public static MercadoPago.Resources.Card FindById(string customerId, string id, SDK sdk)
    {
      return MercadoPago.Resources.Card.FindById(customerId, id, MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/v1/customers/:customer_id/cards/:id")]
    public static MercadoPago.Resources.Card FindById(
      string customerId,
      string id,
      bool useCache, SDK sdk)
    {
      return (MercadoPago.Resources.Card) MPBase.ProcessMethod<MercadoPago.Resources.Card>(typeof (MercadoPago.Resources.Card), nameof (FindById), customerId, id, useCache, sdk);
    }

    [POSTEndpoint("/v1/customers/:customer_id/cards/")]
    public MercadoPago.Resources.Card Save(SDK sdk)
    {
      return (MercadoPago.Resources.Card) this.ProcessMethod<MercadoPago.Resources.Card>(nameof (Save), MPBase.WITHOUT_CACHE, sdk);
    }

    [PUTEndpoint("/v1/customers/:customer_id/cards/:id")]
    public MercadoPago.Resources.Card Update(SDK sdk)
    {
      return (MercadoPago.Resources.Card) this.ProcessMethod<MercadoPago.Resources.Card>(nameof (Update), MPBase.WITHOUT_CACHE, sdk);
    }

    [DELETEEndpoint("/v1/customers/:customer_id/cards/:id")]
    public MercadoPago.Resources.Card Delete(SDK sdk)
    {
      return (MercadoPago.Resources.Card) MPBase.ProcessMethod(nameof (Delete), MPBase.WITHOUT_CACHE, sdk);
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

    public string CustomerId
    {
      get
      {
        return this._customer_id;
      }
      set
      {
        this._customer_id = value;
      }
    }

    public int? ExpirationMonth
    {
      get
      {
        return this._expiration_month;
      }
      set
      {
        this._expiration_month = value;
      }
    }

    public int? ExpirationYear
    {
      get
      {
        return this._expiration_year;
      }
      set
      {
        this._expiration_year = value;
      }
    }

    public string FirstSixDigits
    {
      get
      {
        return this._first_six_digits;
      }
      set
      {
        this._first_six_digits = value;
      }
    }

    public string LastFourDigits
    {
      get
      {
        return this._last_four_digits;
      }
      set
      {
        this._last_four_digits = value;
      }
    }

    public CardPaymentMethod? PaymentMethod
    {
      get
      {
        return this._payment_method;
      }
      set
      {
        this._payment_method = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Card.SecurityCode? SecurityCode
    {
      get
      {
        return this._security_code;
      }
      set
      {
        this._security_code = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Card.Issuer? Issuer
    {
      get
      {
        return this._issuer;
      }
      set
      {
        this._issuer = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Card.CardHolder? CardHolder
    {
      get
      {
        return this._card_holder;
      }
      set
      {
        this._card_holder = value;
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

    public DateTime? DateLastUpdated
    {
      get
      {
        return this._date_last_updated;
      }
      set
      {
        this._date_last_updated = value;
      }
    }

    public string Token
    {
      get
      {
        return this._token;
      }
      set
      {
        this._token = value;
      }
    }
  }
}
