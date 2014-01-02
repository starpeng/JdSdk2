﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WarePromotionsCatelogyidlistGetRequest : JdRequestBase<WarePromotionsCatelogyidlistGetResponse>
    {
        public Nullable<Int32> Level
        {
            get;
            set;
        }

        public Nullable<Int32> CatelogyId
        {
            get;
            set;
        }

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.promotions.catelogyidlist.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("level" ,this.Level);
            paramters.Add("catelogyId" ,this.CatelogyId);
            paramters.Add("client" ,this.Client);
        }

    }

}
