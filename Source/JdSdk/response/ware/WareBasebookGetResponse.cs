﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareBasebookGetResponse : JdResponse
    {
        [JsonProperty("BookEntity")]
        public List<BookEntity> BookEntity
        {
            get;
            set;
        }

    }

}
