﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.User;

namespace JdSdk.Request.User
{
﻿    public class DropshipDpsSearchSingleRequest : JdRequestBase<DropshipDpsSearchSingleResponse>
    {
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.searchSingle"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("customOrderId" ,this.CustomOrderId);
        }

    }

}
