﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Category
{
﻿    [Serializable]
    public class AttValue : JdObject
    {
        [JsonProperty("aid")]
        public Nullable<Int64> Aid
        {
            get;
            set;
        }

        [JsonProperty("vid")]
        public Nullable<Int64> Vid
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

        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        [JsonProperty("index_id")]
        public Nullable<Int64> IndexId
        {
            get;
            set;
        }

        [JsonProperty("features")]
        public String Features
        {
            get;
            set;
        }

    }

}
