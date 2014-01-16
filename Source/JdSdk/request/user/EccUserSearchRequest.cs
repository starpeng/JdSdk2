﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.User;

namespace JdSdk.Request.User
{
﻿    public class EccUserSearchRequest : JdRequestBase<EccUserSearchResponse>
    {
        public String Ip
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.user.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ip" ,this.Ip);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("page_index" ,this.PageIndex);
        }

    }

}
