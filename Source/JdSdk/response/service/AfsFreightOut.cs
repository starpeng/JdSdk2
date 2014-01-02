﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsFreightOut : JdObject
    {
        [JsonProperty("afsFreightId")]
        public Nullable<Int32> AfsFreightId
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

        [JsonProperty("partReceiveId")]
        public Nullable<Int32> PartReceiveId
        {
            get;
            set;
        }

        [JsonProperty("freightCode")]
        public String FreightCode
        {
            get;
            set;
        }

        [JsonProperty("expressCode")]
        public String ExpressCode
        {
            get;
            set;
        }

        [JsonProperty("freightMoney")]
        public Nullable<Decimal> FreightMoney
        {
            get;
            set;
        }

        [JsonProperty("modifiedMoney")]
        public Nullable<Decimal> ModifiedMoney
        {
            get;
            set;
        }

        [JsonProperty("expressCompany")]
        public String ExpressCompany
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

    }

}
