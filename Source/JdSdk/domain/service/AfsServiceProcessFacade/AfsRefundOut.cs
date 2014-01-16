﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class AfsRefundOut : JdObject
    {
        [JsonProperty("afsRefundId")]
        public Nullable<Int32> AfsRefundId
        {
            get;
            set;
        }

        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("suggestAmount")]
        public Nullable<Decimal> SuggestAmount
        {
            get;
            set;
        }

        [JsonProperty("mark")]
        public String Mark
        {
            get;
            set;
        }

        [JsonProperty("reason")]
        public String Reason
        {
            get;
            set;
        }

        [JsonProperty("payInfo")]
        public String PayInfo
        {
            get;
            set;
        }

    }

}
