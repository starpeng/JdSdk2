﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Promotion
{
﻿    [Serializable]
    public class Promotion : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int32> Id
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

        [JsonProperty("promo_name")]
        public String PromoName
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        [JsonProperty("level_member")]
        public String LevelMember
        {
            get;
            set;
        }

        [JsonProperty("time_begin")]
        public String TimeBegin
        {
            get;
            set;
        }

        [JsonProperty("time_end")]
        public String TimeEnd
        {
            get;
            set;
        }

        [JsonProperty("evt_status")]
        public String EvtStatus
        {
            get;
            set;
        }

        [JsonProperty("synch_status")]
        public String SynchStatus
        {
            get;
            set;
        }

        [JsonProperty("check_status")]
        public String CheckStatus
        {
            get;
            set;
        }

        [JsonProperty("promotion_product_list")]
        public List<PromotionProduct> PromotionProductList
        {
            get;
            set;
        }

    }

}
