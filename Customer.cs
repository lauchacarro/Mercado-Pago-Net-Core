// Decompiled with JetBrains decompiler
// Type: MercadoPago.Customer
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.Customer;
using MercadoPago.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MercadoPago
{
  public class Customer : MPBase
  {
    private List<Card> _cards = new List<Card>();
    private List<CustomerAddress> _addresses = new List<CustomerAddress>();
    private string _id;
    private string _email;
    private string _first_name;
    private string _last_name;
    private MercadoPago.DataStructures.Customer.Phone? _phone;
    private MercadoPago.DataStructures.Customer.Identification? _identification;
    private string _default_address;
    private MercadoPago.DataStructures.Customer.Address? _address;
    private DateTime? _date_registered;
    private string _description;
    private DateTime? _date_created;
    private DateTime? _date_last_updated;
    private JObject _metadata;
    private string _default_card;
    private bool? _live_mode;
      
        public Customer(SDK sdk) : base(sdk)
        {
            
        }

        [GETEndpoint("/v1/customers/search")]
    public static List<MercadoPago.Customer> Search(Dictionary<string, string> filters, SDK sdk)
    {
      return MercadoPago.Customer.Search(filters, MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/v1/customers/search")]
    public static List<MercadoPago.Customer> Search(
      Dictionary<string, string> filters,
      bool useCache, SDK sdk)
    {
      return MPBase.ProcessMethodBulk<MercadoPago.Customer>(typeof (MercadoPago.Customer), nameof (Search), filters, useCache, sdk);
    }

    [GETEndpoint("/v1/customers/:id")]
    public static MercadoPago.Customer FindById(string id, bool useCache, SDK sdk)
    {
      return (MercadoPago.Customer) MPBase.ProcessMethod<MercadoPago.Customer>(nameof (FindById), id, useCache, sdk);
    }

    [GETEndpoint("/v1/customers/:id")]
    public static MercadoPago.Customer FindById(string id, SDK sdk)
    {
      return MercadoPago.Customer.FindById(id, MPBase.WITHOUT_CACHE, sdk);
    }

    [POSTEndpoint("/v1/customers")]
    public MercadoPago.Customer Save(SDK sdk)
    {
      return (MercadoPago.Customer) this.ProcessMethod<MercadoPago.Customer>(nameof (Save), MPBase.WITHOUT_CACHE, sdk);
    }

    [PUTEndpoint("/v1/customers/:id")]
    public MercadoPago.Customer Update(SDK sdk)
    {
      return (MercadoPago.Customer) this.ProcessMethod<MercadoPago.Customer>(nameof (Update), MPBase.WITHOUT_CACHE, sdk);
    }

    [DELETEEndpoint("/v1/customers/:id")]
    public MercadoPago.Customer Delete(SDK sdk)
    {
      return (MercadoPago.Customer) this.ProcessMethod<MercadoPago.Customer>(nameof (Delete), MPBase.WITHOUT_CACHE, sdk);
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

    public MercadoPago.DataStructures.Customer.Phone? Phone
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

    public MercadoPago.DataStructures.Customer.Identification? Identification
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

    public string DefaultAddress
    {
      get
      {
        return this._default_address;
      }
      set
      {
        this._default_address = value;
      }
    }

    public MercadoPago.DataStructures.Customer.Address? Address
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

    public DateTime? DateRegistered
    {
      get
      {
        return this._date_registered;
      }
      set
      {
        this._date_registered = value;
      }
    }

    public string Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
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

    public JObject Metadata
    {
      get
      {
        return this._metadata;
      }
      set
      {
        this._metadata = value;
      }
    }

    public string DefaultCard
    {
      get
      {
        return this._default_card;
      }
      set
      {
        this._default_card = value;
      }
    }

    public List<Card> Cards
    {
      get
      {
        return this._cards;
      }
      set
      {
        this._cards = value;
      }
    }

    public List<CustomerAddress> Addresses
    {
      get
      {
        return this._addresses;
      }
      set
      {
        this._addresses = value;
      }
    }

    public bool? LiveMode
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
