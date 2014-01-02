﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class BookBigFieldInfo : JdObject
    {
        [JsonProperty("comments")]
        public String Comments
        {
            get;
            set;
        }

        [JsonProperty("image")]
        public String Image
        {
            get;
            set;
        }

        [JsonProperty("content_desc")]
        public String ContentDesc
        {
            get;
            set;
        }

        [JsonProperty("relatedProducts")]
        public String RelatedProducts
        {
            get;
            set;
        }

        [JsonProperty("editer_desc")]
        public String EditerDesc
        {
            get;
            set;
        }

        [JsonProperty("catalogue")]
        public String Catalogue
        {
            get;
            set;
        }

        [JsonProperty("book_abstract")]
        public String BookAbstract
        {
            get;
            set;
        }

        [JsonProperty("authorDesc")]
        public String AuthorDesc
        {
            get;
            set;
        }

        [JsonProperty("introduction")]
        public String Introduction
        {
            get;
            set;
        }

    }

}
