﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Ware
{
﻿    [Serializable]
    public class WareAreaLimit : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
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

        [JsonProperty("area_fid")]
        public Nullable<Int32> AreaFid
        {
            get;
            set;
        }

        [JsonProperty("lev")]
        public Nullable<Int32> Lev
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

        [JsonProperty("area_ids")]
        public String AreaIds
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

    }

}
