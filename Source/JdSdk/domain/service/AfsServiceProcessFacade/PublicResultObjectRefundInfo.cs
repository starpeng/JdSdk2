﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class PublicResultObjectRefundInfo : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("resultErrorMsg")]
        public String ResultErrorMsg
        {
            get;
            set;
        }

        [JsonProperty("afsRefundInfoOut")]
        public AfsRefundInfoOut AfsRefundInfoOut
        {
            get;
            set;
        }

    }

}