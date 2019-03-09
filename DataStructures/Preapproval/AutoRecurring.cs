// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preapproval.AutoRecurring
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preapproval
{
  public struct AutoRecurring
  {
    private int frequency;
    [JsonConverter(typeof (StringEnumConverter))]
    private FrequencyType frequency_type;
    private float transaction_amount;
    [StringLength(3)]
    private CurrencyId currency_id;
    private DateTime? start_date;
    private DateTime? end_date;

    public FrequencyType FrequencyType
    {
      get
      {
        return this.frequency_type;
      }
      set
      {
        this.frequency_type = value;
      }
    }

    public int Frequency
    {
      get
      {
        return this.frequency;
      }
      set
      {
        this.frequency = value;
      }
    }

    public float TransactionAmount
    {
      get
      {
        return this.transaction_amount;
      }
      set
      {
        this.transaction_amount = value;
      }
    }

    public CurrencyId CurrencyId
    {
      get
      {
        return this.currency_id;
      }
      set
      {
        this.currency_id = value;
      }
    }

    public DateTime? Start_date
    {
      get
      {
        return this.start_date;
      }
      set
      {
        this.start_date = value;
      }
    }

    public DateTime? End_date
    {
      get
      {
        return this.end_date;
      }
      set
      {
        this.end_date = value;
      }
    }
  }
}
