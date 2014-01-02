﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareBookbigfieldGetResponse : JdResponse
    {
        [JsonProperty("BookBigFieldEntity")]
        public List<BookBigFieldEntity> BookBigFieldEntity
        {
            get;
            set;
        }

    }

}
