﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareSkuStockUpdateRequest : JdRequestBase<WareSkuStockUpdateResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public String OuterId
        {
            get;
            set;
        }

        public String Quantity
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sku.stock.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("outer_id" ,this.OuterId);
            paramters.Add("quantity" ,this.Quantity);
            paramters.Add("trade_no" ,this.TradeNo);
        }

    }

}
