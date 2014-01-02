﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareSkuAddRequest : JdRequestBase<WareSkuAddResponse>
    {
        public String WareId
        {
            get;
            set;
        }

        public String Attributes
        {
            get;
            set;
        }

        public String JdPrice
        {
            get;
            set;
        }

        public String StockNum
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public String OuterId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.sku.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("attributes" ,this.Attributes);
            paramters.Add("jd_price" ,this.JdPrice);
            paramters.Add("stock_num" ,this.StockNum);
            paramters.Add("trade_no" ,this.TradeNo);
            paramters.Add("outer_id" ,this.OuterId);
        }

    }

}
