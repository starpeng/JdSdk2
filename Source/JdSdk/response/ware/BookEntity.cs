﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class BookEntity : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("book_info")]
        public BookInfo BookInfo
        {
            get;
            set;
        }

    }

}
