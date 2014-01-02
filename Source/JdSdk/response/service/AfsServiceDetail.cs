﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceDetail : JdObject
    {
        [JsonProperty("afsServiceDetailId")]
        public Nullable<Int32> AfsServiceDetailId
        {
            get;
            set;
        }

        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("wareId")]
        public Nullable<Int32> WareId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("wareDescribe")]
        public String WareDescribe
        {
            get;
            set;
        }

        [JsonProperty("wareBrand")]
        public String WareBrand
        {
            get;
            set;
        }

        [JsonProperty("wareCid1")]
        public Nullable<Int32> WareCid1
        {
            get;
            set;
        }

        [JsonProperty("wareCid2")]
        public Nullable<Int32> WareCid2
        {
            get;
            set;
        }

        [JsonProperty("wareCid3")]
        public Nullable<Int32> WareCid3
        {
            get;
            set;
        }

        [JsonProperty("createName")]
        public String CreateName
        {
            get;
            set;
        }

        [JsonProperty("updateName")]
        public String UpdateName
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        [JsonProperty("updateDate")]
        public Nullable<DateTime> UpdateDate
        {
            get;
            set;
        }

    }

}
