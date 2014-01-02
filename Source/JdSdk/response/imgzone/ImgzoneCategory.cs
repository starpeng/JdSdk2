﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzoneCategory : JdObject
    {
        [JsonProperty("cate_id")]
        public Nullable<Int32> CateId
        {
            get;
            set;
        }

        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        [JsonProperty("cate_level")]
        public Nullable<Int32> CateLevel
        {
            get;
            set;
        }

        [JsonProperty("parent_cate_id")]
        public Nullable<Int32> ParentCateId
        {
            get;
            set;
        }

        [JsonProperty("cate_order")]
        public Nullable<Int32> CateOrder
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }

}
