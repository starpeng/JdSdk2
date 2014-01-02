﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class ActivitySafVo : JdObject
    {
        [JsonProperty("activity_pk")]
        public String ActivityPk
        {
            get;
            set;
        }

        [JsonProperty("activity_name")]
        public String ActivityName
        {
            get;
            set;
        }

        [JsonProperty("activity_url")]
        public String ActivityUrl
        {
            get;
            set;
        }

        [JsonProperty("activity_width")]
        public Nullable<Int32> ActivityWidth
        {
            get;
            set;
        }

        [JsonProperty("activity_height")]
        public Nullable<Int32> ActivityHeight
        {
            get;
            set;
        }

        [JsonProperty("activity_start")]
        public Nullable<DateTime> ActivityStart
        {
            get;
            set;
        }

        [JsonProperty("activity_end")]
        public Nullable<DateTime> ActivityEnd
        {
            get;
            set;
        }

        [JsonProperty("activity_shopName")]
        public String ActivityShopName
        {
            get;
            set;
        }

        [JsonProperty("activity_mainCategory")]
        public String ActivityMainCategory
        {
            get;
            set;
        }

        [JsonProperty("activity_commRatio")]
        public Nullable<Decimal> ActivityCommRatio
        {
            get;
            set;
        }

    }

}
