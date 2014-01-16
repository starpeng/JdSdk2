﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoStatusJosService
{
﻿    [Serializable]
    public class OrderBackStationDto : JdObject
    {
        [JsonProperty("validateStr")]
        public String ValidateStr
        {
            get;
            set;
        }

        [JsonProperty("partnerAliases")]
        public String PartnerAliases
        {
            get;
            set;
        }

        [JsonProperty("exceptionCode")]
        public Nullable<Int32> ExceptionCode
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        [JsonProperty("orderCode")]
        public String OrderCode
        {
            get;
            set;
        }

    }

}
