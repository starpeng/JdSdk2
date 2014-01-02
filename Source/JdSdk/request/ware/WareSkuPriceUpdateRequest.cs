﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareSkuPriceUpdateRequest : JdRequestBase<WareSkuPriceUpdateResponse>
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

        public String Price
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public String MarketPrice
        {
            get;
            set;
        }

        public String JdPrice
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sku.price.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("outer_id" ,this.OuterId);
            paramters.Add("price" ,this.Price);
            paramters.Add("trade_no" ,this.TradeNo);
            paramters.Add("market_price" ,this.MarketPrice);
            paramters.Add("jd_price" ,this.JdPrice);
        }

    }

}
