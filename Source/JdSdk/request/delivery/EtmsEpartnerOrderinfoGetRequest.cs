﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsEpartnerOrderinfoGetRequest : JdRequestBase<EtmsEpartnerOrderinfoGetResponse>
    {
        public String ValidateStr
        {
            get;
            set;
        }

        public String PartnerAliases
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }

        public String OrderCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.epartner.orderinfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("validateStr" ,this.ValidateStr);
            paramters.Add("partnerAliases" ,this.PartnerAliases);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("orderCode" ,this.OrderCode);
        }

    }

}
