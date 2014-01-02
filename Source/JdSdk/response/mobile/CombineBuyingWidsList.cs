﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CombineBuyingWidsList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("combineWareId")]
        public String CombineWareId
        {
            get;
            set;
        }

        [JsonProperty("showClick")]
        public String ShowClick
        {
            get;
            set;
        }

        [JsonProperty("combineBuyingWids")]
        public List<CmsActivityWare> CombineBuyingWids
        {
            get;
            set;
        }

    }

}
