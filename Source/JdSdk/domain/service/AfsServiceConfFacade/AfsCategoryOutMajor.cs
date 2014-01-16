﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceConfFacade
{
﻿    [Serializable]
    public class AfsCategoryOutMajor : JdObject
    {
        [JsonProperty("afsCategoryId")]
        public Nullable<Int32> AfsCategoryId
        {
            get;
            set;
        }

        [JsonProperty("afsCategoryName")]
        public String AfsCategoryName
        {
            get;
            set;
        }

    }

}
