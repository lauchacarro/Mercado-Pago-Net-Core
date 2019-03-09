// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Plan.AutoRecurring
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Plan
{
  public struct AutoRecurring
  {
    private int frequency;
    private string frequencyType;
    private float transactionAmount;
    private CurrencyId currencyId;
    private int repetitions;
    private int debitDate;
    private FreeTrial freeTrial;

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

    public string FrequencyType
    {
      get
      {
        return this.frequencyType;
      }
      set
      {
        this.frequencyType = value;
      }
    }

    public float TransactionAmount
    {
      get
      {
        return this.transactionAmount;
      }
      set
      {
        this.transactionAmount = value;
      }
    }

    public CurrencyId CurrencyId
    {
      get
      {
        return this.currencyId;
      }
      set
      {
        this.currencyId = value;
      }
    }

    public int Repetitions
    {
      get
      {
        return this.repetitions;
      }
      set
      {
        this.repetitions = value;
      }
    }

    public int DebitDate
    {
      get
      {
        return this.debitDate;
      }
      set
      {
        this.debitDate = value;
      }
    }

    public FreeTrial FreeTrial
    {
      get
      {
        return this.freeTrial;
      }
      set
      {
        this.freeTrial = value;
      }
    }
  }
}
