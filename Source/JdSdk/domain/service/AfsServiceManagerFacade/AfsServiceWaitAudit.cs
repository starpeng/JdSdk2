﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceManagerFacade
{
﻿    [Serializable]
    public class AfsServiceWaitAudit : JdObject
    {
        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("afsApplyTime")]
        public Nullable<DateTime> AfsApplyTime
        {
            get;
            set;
        }

    }

}
