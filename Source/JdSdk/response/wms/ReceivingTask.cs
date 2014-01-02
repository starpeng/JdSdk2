﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class ReceivingTask : JdObject
    {
        [JsonProperty("goods_no")]
        public String GoodsNo
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

        [JsonProperty("qty")]
        public Nullable<Int32> Qty
        {
            get;
            set;
        }

        [JsonProperty("expected_qty")]
        public Nullable<Int32> ExpectedQty
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
