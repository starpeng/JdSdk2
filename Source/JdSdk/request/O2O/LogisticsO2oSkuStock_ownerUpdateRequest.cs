﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.O2O;

namespace JdSdk.Request.O2O
{
﻿    public class LogisticsO2oSkuStockOwnerUpdateRequest : JdRequestBase<LogisticsO2oSkuStockOwnerUpdateResponse>
    {
        public String Pin
        {
            get;
            set;
        }

        public Nullable<Int32> SpuId
        {
            get;
            set;
        }

        public String SkuId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String StockOwner
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.o2o.sku.stock_owner.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pin" ,this.Pin);
            paramters.Add("spu_id" ,this.SpuId);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("name" ,this.Name);
            paramters.Add("stock_owner" ,this.StockOwner);
        }

    }

}
