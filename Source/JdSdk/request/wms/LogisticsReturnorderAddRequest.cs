﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsReturnorderAddRequest : JdRequestBase<LogisticsReturnorderAddResponse>
    {
        public String SellerNo
        {
            get;
            set;
        }

        public String WarehouseNo
        {
            get;
            set;
        }

        public String InboundNo
        {
            get;
            set;
        }

        public String JoslOutboundNo
        {
            get;
            set;
        }

        public Nullable<DateTime> ExpectedDate
        {
            get;
            set;
        }

        public String IsvSource
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

        public String StockMark
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.returnorder.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("seller_no" ,this.SellerNo);
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("inbound_no" ,this.InboundNo);
            paramters.Add("josl_outbound_no" ,this.JoslOutboundNo);
            paramters.Add("expected_date" ,this.ExpectedDate);
            paramters.Add("isv_source" ,this.IsvSource);
            paramters.Add("approver" ,this.Approver);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("expected_qty" ,this.ExpectedQty);
            paramters.Add("stock_mark" ,this.StockMark);
        }

    }

}
