// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Preapproval
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.Resources
{
  public class Preapproval : MPBase
  {
    [StringLength(256)]
    private string _payer_email;
    [StringLength(500)]
    private string _back_url;
    private string _id;
    private string _init_point;
    private string _sandbox_init_point;
    [StringLength(256)]
    private string _external_reference;
    private string _reason;
    private MercadoPago.DataStructures.Preapproval.AutoRecurring? _auto_recurring;

        public Preapproval(SDK sdk) : base(sdk)
        {
        }

        public static MercadoPago.Resources.Preapproval FindById(string id, SDK sdk)
    {
      return MercadoPago.Resources.Preapproval.FindById(id, MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/preapproval/:id")]
    public static MercadoPago.Resources.Preapproval FindById(string id, bool useCache, SDK sdk)
    {
      return (MercadoPago.Resources.Preapproval) MPBase.ProcessMethod<MercadoPago.Resources.Preapproval>(typeof (MercadoPago.Resources.Preapproval), nameof (FindById), id, useCache, sdk);
    }

    [POSTEndpoint("/preapproval")]
    public bool Save(SDK sdk)
    {
      return this.ProcessMethodBool<MercadoPago.Resources.Preapproval>(nameof (Save), MPBase.WITHOUT_CACHE, sdk);
    }

    [PUTEndpoint("/preapproval/:id")]
    public bool Update(SDK sdk)
    {
      return this.ProcessMethodBool<MercadoPago.Resources.Preapproval>(nameof (Update), MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/preapproval/search")]
    public static List<MercadoPago.Resources.Preapproval> Search(
      Dictionary<string, string> filters, SDK sdk)
    {
      return MercadoPago.Resources.Preapproval.Search(filters, MPBase.WITHOUT_CACHE, sdk);
    }

    [GETEndpoint("/preapproval/search")]
    public static List<MercadoPago.Resources.Preapproval> Search(
      Dictionary<string, string> filters,
      bool useCache, SDK sdk)
    {
      return MPBase.ProcessMethodBulk<MercadoPago.Resources.Preapproval>(typeof (MercadoPago.Resources.Preapproval), nameof (Search), filters, useCache, sdk);
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

    public string Reason
    {
      get
      {
        return this._reason;
      }
      set
      {
        this._reason = value;
      }
    }

    public string PayerEmail
    {
      get
      {
        return this._payer_email;
      }
      set
      {
        this._payer_email = value;
      }
    }

    public string BackUrl
    {
      get
      {
        return this._back_url;
      }
      set
      {
        this._back_url = value;
      }
    }

    public string InitPoint
    {
      get
      {
        return this._init_point;
      }
      private set
      {
        this._init_point = value;
      }
    }

    public string SandboxInitPoint
    {
      get
      {
        return this._sandbox_init_point;
      }
      set
      {
        this._sandbox_init_point = value;
      }
    }

    public MercadoPago.DataStructures.Preapproval.AutoRecurring? AutoRecurring
    {
      get
      {
        return this._auto_recurring;
      }
      set
      {
        this._auto_recurring = value;
      }
    }

    public string ExternalReference
    {
      get
      {
        return this._external_reference;
      }
      set
      {
        this._external_reference = value;
      }
    }
  }
}
