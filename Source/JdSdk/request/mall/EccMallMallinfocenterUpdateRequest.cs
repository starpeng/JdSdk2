﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mall;

namespace JdSdk.Request.Mall
{
﻿    public class EccMallMallinfocenterUpdateRequest : JdRequestBase<EccMallMallinfocenterUpdateResponse>
    {
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public String Logo
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
            get{ return "jingdong.ecc.mall.mallinfocenter.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("title" ,this.Title);
            paramters.Add("logo" ,this.Logo);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
