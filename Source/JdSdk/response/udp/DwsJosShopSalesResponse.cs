﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DwsJosShopSalesResponse : JdObject
    {
        [JsonProperty("onlProNum")]
        public Nullable<Int32> OnlProNum
        {
            get;
            set;
        }

        [JsonProperty("pv")]
        public Nullable<Int32> Pv
        {
            get;
            set;
        }

        [JsonProperty("visit")]
        public Nullable<Int32> Visit
        {
            get;
            set;
        }

        [JsonProperty("uv")]
        public Nullable<Int32> Uv
        {
            get;
            set;
        }

        [JsonProperty("ordQtty")]
        public Nullable<Int32> OrdQtty
        {
            get;
            set;
        }

        [JsonProperty("ordProNum")]
        public Nullable<Int32> OrdProNum
        {
            get;
            set;
        }

        [JsonProperty("ordAmount")]
        public Nullable<Double> OrdAmount
        {
            get;
            set;
        }

        [JsonProperty("ordCustNum")]
        public Nullable<Int32> OrdCustNum
        {
            get;
            set;
        }

        [JsonProperty("avgOrdPrice")]
        public Nullable<Double> AvgOrdPrice
        {
            get;
            set;
        }

        [JsonProperty("avgCustPrice")]
        public Nullable<Double> AvgCustPrice
        {
            get;
            set;
        }

        [JsonProperty("avgCustOrdNum")]
        public Nullable<Double> AvgCustOrdNum
        {
            get;
            set;
        }

        [JsonProperty("custRate")]
        public Nullable<Double> CustRate
        {
            get;
            set;
        }

        [JsonProperty("ordRate")]
        public Nullable<Double> OrdRate
        {
            get;
            set;
        }

    }

}
