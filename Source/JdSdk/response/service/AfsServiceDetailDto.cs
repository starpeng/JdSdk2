﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceDetailDto : JdObject
    {
        [JsonProperty("customer_order_sku_id_pop")]
        public String CustomerOrderSkuIdPop
        {
            get;
            set;
        }

        [JsonProperty("customer_order_sku_id_outer")]
        public String CustomerOrderSkuIdOuter
        {
            get;
            set;
        }

        [JsonProperty("customer_order_sku_name")]
        public String CustomerOrderSkuName
        {
            get;
            set;
        }

        [JsonProperty("customer_order_apply_num")]
        public Nullable<Int32> CustomerOrderApplyNum
        {
            get;
            set;
        }

        [JsonProperty("customer_order_verify_num")]
        public Nullable<Int32> CustomerOrderVerifyNum
        {
            get;
            set;
        }

        [JsonProperty("customer_order_finish_remark")]
        public String CustomerOrderFinishRemark
        {
            get;
            set;
        }

    }

}
