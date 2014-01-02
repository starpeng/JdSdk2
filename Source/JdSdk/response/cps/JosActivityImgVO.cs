﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class JosActivityImgVO : JdObject
    {
        [JsonProperty("activity_pk")]
        public Nullable<Int64> ActivityPk
        {
            get;
            set;
        }

        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
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

        [JsonProperty("activity_starttime")]
        public Nullable<DateTime> ActivityStarttime
        {
            get;
            set;
        }

        [JsonProperty("activity_endtime")]
        public Nullable<DateTime> ActivityEndtime
        {
            get;
            set;
        }

        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        [JsonProperty("img_pk")]
        public Nullable<Int64> ImgPk
        {
            get;
            set;
        }

        [JsonProperty("img_url")]
        public String ImgUrl
        {
            get;
            set;
        }

        [JsonProperty("img_width")]
        public Nullable<Int32> ImgWidth
        {
            get;
            set;
        }

        [JsonProperty("img_height")]
        public Nullable<Int32> ImgHeight
        {
            get;
            set;
        }

        [JsonProperty("img_urlprefix")]
        public String ImgUrlprefix
        {
            get;
            set;
        }

    }

}
