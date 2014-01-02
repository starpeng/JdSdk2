﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Evaluation
{
﻿    [Serializable]
    public class ProductCommentSummary : JdObject
    {
        [JsonProperty("commentCount")]
        public Nullable<Int32> CommentCount
        {
            get;
            set;
        }

        [JsonProperty("goodCount")]
        public Nullable<Int32> GoodCount
        {
            get;
            set;
        }

        [JsonProperty("generalCount")]
        public Nullable<Int32> GeneralCount
        {
            get;
            set;
        }

        [JsonProperty("poorCount")]
        public Nullable<Int32> PoorCount
        {
            get;
            set;
        }

        [JsonProperty("showCount")]
        public Nullable<Int32> ShowCount
        {
            get;
            set;
        }

    }

}
