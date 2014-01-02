﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class OtherInstoreOrderDetail : JdObject
    {
        [JsonProperty("goods_no")]
        public String GoodsNo
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

    }

}
