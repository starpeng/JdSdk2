﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsWaybillcodeGetRequest : JdRequestBase<EtmsWaybillcodeGetResponse>
    {
        public String PreNum
        {
            get;
            set;
        }

        public String CustomerCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.waybillcode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("preNum" ,this.PreNum);
            paramters.Add("customerCode" ,this.CustomerCode);
        }

    }

}
