﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsStockSearchRequest : JdRequestBase<LogisticsStockSearchResponse>
    {
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

        public Nullable<Int32> CurrentPage
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.stock.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("current_page" ,this.CurrentPage);
        }

    }

}
