// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Refund
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago.Resources
{
    public class Refund : MPBase
    {
        private Decimal? _id;
        private Decimal? _amount;
        private Decimal? _payment_id;
        private DateTime? _date_created;
        private string _errors;

        public Refund(SDK sdk) : base(sdk)
        {
        }

        [POSTEndpoint("/v1/payments/:payment_id/refunds")]
        public Refund Save()
        {
            return (Refund)this.ProcessMethod<Refund>(nameof(Save), MPBase.WITHOUT_CACHE, sdk);
        }

        public void manualSetPaymentId(Decimal id)
        {
            this.PaymentId = new Decimal?(id);
        }

        public Decimal? Id
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

        public Decimal? Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }

        public Decimal? PaymentId
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

        public DateTime? DateCreated
        {
            get
            {
                return this._date_created;
            }
            private set
            {
                this._date_created = value;
            }
        }

        public string Errors
        {
            get
            {
                return this._errors;
            }
            set
            {
                this._errors = value;
            }
        }
    }
}
