﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class OverviewVo : JdObject
    {
        [JsonProperty("order_time")]
        public Nullable<DateTime> OrderTime
        {
            get;
            set;
        }

        [JsonProperty("click_num")]
        public Nullable<Int64> ClickNum
        {
            get;
            set;
        }

        [JsonProperty("introduction_orders")]
        public Nullable<Int64> IntroductionOrders
        {
            get;
            set;
        }

        [JsonProperty("complete_orders")]
        public Nullable<Int64> CompleteOrders
        {
            get;
            set;
        }

        [JsonProperty("item_num")]
        public Nullable<Int64> ItemNum
        {
            get;
            set;
        }

        [JsonProperty("amount")]
        public Nullable<Double> Amount
        {
            get;
            set;
        }

        [JsonProperty("commission")]
        public Nullable<Double> Commission
        {
            get;
            set;
        }

    }

}
