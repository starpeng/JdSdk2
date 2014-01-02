﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsOrderGetResponse : JdResponse
    {
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        [JsonProperty("order_status_details")]
        public List<OrderStatusDetail> OrderStatusDetails
        {
            get;
            set;
        }

        [JsonProperty("order_package_details")]
        public List<OrderPackageDetail> OrderPackageDetails
        {
            get;
            set;
        }

    }

}
