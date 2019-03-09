// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.MerchantOrder.MerchantOrderPayment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.MerchantOrder
{
  public struct MerchantOrderPayment
  {
    private string id;
    private float transactionAmount;
    private float totalPaidAmount;
    private float shippingCost;
    [StringLength(3)]
    private CurrencyId currencyId;
    private string status;
    private string statusDetail;
    private MerchantOrderPayment.OperationType operationType;
    private DateTime dateApproved;
    private DateTime dateCreated;
    private DateTime lastModified;
    private float amountRefunded;

    public string ID
    {
      get
      {
        return this.id;
      }
    }

    public float TransactionAmount
    {
      get
      {
        return this.transactionAmount;
      }
    }

    public float TotalPaidAmount
    {
      get
      {
        return this.totalPaidAmount;
      }
    }

    public float ShippingCost
    {
      get
      {
        return this.shippingCost;
      }
    }

    public CurrencyId PaymentCurrencyId
    {
      get
      {
        return this.currencyId;
      }
    }

    public string Status
    {
      get
      {
        return this.status;
      }
    }

    public string StatusDetail
    {
      get
      {
        return this.statusDetail;
      }
    }

    public MerchantOrderPayment.OperationType PaymentOperationType
    {
      get
      {
        return this.operationType;
      }
    }

    public DateTime DateApproved
    {
      get
      {
        return this.dateApproved;
      }
    }

    public DateTime DateCreated
    {
      get
      {
        return this.dateCreated;
      }
    }

    public DateTime LastModified
    {
      get
      {
        return this.lastModified;
      }
    }

    public float AmountRefunded
    {
      get
      {
        return this.amountRefunded;
      }
    }

    public enum OperationType
    {
      RegularPayment,
      PaymentAddition,
    }
  }
}
