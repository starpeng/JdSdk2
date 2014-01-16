﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class PublicResultListAfsServiceHistory : JdObject
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

        [JsonProperty("afsServiceHistoryList")]
        public List<AfsServiceHistory> AfsServiceHistoryList
        {
            get;
            set;
        }

    }

}
