﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.ReturnOrderJosAPI
{
﻿    [Serializable]
    public class RoResultDto : JdObject
    {
        [JsonProperty("pageIndex")]
        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        [JsonProperty("pageSize")]
        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        [JsonProperty("recordCount")]
        public Nullable<Int32> RecordCount
        {
            get;
            set;
        }

        [JsonProperty("roDtoList")]
        public List<RoDto> RoDtoList
        {
            get;
            set;
        }

    }

}
