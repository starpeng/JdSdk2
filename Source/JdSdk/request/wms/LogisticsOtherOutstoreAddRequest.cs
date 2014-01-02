﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOtherOutstoreAddRequest : JdRequestBase<LogisticsOtherOutstoreAddResponse>
    {
        public String OutboundNo
        {
            get;
            set;
        }

        public String JoslWareNo
        {
            get;
            set;
        }

        public String JoslCarriersNo
        {
            get;
            set;
        }

        public Nullable<DateTime> ExpectDate
        {
            get;
            set;
        }

        public String SupplierName
        {
            get;
            set;
        }

        public String SupplierNo
        {
            get;
            set;
        }

        public String Approver
        {
            get;
            set;
        }

        public String OutboundType
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }

        public String ConsigneeName
        {
            get;
            set;
        }

        public String Address
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

        public Single Receivable
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

        public String ReturnConsigneeName
        {
            get;
            set;
        }

        public String ReturnConsigneeAddress
        {
            get;
            set;
        }

        public String ReturnConsigneeMobile
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

        public String Picker
        {
            get;
            set;
        }

        public String PickerCell
        {
            get;
            set;
        }

        public String PikerId
        {
            get;
            set;
        }

        public String TransportWay
        {
            get;
            set;
        }

        public String OrderMark
        {
            get;
            set;
        }

        public String JoslGoodNo
        {
            get;
            set;
        }

        public String IsvGoodNo
        {
            get;
            set;
        }

        public String OutQty
        {
            get;
            set;
        }

        public String GoodStatus
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.otherOutstore.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("outbound_no" ,this.OutboundNo);
            paramters.Add("josl_ware_no" ,this.JoslWareNo);
            paramters.Add("josl_carriers_no" ,this.JoslCarriersNo);
            paramters.Add("expect_date" ,this.ExpectDate);
            paramters.Add("supplier_name" ,this.SupplierName);
            paramters.Add("supplier_no" ,this.SupplierNo);
            paramters.Add("approver" ,this.Approver);
            paramters.Add("outbound_type" ,this.OutboundType);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("consignee_name" ,this.ConsigneeName);
            paramters.Add("address" ,this.Address);
            paramters.Add("station_no" ,this.StationNo);
            paramters.Add("station_name" ,this.StationName);
            paramters.Add("receivable" ,this.Receivable);
            paramters.Add("zip_code" ,this.ZipCode);
            paramters.Add("phone" ,this.Phone);
            paramters.Add("mobile" ,this.Mobile);
            paramters.Add("email" ,this.Email);
            paramters.Add("buyer_remark" ,this.BuyerRemark);
            paramters.Add("verify_remark" ,this.VerifyRemark);
            paramters.Add("return_consignee_name" ,this.ReturnConsigneeName);
            paramters.Add("return_consignee_address" ,this.ReturnConsigneeAddress);
            paramters.Add("return_consignee_mobile" ,this.ReturnConsigneeMobile);
            paramters.Add("address_province" ,this.AddressProvince);
            paramters.Add("address_city" ,this.AddressCity);
            paramters.Add("address_county" ,this.AddressCounty);
            paramters.Add("address_town" ,this.AddressTown);
            paramters.Add("picker" ,this.Picker);
            paramters.Add("picker_cell" ,this.PickerCell);
            paramters.Add("piker_id" ,this.PikerId);
            paramters.Add("transport_way" ,this.TransportWay);
            paramters.Add("order_mark" ,this.OrderMark);
            paramters.Add("josl_good_no" ,this.JoslGoodNo);
            paramters.Add("isv_good_no" ,this.IsvGoodNo);
            paramters.Add("out_qty" ,this.OutQty);
            paramters.Add("good_status" ,this.GoodStatus);
        }

    }

}
