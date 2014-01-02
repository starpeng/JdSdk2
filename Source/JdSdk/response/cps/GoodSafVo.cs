﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class GoodSafVo : JdObject
    {
        [JsonProperty("good_pk")]
        public Nullable<Int64> GoodPk
        {
            get;
            set;
        }

        [JsonProperty("good_skuId")]
        public Nullable<Int64> GoodSkuId
        {
            get;
            set;
        }

        [JsonProperty("good_shopName")]
        public String GoodShopName
        {
            get;
            set;
        }

        [JsonProperty("good_name")]
        public String GoodName
        {
            get;
            set;
        }

        [JsonProperty("good_price")]
        public Nullable<Decimal> GoodPrice
        {
            get;
            set;
        }

        [JsonProperty("good_praiseDegree")]
        public Nullable<Decimal> GoodPraiseDegree
        {
            get;
            set;
        }

        [JsonProperty("good_targetUrl")]
        public String GoodTargetUrl
        {
            get;
            set;
        }

        [JsonProperty("good_shopUrl")]
        public String GoodShopUrl
        {
            get;
            set;
        }

        [JsonProperty("good_materialUrl")]
        public String GoodMaterialUrl
        {
            get;
            set;
        }

        [JsonProperty("good_commRatio")]
        public Nullable<Decimal> GoodCommRatio
        {
            get;
            set;
        }

        [JsonProperty("good_commision")]
        public Nullable<Decimal> GoodCommision
        {
            get;
            set;
        }

        [JsonProperty("good_promQuantity")]
        public Nullable<Int64> GoodPromQuantity
        {
            get;
            set;
        }

        [JsonProperty("good_startDate")]
        public Nullable<DateTime> GoodStartDate
        {
            get;
            set;
        }

        [JsonProperty("good_endDate")]
        public Nullable<DateTime> GoodEndDate
        {
            get;
            set;
        }

    }

}
