﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOrderAddRequest : JdRequestBase<LogisticsOrderAddResponse>
    {
        public String ChannelsSellerNo
        {
            get;
            set;
        }

        public String ChannelsOutboundNo
        {
            get;
            set;
        }

        public String WarehouseNo
        {
            get;
            set;
        }

        public String CarriersId
        {
            get;
            set;
        }

        public String ExpectDate
        {
            get;
            set;
        }

        public String OrderNo
        {
            get;
            set;
        }

        public String ShopNo
        {
            get;
            set;
        }

        public String ConsigneeName
        {
            get;
            set;
        }

        public String AddressProvince
        {
            get;
            set;
        }

        public String AddressCity
        {
            get;
            set;
        }

        public String AddressCounty
        {
            get;
            set;
        }

        public String AddressTown
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String ZipCode
        {
            get;
            set;
        }

        public String Phone
        {
            get;
            set;
        }

        public String Mobile
        {
            get;
            set;
        }

        public Single Receivable
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public String BuyerRemark
        {
            get;
            set;
        }

        public String VerifyRemark
        {
            get;
            set;
        }

        public String ReturnConsigneeAddress
        {
            get;
            set;
        }

        public String ReturnConsigneeName
        {
            get;
            set;
        }

        public String ReturnConsigneePhone
        {
            get;
            set;
        }

        public String StationNo
        {
            get;
            set;
        }

        public String StationName
        {
            get;
            set;
        }

        public String OrderMark
        {
            get;
            set;
        }

        public String ShopOrderSource
        {
            get;
            set;
        }

        public Nullable<DateTime> ShopOrderCreateTime
        {
            get;
            set;
        }

        public String Picker
        {
            get;
            set;
        }

        public String PickerCall
        {
            get;
            set;
        }

        public String PikerId
        {
            get;
            set;
        }

        public String PackType
        {
            get;
            set;
        }

        public String GoodsNo
        {
            get;
            set;
        }

        public String SkuId
        {
            get;
            set;
        }

        public String ShopGoodsNo
        {
            get;
            set;
        }

        public String Qty
        {
            get;
            set;
        }

        public String GoodsStatus
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.order.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("channels_seller_no" ,this.ChannelsSellerNo);
            paramters.Add("channels_outbound_no" ,this.ChannelsOutboundNo);
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("carriers_id" ,this.CarriersId);
            paramters.Add("expect_date" ,this.ExpectDate);
            paramters.Add("order_no" ,this.OrderNo);
            paramters.Add("shop_no" ,this.ShopNo);
            paramters.Add("consignee_name" ,this.ConsigneeName);
            paramters.Add("address_province" ,this.AddressProvince);
            paramters.Add("address_city" ,this.AddressCity);
            paramters.Add("address_county" ,this.AddressCounty);
            paramters.Add("address_town" ,this.AddressTown);
            paramters.Add("address" ,this.Address);
            paramters.Add("zip_code" ,this.ZipCode);
            paramters.Add("phone" ,this.Phone);
            paramters.Add("mobile" ,this.Mobile);
            paramters.Add("receivable" ,this.Receivable);
            paramters.Add("email" ,this.Email);
            paramters.Add("buyer_remark" ,this.BuyerRemark);
            paramters.Add("verify_remark" ,this.VerifyRemark);
            paramters.Add("return_consignee_address" ,this.ReturnConsigneeAddress);
            paramters.Add("return_consignee_name" ,this.ReturnConsigneeName);
            paramters.Add("return_consignee_phone" ,this.ReturnConsigneePhone);
            paramters.Add("station_no" ,this.StationNo);
            paramters.Add("station_name" ,this.StationName);
            paramters.Add("order_mark" ,this.OrderMark);
            paramters.Add("shop_order_source" ,this.ShopOrderSource);
            paramters.Add("shop_order_create_time" ,this.ShopOrderCreateTime);
            paramters.Add("picker" ,this.Picker);
            paramters.Add("picker_call" ,this.PickerCall);
            paramters.Add("piker_id" ,this.PikerId);
            paramters.Add("pack_type" ,this.PackType);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("shopGoodsNo" ,this.ShopGoodsNo);
            paramters.Add("qty" ,this.Qty);
            paramters.Add("goods_status" ,this.GoodsStatus);
        }

    }

}
