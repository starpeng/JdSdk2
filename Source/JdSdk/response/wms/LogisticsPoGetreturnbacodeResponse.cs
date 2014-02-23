﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsPoGetreturnbacodeResponse : JdResponse
    {
        [JsonProperty("inboundNo")]
        public String InboundNo
        {
            get;
            set;
        }

        [JsonProperty("poNo")]
        public String PoNo
        {
            get;
            set;
        }

        [JsonProperty("receivingStatus")]
        public String ReceivingStatus
        {
            get;
            set;
        }

        [JsonProperty("task_details")]
        public List<ReceivingTask> TaskDetails
        {
            get;
            set;
        }

    }

}
