// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.PaymentMethods
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct PaymentMethods
  {
    private List<PaymentMethod> _excluded_payment_methods;
    private List<PaymentType> _excluded_payment_types;
    [StringLength(256)]
    private string _default_payment_method_id;
    private int? _installments;
    private int? _default_installments;

    public List<PaymentMethod> ExcludedPaymentMethods
    {
      get
      {
        return this._excluded_payment_methods;
      }
      set
      {
        this._excluded_payment_methods = value;
      }
    }

    public List<PaymentType> ExcludedPaymentTypes
    {
      get
      {
        return this._excluded_payment_types;
      }
      set
      {
        this._excluded_payment_types = value;
      }
    }

    public string DefaultPaymentMethodId
    {
      get
      {
        return this._default_payment_method_id;
      }
      set
      {
        this._default_payment_method_id = value;
      }
    }

    public int? Installments
    {
      get
      {
        return new int?(this._installments ?? 1);
      }
      set
      {
        this._installments = value;
      }
    }

    public int? DefaultInstallments
    {
      get
      {
        return this._default_installments;
      }
      set
      {
        this._default_installments = value;
      }
    }
  }
}
