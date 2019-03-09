// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.TransactionDetail
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Payment
{
  public struct TransactionDetail
  {
    private string _financial_institution;
    private float _net_received_amount;
    private float _total_paid_amount;
    private float _installment_amount;
    private float _overpaid_amount;
    private string _external_resource_url;
    private string _payment_method_reference_id;

    public string FinancialInstitution
    {
      get
      {
        return this._financial_institution;
      }
      set
      {
        this._financial_institution = value;
      }
    }

    public float NetReceivedAmount
    {
      get
      {
        return this._net_received_amount;
      }
      set
      {
        this._net_received_amount = value;
      }
    }

    public float TotalPaidAmount
    {
      get
      {
        return this._total_paid_amount;
      }
      set
      {
        this._total_paid_amount = value;
      }
    }

    public float InstallmentAmount
    {
      get
      {
        return this._installment_amount;
      }
      set
      {
        this._installment_amount = value;
      }
    }

    public float OverpaidAmount
    {
      get
      {
        return this._overpaid_amount;
      }
      set
      {
        this._overpaid_amount = value;
      }
    }

    public string ExternalResourceUrl
    {
      get
      {
        return this._external_resource_url;
      }
      set
      {
        this._external_resource_url = value;
      }
    }

    public string PaymentMethodReferenceId
    {
      get
      {
        return this._payment_method_reference_id;
      }
      set
      {
        this._payment_method_reference_id = value;
      }
    }
  }
}
