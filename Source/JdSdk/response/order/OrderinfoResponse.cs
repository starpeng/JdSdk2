﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderinfoResponse : JdObject
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
        public Nullable<Byte> PayType
        {
            get;
            set;
        }

        [JsonProperty("order_total_price")]
        public Nullable<Double> OrderTotalPrice
        {
            get;
            set;
        }

        [JsonProperty("order_payment")]
        public Nullable<Double> OrderPayment
        {
            get;
            set;
        }

        [JsonProperty("order_seller_price")]
        public Nullable<Double> OrderSellerPrice
        {
            get;
            set;
        }

        [JsonProperty("freight_price")]
        public Nullable<Double> FreightPrice
        {
            get;
            set;
        }

        [JsonProperty("seller_discount")]
        public Nullable<Double> SellerDiscount
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

        [JsonProperty("delivery_type")]
        public Nullable<Byte> DeliveryType
        {
            get;
            set;
        }

        [JsonProperty("order_type")]
        public Nullable<Byte> OrderType
        {
            get;
            set;
        }

        [JsonProperty("invoice_state")]
        public String InvoiceState
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
        public Nullable<DateTime> OrderStartTime
        {
            get;
            set;
        }

        [JsonProperty("order_end_time")]
        public Nullable<DateTime> OrderEndTime
        {
            get;
            set;
        }

        [JsonProperty("full_name")]
        public String FullName
        {
            get;
            set;
        }

        [JsonProperty("full_address")]
        public String FullAddress
        {
            get;
            set;
        }

        [JsonProperty("telephone")]
        public String Telephone
        {
            get;
            set;
        }

        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        [JsonProperty("province")]
        public Nullable<Int32> Province
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public Nullable<Int32> City
        {
            get;
            set;
        }

        [JsonProperty("county")]
        public Nullable<Int32> County
        {
            get;
            set;
        }

        [JsonProperty("town")]
        public Nullable<Int32> Town
        {
            get;
            set;
        }

        [JsonProperty("province_name")]
        public String ProvinceName
        {
            get;
            set;
        }

        [JsonProperty("city_name")]
        public String CityName
        {
            get;
            set;
        }

        [JsonProperty("county_name")]
        public String CountyName
        {
            get;
            set;
        }

        [JsonProperty("town_name")]
        public String TownName
        {
            get;
            set;
        }

        [JsonProperty("item_info_list")]
        public List<OrderinfoProductResponse> ItemInfoList
        {
            get;
            set;
        }

        [JsonProperty("coupon_detail_list")]
        public List<OrderinfoProductDiscountResponse> CouponDetailList
        {
            get;
            set;
        }

        [JsonProperty("order_state_list")]
        public List<OrderinfoStatusFlowResponse> OrderStateList
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

        [JsonProperty("vender_remark")]
        public String VenderRemark
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

        [JsonProperty("station_order_state")]
        public Nullable<Byte> StationOrderState
        {
            get;
            set;
        }

        [JsonProperty("station_order_update_time")]
        public Nullable<DateTime> StationOrderUpdateTime
        {
            get;
            set;
        }

        [JsonProperty("station_no")]
        public String StationNo
        {
            get;
            set;
        }

        [JsonProperty("station_no_isv")]
        public String StationNoIsv
        {
            get;
            set;
        }

        [JsonProperty("station_name")]
        public String StationName
        {
            get;
            set;
        }

        [JsonProperty("station_order_type")]
        public Nullable<Byte> StationOrderType
        {
            get;
            set;
        }

        [JsonProperty("order_cancel_time")]
        public Nullable<DateTime> OrderCancelTime
        {
            get;
            set;
        }

        [JsonProperty("order_cancel_reason")]
        public Nullable<Byte> OrderCancelReason
        {
            get;
            set;
        }

        [JsonProperty("order_backward_remark")]
        public String OrderBackwardRemark
        {
            get;
            set;
        }

        [JsonProperty("station_payment_type")]
        public Nullable<Byte> StationPaymentType
        {
            get;
            set;
        }

        [JsonProperty("station_payment_cash")]
        public Nullable<Double> StationPaymentCash
        {
            get;
            set;
        }

        [JsonProperty("station_payment_pos")]
        public Nullable<Double> StationPaymentPos
        {
            get;
            set;
        }

        [JsonProperty("station_delivery_type")]
        public Nullable<Byte> StationDeliveryType
        {
            get;
            set;
        }

        [JsonProperty("carrier_no")]
        public String CarrierNo
        {
            get;
            set;
        }

        [JsonProperty("carrier_name")]
        public String CarrierName
        {
            get;
            set;
        }

        [JsonProperty("deliver_no")]
        public String DeliverNo
        {
            get;
            set;
        }

    }

}
