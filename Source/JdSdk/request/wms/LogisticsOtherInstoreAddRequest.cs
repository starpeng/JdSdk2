﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOtherInstoreAddRequest : JdRequestBase<LogisticsOtherInstoreAddResponse>
    {
        public String InstoreType
        {
            get;
            set;
        }

        public String PoNo
        {
            get;
            set;
        }

        public String ExpectedDate
        {
            get;
            set;
        }

        public String Approver
        {
            get;
            set;
        }

        public String WarehouseNo
        {
            get;
            set;
        }

        public String GoodsNo
        {
            get;
            set;
        }

        public String IsvGoodsNo
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
            get{ return "jingdong.logistics.otherInstore.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("instore_type" ,this.InstoreType);
            paramters.Add("po_no" ,this.PoNo);
            paramters.Add("expected_date" ,this.ExpectedDate);
            paramters.Add("approver" ,this.Approver);
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("isv_goods_no" ,this.IsvGoodsNo);
            paramters.Add("expected_qty" ,this.ExpectedQty);
            paramters.Add("goods_status" ,this.GoodsStatus);
        }

    }

}
