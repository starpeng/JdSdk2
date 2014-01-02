﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderPrintData : JdObject
    {
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        [JsonProperty("out_bound_date")]
        public String OutBoundDate
        {
            get;
            set;
        }

        [JsonProperty("bf_deli_good_glag")]
        public String BfDeliGoodGlag
        {
            get;
            set;
        }

        [JsonProperty("cod_time_name")]
        public String CodTimeName
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        [JsonProperty("cky2_name")]
        public String Cky2Name
        {
            get;
            set;
        }

        [JsonProperty("sorting_code")]
        public String SortingCode
        {
            get;
            set;
        }

        [JsonProperty("create_date")]
        public String CreateDate
        {
            get;
            set;
        }

        [JsonProperty("should_pay")]
        public String ShouldPay
        {
            get;
            set;
        }

        [JsonProperty("payment_typeStr")]
        public String PaymentTypeStr
        {
            get;
            set;
        }

        [JsonProperty("partner")]
        public String Partner
        {
            get;
            set;
        }

        [JsonProperty("generade")]
        public String Generade
        {
            get;
            set;
        }

        [JsonProperty("items_count")]
        public String ItemsCount
        {
            get;
            set;
        }

        [JsonProperty("freight")]
        public String Freight
        {
            get;
            set;
        }

        [JsonProperty("order_item")]
        public List<OrderPrintDataWare> WList
        {
            get;
            set;
        }

        [JsonProperty("Consignee")]
        public OrderPrintDataConsignee Csnee
        {
            get;
            set;
        }

    }

}
