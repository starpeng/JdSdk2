﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Zhijian.QTArticleService
{
﻿    [Serializable]
    public class QtArticleResult : JdObject
    {
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        [JsonProperty("r_code")]
        public String RCode
        {
            get;
            set;
        }

        [JsonProperty("r_msg")]
        public String RMsg
        {
            get;
            set;
        }

        [JsonProperty("qtArticle")]
        public QTArticle QtArticle
        {
            get;
            set;
        }

    }

}
