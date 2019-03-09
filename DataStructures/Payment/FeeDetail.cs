// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.FeeDetail
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
  public struct FeeDetail
  {
    private FeeType? _type;
    private FeePayerType? _fee_payer;
    private float? _amount;

    public FeeType? Type
    {
      get
      {
        return this._type;
      }
      private set
      {
        this._type = value;
      }
    }

    public FeePayerType? FeePayer
    {
      get
      {
        return this._fee_payer;
      }
      private set
      {
        this._fee_payer = value;
      }
    }

    public float? Amount
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
  }
}
