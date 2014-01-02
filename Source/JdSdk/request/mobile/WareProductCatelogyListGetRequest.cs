﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareProductCatelogyListGetRequest : JdRequestBase<WareProductCatelogyListGetResponse>
    {
        public Nullable<Int32> CatelogyId
        {
            get;
            set;
        }

        public Nullable<Int32> Level
        {
            get;
            set;
        }

        public Nullable<Boolean> IsIcon
        {
            get;
            set;
        }

        public Nullable<Boolean> IsDescription
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
            get{ return "jingdong.ware.product.catelogy.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("catelogyId" ,this.CatelogyId);
            paramters.Add("level" ,this.Level);
            paramters.Add("isIcon" ,this.IsIcon);
            paramters.Add("isDescription" ,this.IsDescription);
            paramters.Add("client" ,this.Client);
        }

    }

}
