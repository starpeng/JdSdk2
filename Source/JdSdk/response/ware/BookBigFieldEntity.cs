﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class BookBigFieldEntity : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("first_class_id")]
        public Nullable<Int32> FirstClassId
        {
            get;
            set;
        }

        [JsonProperty("book_big_field_info")]
        public BookBigFieldInfo BookBigFieldInfo
        {
            get;
            set;
        }

    }

}
