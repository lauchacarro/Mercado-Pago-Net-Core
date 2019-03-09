// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Card
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.DataStructures.Payment
{
  public struct Card
  {
    private string _id;
    private string _lastFourDigits;
    private string _firstSixDigits;
    private int? _expirationYear;
    private int? _expirationMonth;
    private DateTime? _dateCreated;
    private DateTime? _dateLastUpdated;
    private MercadoPago.DataStructures.Payment.CardHolder? _cardHolder;

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

    public string LastFourDigits
    {
      get
      {
        return this._lastFourDigits;
      }
      private set
      {
        this._lastFourDigits = value;
      }
    }

    public string FirstSixDigits
    {
      get
      {
        return this._firstSixDigits;
      }
      private set
      {
        this._firstSixDigits = value;
      }
    }

    public int? ExpirationYear
    {
      get
      {
        return this._expirationYear;
      }
      set
      {
        this._expirationYear = value;
      }
    }

    public int? ExpirationMonth
    {
      get
      {
        return this._expirationMonth;
      }
      set
      {
        this._expirationMonth = value;
      }
    }

    public DateTime? DateCreated
    {
      get
      {
        return this._dateCreated;
      }
      set
      {
        this._dateCreated = value;
      }
    }

    public DateTime? DateLastUpdated
    {
      get
      {
        return this._dateLastUpdated;
      }
      set
      {
        this._dateLastUpdated = value;
      }
    }

    public MercadoPago.DataStructures.Payment.CardHolder? CardHolder
    {
      get
      {
        return this._cardHolder;
      }
      set
      {
        this._cardHolder = value;
      }
    }
  }
}
