﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class ResponseOrderOtherDetail : JdObject
    {
        [JsonProperty("josl_good_no")]
        public String JoslGoodNo
        {
            get;
            set;
        }

        [JsonProperty("isv_good_no")]
        public String IsvGoodNo
        {
            get;
            set;
        }

        [JsonProperty("qty")]
        public Nullable<Int32> Qty
        {
            get;
            set;
        }

        [JsonProperty("goods_status")]
        public String GoodsStatus
        {
            get;
            set;
        }

        [JsonProperty("difference_remark")]
        public String DifferenceRemark
        {
            get;
            set;
        }

    }

}
