﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Zhijian.QTArticleService
{
﻿    [Serializable]
    public class QTArticle : JdObject
    {
        [JsonProperty("service_item_code")]
        public String ServiceItemCode
        {
            get;
            set;
        }

        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        [JsonProperty("all_num")]
        public Nullable<Int32> AllNum
        {
            get;
            set;
        }

        [JsonProperty("used_num")]
        public Nullable<Int32> UsedNum
        {
            get;
            set;
        }

        [JsonProperty("expire_time")]
        public Nullable<DateTime> ExpireTime
        {
            get;
            set;
        }

    }

}
