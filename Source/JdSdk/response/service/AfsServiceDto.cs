﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceDto : JdObject
    {
        [JsonProperty("customer_order_id")]
        public String CustomerOrderId
        {
            get;
            set;
        }

        [JsonProperty("customer_station_no")]
        public String CustomerStationNo
        {
            get;
            set;
        }

        [JsonProperty("customer_order_apply_time")]
        public String CustomerOrderApplyTime
        {
            get;
            set;
        }

        [JsonProperty("customer_order_verify_time")]
        public String CustomerOrderVerifyTime
        {
            get;
            set;
        }

        [JsonProperty("customer_order_finish_time")]
        public String CustomerOrderFinishTime
        {
            get;
            set;
        }

        [JsonProperty("customer_order_state")]
        public String CustomerOrderState
        {
            get;
            set;
        }

        [JsonProperty("customer_order_type")]
        public String CustomerOrderType
        {
            get;
            set;
        }

        [JsonProperty("customer_order_cert")]
        public String CustomerOrderCert
        {
            get;
            set;
        }

        [JsonProperty("customer_order_problem")]
        public String CustomerOrderProblem
        {
            get;
            set;
        }

        [JsonProperty("customer_order_return_way")]
        public String CustomerOrderReturnWay
        {
            get;
            set;
        }

        [JsonProperty("customer_order_contactor")]
        public String CustomerOrderContactor
        {
            get;
            set;
        }

        [JsonProperty("customer_order_contactor_tel")]
        public String CustomerOrderContactorTel
        {
            get;
            set;
        }

        [JsonProperty("customer_order_verify_remark")]
        public String CustomerOrderVerifyRemark
        {
            get;
            set;
        }

        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        [JsonProperty("pay_type")]
        public String PayType
        {
            get;
            set;
        }

        [JsonProperty("cash_refund")]
        public String CashRefund
        {
            get;
            set;
        }

        [JsonProperty("pos_refund")]
        public String PosRefund
        {
            get;
            set;
        }

        [JsonProperty("pin_buyer")]
        public String PinBuyer
        {
            get;
            set;
        }

        [JsonProperty("customer_order_detail_list")]
        public List<AfsServiceDetailDto> CustomerOrderDetailList
        {
            get;
            set;
        }

        [JsonProperty("refund_list")]
        public List<AfsRefundDto> RefundList
        {
            get;
            set;
        }

    }

}
