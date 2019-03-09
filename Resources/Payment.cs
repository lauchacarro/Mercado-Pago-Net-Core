// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Payment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using MercadoPago.DataStructures.Payment;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.Resources
{
    public class Payment : MPBase
    {
        private long? _id;
        private DateTime? _date_created;
        private DateTime? _date_approved;
        private DateTime? _date_last_updated;
        private DateTime? _money_release_date;
        private int? _collector_id;
        [JsonConverter(typeof(StringEnumConverter))]
        private MercadoPago.Common.OperationType? _operation_type;
        private Payer _payer;
        private bool? _binary_mode;
        private bool? _live_mode;
        private MercadoPago.DataStructures.Payment.Order? _order;
        private string _external_reference;
        private string _description;
        private JObject _metadata;
        [StringLength(3)]
        [JsonConverter(typeof(StringEnumConverter))]
        private MercadoPago.Common.CurrencyId? _currency_id;
        private float? _transaction_amount;
        private float? _transaction_amount_refunded;
        private float? _coupon_amount;
        private int? _campaign_id;
        private string _coupon_code;
        private TransactionDetail? _transaction_details;
        private List<FeeDetail> _fee_details;
        private int? _differential_pricing_id;
        private float? _application_fee;
        [JsonConverter(typeof(StringEnumConverter))]
        private PaymentStatus? _status;
        private string _status_detail;
        private bool? _capture;
        private bool? _captured;
        private string _call_for_authorize_id;
        private string _payment_method_id;
        private string _issuer_id;
        [JsonConverter(typeof(StringEnumConverter))]
        private MercadoPago.Common.PaymentTypeId? _payment_type_id;
        private string _token;
        private MercadoPago.DataStructures.Payment.Card? _card;
        private string _statement_descriptor;
        private int? _installments;
        private string _notification_url;
        private string _callback_url;
        private List<Refund> _refunds;
        private MercadoPago.DataStructures.Payment.AdditionalInfo? _additional_info;
        private string _processing_mode;
        private string _merchant_account_id;
        private DateTime? _date_of_expiration;
        private long? _sponsor_id;

       
        public Payment(SDK sdk) : base(sdk)
        {
        }

        [GETEndpoint("/v1/payments/:id")]
        public static MercadoPago.Resources.Payment FindById(long? id, SDK sdk)
        {
            return (MercadoPago.Resources.Payment)MPBase.ProcessMethod<MercadoPago.Resources.Payment>(typeof(MercadoPago.Resources.Payment), nameof(FindById), id.ToString(), MPBase.WITHOUT_CACHE, sdk);
        }

        [GETEndpoint("/v1/payments/:id")]
        public static MercadoPago.Resources.Payment FindById(long? id, bool useCache, SDK sdk)
        {
            return (MercadoPago.Resources.Payment)MPBase.ProcessMethod<MercadoPago.Resources.Payment>(typeof(MercadoPago.Resources.Payment), nameof(FindById), id.ToString(), useCache, sdk);
        }

        [POSTEndpoint("/v1/payments")]
        public bool Save()
        {
            return this.ProcessMethodBool<MercadoPago.Resources.Payment>(nameof(Save), MPBase.WITHOUT_CACHE, sdk);
        }

        [PUTEndpoint("/v1/payments/:id")]
        public bool Update()
        {
            return this.ProcessMethodBool<MercadoPago.Resources.Payment>(nameof(Update), MPBase.WITHOUT_CACHE, sdk);
        }

        public static List<MercadoPago.Resources.Payment> All(SDK sdk)
        {
            return MercadoPago.Resources.Payment.All(MPBase.WITHOUT_CACHE,  sdk);
        }

        public static List<MercadoPago.Resources.Payment> Search(
          Dictionary<string, string> filters, SDK sdk)
        {
            return MercadoPago.Resources.Payment.Search(filters, MPBase.WITHOUT_CACHE, sdk);
        }

        [GETEndpoint("/v1/payments/search")]
        public static List<MercadoPago.Resources.Payment> All(bool useCache, SDK sdk)
        {
            return MPBase.ProcessMethodBulk<MercadoPago.Resources.Payment>(typeof(MercadoPago.Resources.Payment), "Search", useCache, sdk);
        }

        [GETEndpoint("/v1/payments/search")]
        public static List<MercadoPago.Resources.Payment> Search(
          Dictionary<string, string> filters,
          bool useCache, SDK sdk)
        {
            return MPBase.ProcessMethodBulk<MercadoPago.Resources.Payment>(typeof(MercadoPago.Resources.Payment), nameof(Search), filters, useCache, sdk);
        }

        public MercadoPago.Resources.Payment Refund()
        {
            Refund refund = new Refund(sdk);
            refund.manualSetPaymentId((Decimal)this.Id.Value);
            refund.Save();
            if (refund.Id.HasValue)
                this.Status = new PaymentStatus?(PaymentStatus.refunded);
            return this;
        }

        public MercadoPago.Resources.Payment Refund(Decimal amount)
        {
            Refund refund = new Refund(sdk);
            refund.manualSetPaymentId((Decimal)this.Id.Value);
            refund.Amount = new Decimal?(amount);
            refund.Save();
            if (refund.Id.HasValue)
                this.Status = new PaymentStatus?(PaymentStatus.refunded);
            return this;
        }

        public long? Id
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

        public DateTime? DateApproved
        {
            get
            {
                return this._date_approved;
            }
            private set
            {
                this._date_approved = value;
            }
        }

        public DateTime? DateLastUpdated
        {
            get
            {
                return this._date_last_updated;
            }
            private set
            {
                this._date_last_updated = value;
            }
        }

        public DateTime? MoneyReleaseDate
        {
            get
            {
                return this._money_release_date;
            }
            private set
            {
                this._money_release_date = value;
            }
        }

        public int? CollectorId
        {
            get
            {
                return this._collector_id;
            }
            private set
            {
                this._collector_id = value;
            }
        }

        public MercadoPago.Common.OperationType? OperationType
        {
            get
            {
                return this._operation_type;
            }
            private set
            {
                this._operation_type = value;
            }
        }

        public Payer Payer
        {
            get
            {
                return this._payer;
            }
            set
            {
                this._payer = value;
            }
        }

        public bool? BinaryMode
        {
            get
            {
                return this._binary_mode;
            }
            set
            {
                this._binary_mode = value;
            }
        }

        public bool? LiveMode
        {
            get
            {
                return this._live_mode;
            }
            private set
            {
                this._live_mode = value;
            }
        }

        public MercadoPago.DataStructures.Payment.Order? Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
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

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public JObject Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }

        public MercadoPago.Common.CurrencyId? CurrencyId
        {
            get
            {
                return this._currency_id;
            }
            private set
            {
                this._currency_id = value;
            }
        }

        public float? TransactionAmount
        {
            get
            {
                return this._transaction_amount;
            }
            set
            {
                this._transaction_amount = value;
            }
        }

        public float? TransactionAmountRefunded
        {
            get
            {
                return this._transaction_amount_refunded;
            }
            private set
            {
                this._transaction_amount_refunded = value;
            }
        }

        public float? CouponAmount
        {
            get
            {
                return this._coupon_amount;
            }
            set
            {
                this._coupon_amount = value;
            }
        }

        public int? CampaignId
        {
            private get
            {
                return this._campaign_id;
            }
            set
            {
                this._campaign_id = value;
            }
        }

        public string CouponCode
        {
            private get
            {
                return this._coupon_code;
            }
            set
            {
                this._coupon_code = value;
            }
        }

        public TransactionDetail? TransactionDetails
        {
            get
            {
                return this._transaction_details;
            }
            private set
            {
                this._transaction_details = value;
            }
        }

        public List<FeeDetail> FeeDetails
        {
            get
            {
                return this._fee_details;
            }
            private set
            {
                this._fee_details = value;
            }
        }

        public int? DifferentialPricingId
        {
            get
            {
                return this._differential_pricing_id;
            }
            set
            {
                this._differential_pricing_id = value;
            }
        }

        public float? ApplicationFee
        {
            private get
            {
                return this._application_fee;
            }
            set
            {
                this._application_fee = value;
            }
        }

        public PaymentStatus? Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        public string StatusDetail
        {
            get
            {
                return this._status_detail;
            }
            private set
            {
                this._status_detail = value;
            }
        }

        public bool? Capture
        {
            private get
            {
                return this._capture;
            }
            set
            {
                this._capture = value;
            }
        }

        public bool? Captured
        {
            get
            {
                return this._captured;
            }
            private set
            {
                this._captured = value;
            }
        }

        public string CallForAuthorizeId
        {
            get
            {
                return this._call_for_authorize_id;
            }
            private set
            {
                this._call_for_authorize_id = value;
            }
        }

        public string PaymentMethodId
        {
            get
            {
                return this._payment_method_id;
            }
            set
            {
                this._payment_method_id = value;
            }
        }

        public string IssuerId
        {
            get
            {
                return this._issuer_id;
            }
            set
            {
                this._issuer_id = value;
            }
        }

        public MercadoPago.Common.PaymentTypeId? PaymentTypeId
        {
            get
            {
                return this._payment_type_id;
            }
            private set
            {
                this._payment_type_id = value;
            }
        }

        public string Token
        {
            private get
            {
                return this._token;
            }
            set
            {
                this._token = value;
            }
        }

        public MercadoPago.DataStructures.Payment.Card? Card
        {
            get
            {
                return this._card;
            }
            private set
            {
                this._card = value;
            }
        }

        public string StatementDescriptor
        {
            get
            {
                return this._statement_descriptor;
            }
            set
            {
                this._statement_descriptor = value;
            }
        }

        public int? Installments
        {
            get
            {
                return this._installments;
            }
            set
            {
                this._installments = value;
            }
        }

        public string NotificationUrl
        {
            get
            {
                return this._notification_url;
            }
            set
            {
                this._notification_url = value;
            }
        }

        public string CallbackUrl
        {
            get
            {
                return this._callback_url;
            }
            set
            {
                this._callback_url = value;
            }
        }

        public List<Refund> Refunds
        {
            get
            {
                return this._refunds;
            }
            private set
            {
                this._refunds = value;
            }
        }

        public MercadoPago.DataStructures.Payment.AdditionalInfo? AdditionalInfo
        {
            private get
            {
                return this._additional_info;
            }
            set
            {
                this._additional_info = value;
            }
        }

        public string ProcessingMode
        {
            get
            {
                return this._processing_mode;
            }
            set
            {
                this._processing_mode = value;
            }
        }

        public string MerchantAccountId
        {
            get
            {
                return this._merchant_account_id;
            }
            set
            {
                this._merchant_account_id = value;
            }
        }

        public DateTime? DateOfExpiration
        {
            get
            {
                return this._date_of_expiration;
            }
            set
            {
                this._date_of_expiration = value;
            }
        }

        public long? SponsorId
        {
            get
            {
                return this._sponsor_id;
            }
            set
            {
                this._sponsor_id = value;
            }
        }
    }
}
