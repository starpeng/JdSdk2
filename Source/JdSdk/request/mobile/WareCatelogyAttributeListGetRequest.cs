﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareCatelogyAttributeListGetRequest : JdRequestBase<WareCatelogyAttributeListGetResponse>
    {
        public Nullable<Int32> NewVersion
        {
            get;
            set;
        }

        public String CatelogyId
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
            get{ return "jingdong.ware.catelogy.attribute.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("newVersion" ,this.NewVersion);
            paramters.Add("catelogyId" ,this.CatelogyId);
            paramters.Add("client" ,this.Client);
        }

    }

}
