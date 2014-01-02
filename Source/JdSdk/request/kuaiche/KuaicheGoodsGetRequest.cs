﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheGoodsGetRequest : JdRequestBase<KuaicheGoodsGetResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.goods.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
        }

    }

}
