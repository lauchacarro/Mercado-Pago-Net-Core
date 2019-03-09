// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Refund
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json.Linq;
using System;

namespace MercadoPago.DataStructures.Payment
{
  public struct Refund
  {
    private int _id;
    private int _payment_id;
    private float _amount;
    private JObject _metadata;
    private MercadoPago.DataStructures.Payment.Source? _source;
    private DateTime? _created_date;
    private string _unique_sequence_number;

    public int Id
    {
      get
      {
        return this._id;
      }
      private set
      {
        this._id = value;
      }
    }

    public int PaymentId
    {
      get
      {
        return this._payment_id;
      }
      private set
      {
        this._payment_id = value;
      }
    }

    public float Amount
    {
      get
      {
        return this._amount;
      }
      private set
      {
        this._amount = value;
      }
    }

    public JObject Metadata
    {
      get
      {
        return this._metadata;
      }
      private set
      {
        this._metadata = value;
      }
    }

    public MercadoPago.DataStructures.Payment.Source? Source
    {
      get
      {
        return this._source;
      }
      private set
      {
        this._source = value;
      }
    }

    public DateTime? CreatedDate
    {
      get
      {
        return this._created_date;
      }
      private set
      {
        this._created_date = value;
      }
    }

    public string UniqueSequenceNumber
    {
      get
      {
        return this._unique_sequence_number;
      }
      private set
      {
        this._unique_sequence_number = value;
      }
    }
  }
}
