﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Kuaiche.AccountJosService
{
﻿    [Serializable]
    public class PageInfo : JdObject
    {
        [JsonProperty("page_index")]
        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        [JsonProperty("page_total")]
        public Nullable<Int64> PageTotal
        {
            get;
            set;
        }

        [JsonProperty("page_size")]
        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        [JsonProperty("datas")]
        public List<IncomeExpenseVO> Datas
        {
            get;
            set;
        }

    }

}
