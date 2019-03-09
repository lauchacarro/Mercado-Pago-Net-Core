// Decompiled with JetBrains decompiler
// Type: MercadoPago.Resources.PaymentMethod
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;
using System.Collections.Generic;

namespace MercadoPago.Resources
{
    public class PaymentMethod : MPBase
    {
        private string _id;
        private string _name;
        private PaymentTypeId _payment_type_id;
        private PaymentMethodStatus _status;
        private string _secure_thumbail;
        private string _thumbail;
        private PaymentMethodDeferredCapture _deferred_capture;
        private List<MercadoPago.DataStructures.PaymentMethod.Settings> _settings;
        private List<string> _additional_info_needed;
        private string _min_allowed_amount;
        private string _max_allowed_amount;
        private string _accreditation_time;
        private List<string> _financial_institutions;
        private List<string> _processing_mode;

        public PaymentMethod(SDK sdk) : base(sdk)
        {
        }

        public static List<MercadoPago.Resources.PaymentMethod> All(SDK sdk)
        {
            return MercadoPago.Resources.PaymentMethod.All(MPBase.WITHOUT_CACHE, sdk);
        }

        [GETEndpoint("/v1/payment_methods")]
        public static List<MercadoPago.Resources.PaymentMethod> All(bool useCache, SDK sdk)
        {
            return MPBase.ProcessMethodBulk<MercadoPago.Resources.PaymentMethod>(typeof(MercadoPago.Resources.PaymentMethod), nameof(All), useCache, sdk);
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

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public PaymentTypeId PaymentTypeId
        {
            get
            {
                return this._payment_type_id;
            }
            set
            {
                this._payment_type_id = value;
            }
        }

        public PaymentMethodStatus Status
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

        public string SecureThumbail
        {
            get
            {
                return this._secure_thumbail;
            }
            set
            {
                this._secure_thumbail = value;
            }
        }

        public string Thumbail
        {
            get
            {
                return this._thumbail;
            }
            set
            {
                this._thumbail = value;
            }
        }

        public PaymentMethodDeferredCapture DeferredCapture
        {
            get
            {
                return this._deferred_capture;
            }
            set
            {
                this._deferred_capture = value;
            }
        }

        public List<MercadoPago.DataStructures.PaymentMethod.Settings> Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                this._settings = value;
            }
        }

        public List<string> AdditionalInfoNeeded
        {
            get
            {
                return this._additional_info_needed;
            }
            set
            {
                this._additional_info_needed = value;
            }
        }

        public string MinAllowedAmount
        {
            get
            {
                return this._min_allowed_amount;
            }
            set
            {
                this._min_allowed_amount = value;
            }
        }

        public string MaxAllowedAmount
        {
            get
            {
                return this._max_allowed_amount;
            }
            set
            {
                this._max_allowed_amount = value;
            }
        }

        public string AccreditationTime
        {
            get
            {
                return this._accreditation_time;
            }
            set
            {
                this._accreditation_time = value;
            }
        }

        public List<string> FinancialInstitutions
        {
            get
            {
                return this._financial_institutions;
            }
            set
            {
                this._financial_institutions = value;
            }
        }

        public List<string> ProcessingMode
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
    }
}
