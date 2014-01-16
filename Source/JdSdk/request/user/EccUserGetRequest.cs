﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.User;

namespace JdSdk.Request.User
{
﻿    public class EccUserGetRequest : JdRequestBase<EccUserGetResponse>
    {
        public String UserName
        {
            get;
            set;
        }

        public String Ip
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.user.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("user_name" ,this.UserName);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
