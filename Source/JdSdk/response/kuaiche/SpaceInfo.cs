﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class SpaceInfo : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("detail")]
        public String Detail
        {
            get;
            set;
        }

        [JsonProperty("page_id")]
        public Nullable<Int64> PageId
        {
            get;
            set;
        }

        [JsonProperty("width")]
        public Nullable<Int32> Width
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public Nullable<Int32> Height
        {
            get;
            set;
        }

        [JsonProperty("traffic")]
        public Nullable<Int32> Traffic
        {
            get;
            set;
        }

        [JsonProperty("style")]
        public Nullable<Int32> Style
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

    }

}
