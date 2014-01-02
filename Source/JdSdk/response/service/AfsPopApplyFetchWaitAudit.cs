﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsPopApplyFetchWaitAudit : JdObject
    {
        [JsonProperty("afsApplyId")]
        public Nullable<Int32> AfsApplyId
        {
            get;
            set;
        }

        [JsonProperty("afsCategoryId")]
        public Nullable<Int32> AfsCategoryId
        {
            get;
            set;
        }

        [JsonProperty("wareId")]
        public Nullable<Int32> WareId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("payPrice")]
        public Nullable<Decimal> PayPrice
        {
            get;
            set;
        }

        [JsonProperty("popWaitAppStateStr")]
        public String PopWaitAppStateStr
        {
            get;
            set;
        }

        [JsonProperty("afsServiceList")]
        public List<AfsServiceWaitAudit> AfsServiceList
        {
            get;
            set;
        }

        [JsonProperty("afsApply")]
        public AfsApplyWaitAudit AfsApply
        {
            get;
            set;
        }

    }

}
