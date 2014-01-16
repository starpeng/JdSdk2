﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class EffectReportSafVo : JdObject
    {
        [JsonProperty("report_unionId")]
        public Nullable<Int64> ReportUnionId
        {
            get;
            set;
        }

        [JsonProperty("report_orderNo")]
        public Nullable<Int64> ReportOrderNo
        {
            get;
            set;
        }

        [JsonProperty("report_commRatio")]
        public Nullable<Double> ReportCommRatio
        {
            get;
            set;
        }

        [JsonProperty("report_commision")]
        public Nullable<Double> ReportCommision
        {
            get;
            set;
        }

        [JsonProperty("report_sourceType")]
        public String ReportSourceType
        {
            get;
            set;
        }

        [JsonProperty("report_orderStatus")]
        public Nullable<Int32> ReportOrderStatus
        {
            get;
            set;
        }

        [JsonProperty("report_itemPrice")]
        public Nullable<Double> ReportItemPrice
        {
            get;
            set;
        }

        [JsonProperty("report_skuId")]
        public Nullable<Int64> ReportSkuId
        {
            get;
            set;
        }

        [JsonProperty("report_itemName")]
        public String ReportItemName
        {
            get;
            set;
        }

        [JsonProperty("report_itemNum")]
        public Nullable<Int32> ReportItemNum
        {
            get;
            set;
        }

        [JsonProperty("report_shopName")]
        public String ReportShopName
        {
            get;
            set;
        }

    }

}
