// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.MerchantOrder
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.MerchantOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.Resources
{
    public class MerchantOrder : MPBase
    {
        private string id;
        private string preferenceId;
        private DateTime? dateCreated;
        private DateTime? lastUpdate;
        private string applicationId;
        private string status;
        private string siteId;
        private Payer payer;
        private Collector collector;
        private long? sponsorId;
        private List<MerchantOrderPayment> payments;
        private float? paidAmount;
        private float? refundedAmount;
        private float? shippingCost;
        private bool? cancelled;
        private List<Item> items;
        private List<Shipment> shipments;
        [StringLength(500)]
        private string notificationUrl;
        [StringLength(600)]
        private string additionalInfo;
        [StringLength(256)]
        private string externalReference;
        [StringLength(256)]
        private string marketplace;
        private float? totalAmount;

        public MerchantOrder(SDK sdk) : base(sdk)
        {
        }

        public MercadoPago.Resources.MerchantOrder Load(string id)
        {
            return this.Load(id, MPBase.WITHOUT_CACHE);
        }

        [GETEndpoint("/merchant_orders/:id")]
        public MercadoPago.Resources.MerchantOrder Load(string id, bool useCache)
        {
            return (MercadoPago.Resources.MerchantOrder)MPBase.ProcessMethod<MercadoPago.Resources.MerchantOrder>(typeof(MercadoPago.Resources.MerchantOrder), nameof(Load), id, useCache, sdk);
        }

        [POSTEndpoint("/merchant_orders")]
        public MercadoPago.Resources.MerchantOrder Save()
        {
            return (MercadoPago.Resources.MerchantOrder)this.ProcessMethod<MercadoPago.Resources.MerchantOrder>(nameof(Save), MPBase.WITHOUT_CACHE, sdk);
        }

        [PUTEndpoint("/merchant_orders/:id")]
        public MercadoPago.Resources.MerchantOrder Update()
        {
            return (MercadoPago.Resources.MerchantOrder)this.ProcessMethod<MercadoPago.Resources.MerchantOrder>(nameof(Update), MPBase.WITHOUT_CACHE, sdk);
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string PreferenceId
        {
            get
            {
                return this.preferenceId;
            }
            set
            {
                this.preferenceId = value;
            }
        }

        public DateTime? DateCreated
        {
            get
            {
                return this.dateCreated;
            }
        }

        public DateTime? LastUpdate
        {
            get
            {
                return this.lastUpdate;
            }
        }

        public string ApplicationId
        {
            get
            {
                return this.applicationId;
            }
            set
            {
                this.applicationId = value;
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }
        }

        public string SiteId
        {
            get
            {
                return this.siteId;
            }
            set
            {
                this.siteId = value;
            }
        }

        public Payer Payer
        {
            get
            {
                return this.payer;
            }
            set
            {
                this.payer = value;
            }
        }

        public Collector Collector
        {
            get
            {
                return this.collector;
            }
            set
            {
                this.collector = value;
            }
        }

        public long? SponsorId
        {
            get
            {
                return this.sponsorId;
            }
            set
            {
                this.sponsorId = value;
            }
        }

        public List<MerchantOrderPayment> Payments
        {
            get
            {
                return this.payments;
            }
        }

        public float? PaidAmount
        {
            get
            {
                return this.paidAmount;
            }
        }

        public float? RefundedAmount
        {
            get
            {
                return this.refundedAmount;
            }
        }

        public float? ShippingCost
        {
            get
            {
                return this.shippingCost;
            }
        }

        public bool? Cancelled
        {
            get
            {
                return this.cancelled;
            }
            set
            {
                this.cancelled = value;
            }
        }

        public List<Item> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }

        public void AppendItem(Item item)
        {
            if (this.items == null)
                this.items = new List<Item>();
            this.items.Add(item);
        }

        public List<Shipment> Shipments
        {
            get
            {
                return this.shipments;
            }
            set
            {
                this.shipments = value;
            }
        }

        public void AppendShipment(Shipment shipment)
        {
            if (this.shipments == null)
                this.shipments = new List<Shipment>();
            this.shipments.Add(shipment);
        }

        public string NotificationUrl
        {
            get
            {
                return this.notificationUrl;
            }
            set
            {
                this.notificationUrl = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                this.additionalInfo = value;
            }
        }

        public string ExternalReference
        {
            get
            {
                return this.externalReference;
            }
            set
            {
                this.externalReference = value;
            }
        }

        public string Marketplace
        {
            get
            {
                return this.marketplace;
            }
            set
            {
                this.marketplace = value;
            }
        }

        public float? TotalAmount
        {
            get
            {
                return this.totalAmount;
            }
        }
    }
}
