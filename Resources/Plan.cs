// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.Plan
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.Plan;
using System;

namespace MercadoPago.Resources
{
    public class Plan : MPBase
    {
        private string id;
        private float application_fee;
        private string status;
        private string description;
        private string external_reference;
        private DateTime? date_created;
        private DateTime? last_modified;
        private AutoRecurring auto_recurring;
        private bool live_mode;
        private float setup_fee;
        private string metadata;

        public Plan(SDK sdk) : base(sdk)
        {
        }

        [GETEndpoint("/v1/plans/:id")]
        public static MercadoPago.Resources.Plan Load(string id, bool useCache, SDK sdk)
        {
            return (MercadoPago.Resources.Plan)MPBase.ProcessMethod<MercadoPago.Resources.Plan>(typeof(MercadoPago.Resources.Plan), nameof(Load), id, useCache, sdk);
        }

        [POSTEndpoint("/v1/plans")]
        public MercadoPago.Resources.Plan Save(SDK sdk)
        {
            return (MercadoPago.Resources.Plan)this.ProcessMethod<MercadoPago.Resources.Plan>(nameof(Save), MPBase.WITHOUT_CACHE, sdk);
        }

        [PUTEndpoint("/v1/plans/:id")]
        public MercadoPago.Resources.Plan Update(SDK sdk)
        {
            return (MercadoPago.Resources.Plan)this.ProcessMethod<MercadoPago.Resources.Plan>(nameof(Update), MPBase.WITHOUT_CACHE, sdk);
        }

        public string Id
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

        public float Application_fee
        {
            get
            {
                return this.application_fee;
            }
            set
            {
                this.application_fee = value;
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public string External_reference
        {
            get
            {
                return this.external_reference;
            }
            set
            {
                this.external_reference = value;
            }
        }

        public DateTime? Date_created
        {
            get
            {
                return this.date_created;
            }
            set
            {
                this.date_created = value;
            }
        }

        public DateTime? Last_modified
        {
            get
            {
                return this.last_modified;
            }
            set
            {
                this.last_modified = value;
            }
        }

        public AutoRecurring Auto_recurring
        {
            get
            {
                return this.auto_recurring;
            }
            set
            {
                this.auto_recurring = value;
            }
        }

        public bool Live_mode
        {
            get
            {
                return this.live_mode;
            }
            set
            {
                this.live_mode = value;
            }
        }

        public float Setup_fee
        {
            get
            {
                return this.setup_fee;
            }
            set
            {
                this.setup_fee = value;
            }
        }

        public string Metadata
        {
            get
            {
                return this.metadata;
            }
            set
            {
                this.metadata = value;
            }
        }
    }
}
