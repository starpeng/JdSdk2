﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WarePromotionCategorywareListGetRequest : JdRequestBase<WarePromotionCategorywareListGetResponse>
    {
        public Nullable<Int32> Cid
        {
            get;
            set;
        }

        public Nullable<Int32> Num
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
            get{ return "jingdong.ware.promotion.categoryware.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("num" ,this.Num);
            paramters.Add("client" ,this.Client);
        }

    }

}
