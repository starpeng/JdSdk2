﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceConfFacade
{
﻿    [Serializable]
    public class PublicResultObjectAfsCategory : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("afsCategoryList")]
        public List<AfsCategoryOut> AfsCategoryList
        {
            get;
            set;
        }

    }

}
