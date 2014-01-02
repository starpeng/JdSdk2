﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsPoAddRequest : JdRequestBase<LogisticsPoAddResponse>
    {
        public String ChannelsSellerNo
        {
            get;
            set;
        }

        public String PoNo
        {
            get;
            set;
        }

        public String WarehouseNo
        {
            get;
            set;
        }

        public String ExpectDate
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

        public String GoodsNo
        {
            get;
            set;
        }

        public String ExpectedQty
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
            get{ return "jingdong.logistics.po.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("channels_seller_no" ,this.ChannelsSellerNo);
            paramters.Add("po_no" ,this.PoNo);
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("expect_date" ,this.ExpectDate);
            paramters.Add("supplier_name" ,this.SupplierName);
            paramters.Add("supplier_no" ,this.SupplierNo);
            paramters.Add("approver" ,this.Approver);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("expected_qty" ,this.ExpectedQty);
            paramters.Add("goods_status" ,this.GoodsStatus);
        }

    }

}
