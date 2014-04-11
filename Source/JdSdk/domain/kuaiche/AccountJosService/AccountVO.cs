﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Kuaiche.AccountJosService
{
﻿    [Serializable]
    public class AccountVO : JdObject
    {
        [JsonProperty("total_amount")]
        public String TotalAmount
        {
            get;
            set;
        }

        [JsonProperty("available_amount")]
        public String AvailableAmount
        {
            get;
            set;
        }

        [JsonProperty("freeze_amount")]
        public String FreezeAmount
        {
            get;
            set;
        }

    }

}
