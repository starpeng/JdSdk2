﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class WindowAdvDetail : JdObject
    {
        [JsonProperty("orderTime")]
        public Nullable<DateTime> OrderTime
        {
            get;
            set;
        }

        [JsonProperty("spaceName")]
        public String SpaceName
        {
            get;
            set;
        }

        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

        [JsonProperty("siteName")]
        public String SiteName
        {
            get;
            set;
        }

        [JsonProperty("clickNum")]
        public Nullable<Int64> ClickNum
        {
            get;
            set;
        }

        [JsonProperty("introductionOrders")]
        public Nullable<Int64> IntroductionOrders
        {
            get;
            set;
        }

        [JsonProperty("completeOrders")]
        public Nullable<Int64> CompleteOrders
        {
            get;
            set;
        }

        [JsonProperty("itemNum")]
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
