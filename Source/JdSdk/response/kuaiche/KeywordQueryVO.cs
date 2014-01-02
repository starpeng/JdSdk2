﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KeywordQueryVO : JdObject
    {
        [JsonProperty("third_categoryid")]
        public Nullable<Int64> ThirdCategoryid
        {
            get;
            set;
        }

        [JsonProperty("sort_field")]
        public String SortField
        {
            get;
            set;
        }

        [JsonProperty("sort_type")]
        public Nullable<Int32> SortType
        {
            get;
            set;
        }

        [JsonProperty("total_number")]
        public Nullable<Int32> TotalNumber
        {
            get;
            set;
        }

        [JsonProperty("page_size")]
        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        [JsonProperty("page_index")]
        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        [JsonProperty("keyword_data")]
        public List<KeywordGroup> KeywordData
        {
            get;
            set;
        }

    }

}
