// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Preference
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using MercadoPago.DataStructures.Preference;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.Resources
{
    public class Preference : MPBase
    {
        private List<Item> _items;
        private MercadoPago.DataStructures.Preference.Payer? _payer;
        private MercadoPago.DataStructures.Preference.PaymentMethods? _payment_methods;
        private Shipment? _shipments;
        private MercadoPago.DataStructures.Preference.BackUrls? _back_urls;
        [StringLength(500)]
        private string _notification_url;
        private string _id;
        private string _init_point;
        private string _sandbox_init_point;
        private DateTime? _date_created;
        [JsonConverter(typeof(StringEnumConverter))]
        private MercadoPago.Common.OperationType? _operation_type;
        [StringLength(600)]
        private string _additionalInfo;
        [JsonConverter(typeof(StringEnumConverter))]
        private AutoReturnType? _auto_return;
        [StringLength(256)]
        private string _external_reference;
        private bool? _expires;
        private DateTime? _expiration_date_from;
        private DateTime? _expiration_dateTo;
        private int? _collector_id;
        private string _client_id;
        [StringLength(256)]
        private string _marketplace;
        private float? _marketplace_fee;
        private DifferentialPricing? _differential_pricing;
        private long? _sponsor_id;
        private List<ProcessingMode> _processing_modes;
        private bool? _binary_mode;

        public Preference(SDK sdk) : base(sdk)
        {
        }

        public static MercadoPago.Resources.Preference FindById(string id, SDK sdk)
        {
            return MercadoPago.Resources.Preference.FindById(id, MPBase.WITHOUT_CACHE, sdk);
        }

        [GETEndpoint("/checkout/preferences/:id")]
        public static MercadoPago.Resources.Preference FindById(string id, bool useCache, SDK sdk)
        {
            return (MercadoPago.Resources.Preference)MPBase.ProcessMethod<MercadoPago.Resources.Preference>(typeof(MercadoPago.Resources.Preference), nameof(FindById), id, useCache, sdk);
        }

        [POSTEndpoint("/checkout/preferences")]
        public bool Save()
        {
            return this.ProcessMethodBool<MercadoPago.Resources.Preference>(nameof(Save), MPBase.WITHOUT_CACHE, sdk);
        }

        [PUTEndpoint("/checkout/preferences/:id")]
        public bool Update()
        {
            return this.ProcessMethodBool<MercadoPago.Resources.Preference>(nameof(Update), MPBase.WITHOUT_CACHE, sdk);
        }

        public MercadoPago.DataStructures.Preference.Payer? Payer
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

        public MercadoPago.DataStructures.Preference.PaymentMethods? PaymentMethods
        {
            get
            {
                return this._payment_methods;
            }
            set
            {
                this._payment_methods = value;
            }
        }

        public Shipment? Shipments
        {
            get
            {
                return this._shipments;
            }
            set
            {
                this._shipments = value;
            }
        }

        public MercadoPago.DataStructures.Preference.BackUrls? BackUrls
        {
            get
            {
                return this._back_urls;
            }
            set
            {
                this._back_urls = value;
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

        public string InitPoint
        {
            get
            {
                return this._init_point;
            }
            private set
            {
                this._init_point = value;
            }
        }

        public string SandboxInitPoint
        {
            get
            {
                return this._sandbox_init_point;
            }
            set
            {
                this._sandbox_init_point = value;
            }
        }

        public DateTime? Datecreated
        {
            get
            {
                return this._date_created;
            }
            set
            {
                this._date_created = value;
            }
        }

        public MercadoPago.Common.OperationType? OperationType
        {
            get
            {
                return this._operation_type;
            }
            set
            {
                this._operation_type = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this._additionalInfo;
            }
            set
            {
                this._additionalInfo = value;
            }
        }

        public AutoReturnType? AutoReturn
        {
            get
            {
                return this._auto_return;
            }
            set
            {
                this._auto_return = value;
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

        public bool? Expires
        {
            get
            {
                return this._expires;
            }
            set
            {
                this._expires = value;
            }
        }

        public DateTime? ExpirationDateFrom
        {
            get
            {
                return this._expiration_date_from;
            }
            set
            {
                this._expiration_date_from = value;
            }
        }

        public DateTime? ExpirationDateTo
        {
            get
            {
                return this._expiration_dateTo;
            }
            set
            {
                this._expiration_dateTo = value;
            }
        }

        public int? CollectorId
        {
            get
            {
                return this._collector_id;
            }
            set
            {
                this._collector_id = value;
            }
        }

        public string ClientId
        {
            get
            {
                return this._client_id;
            }
            set
            {
                this._client_id = value;
            }
        }

        public string Marketplace
        {
            get
            {
                return this._marketplace;
            }
            set
            {
                this._marketplace = value;
            }
        }

        public float? Marketplace_fee
        {
            get
            {
                return this._marketplace_fee;
            }
            set
            {
                this._marketplace_fee = value;
            }
        }

        public DifferentialPricing? Differential_pricing
        {
            get
            {
                return this._differential_pricing;
            }
            set
            {
                this._differential_pricing = value;
            }
        }

        public List<Item> Items
        {
            get
            {
                if (this._items == null)
                    this._items = new List<Item>();
                return this._items;
            }
            set
            {
                this._items = value;
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

        public List<ProcessingMode> ProcessingModes
        {
            get
            {
                if (this._processing_modes == null)
                    this._processing_modes = new List<ProcessingMode>();
                return this._processing_modes;
            }
            set
            {
                this._processing_modes = value;
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
    }
}
