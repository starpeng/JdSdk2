﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class SpacePageInfo : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("available")]
        public Nullable<Int32> Available
        {
            get;
            set;
        }

        [JsonProperty("category_name")]
        public String CategoryName
        {
            get;
            set;
        }

        [JsonProperty("parent_id")]
        public Nullable<Int64> ParentId
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public String Url
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

    }

}
