﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ProductSort : JdObject
    {
        [JsonProperty("product_sort_id")]
        public Nullable<Int32> ProductSortId
        {
            get;
            set;
        }

        [JsonProperty("father_id")]
        public Nullable<Int32> FatherId
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

        [JsonProperty("is_delete")]
        public Nullable<Int32> IsDelete
        {
            get;
            set;
        }

        [JsonProperty("grade")]
        public Nullable<Int32> Grade
        {
            get;
            set;
        }

        [JsonProperty("conte")]
        public String Conte
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public Nullable<Int32> Sort
        {
            get;
            set;
        }

        [JsonProperty("is_fit_service")]
        public Nullable<Int32> IsFitService
        {
            get;
            set;
        }

    }

}
