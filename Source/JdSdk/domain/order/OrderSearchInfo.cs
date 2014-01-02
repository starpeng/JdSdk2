﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderSearchInfo : JdObject
    {
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

        [JsonProperty("order_total_price")]
        public String OrderTotalPrice
        {
            get;
            set;
        }

        [JsonProperty("order_seller_price")]
        public String OrderSellerPrice
        {
            get;
            set;
        }

        [JsonProperty("order_payment")]
        public String OrderPayment
        {
            get;
            set;
        }

        [JsonProperty("freight_price")]
        public String FreightPrice
        {
            get;
            set;
        }

        [JsonProperty("seller_discount")]
        public String SellerDiscount
        {
            get;
            set;
        }

        [JsonProperty("order_state")]
        public String OrderState
        {
            get;
            set;
        }

        [JsonProperty("order_state_remark")]
        public String OrderStateRemark
        {
            get;
            set;
        }

        [JsonProperty("delivery_type")]
        public String DeliveryType
        {
            get;
            set;
        }

        [JsonProperty("invoice_info")]
        public String InvoiceInfo
        {
            get;
            set;
        }

        [JsonProperty("order_remark")]
        public String OrderRemark
        {
            get;
            set;
        }

        [JsonProperty("order_start_time")]
        public String OrderStartTime
        {
            get;
            set;
        }

        [JsonProperty("order_end_time")]
        public String OrderEndTime
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("consignee_info")]
        public UserInfo ConsigneeInfo
        {
            get;
            set;
        }

        [JsonProperty("item_info_list")]
        public List<ItemInfo> ItemInfoList
        {
            get;
            set;
        }

        [JsonProperty("coupon_detail_list")]
        public List<CouponDetail> CouponDetailList
        {
            get;
            set;
        }

        [JsonProperty("vender_remark")]
        public String VenderRemark
        {
            get;
            set;
        }

        [JsonProperty("balance_used")]
        public String BalanceUsed
        {
            get;
            set;
        }

        [JsonProperty("payment_confirm_time")]
        public String PaymentConfirmTime
        {
            get;
            set;
        }

        [JsonProperty("waybill")]
        public String Waybill
        {
            get;
            set;
        }

        [JsonProperty("logistics_id")]
        public String LogisticsId
        {
            get;
            set;
        }

        [JsonProperty("vat_invoice_info")]
        public VatInvoiceInfo VatInvoiceInfo
        {
            get;
            set;
        }

        [JsonProperty("parent_order_id")]
        public String ParentOrderId
        {
            get;
            set;
        }

        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        [JsonProperty("return_order")]
        public String ReturnOrder
        {
            get;
            set;
        }

    }

}
