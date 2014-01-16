﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsEpartnerOrdersignQueryRequest : JdRequestBase<EtmsEpartnerOrdersignQueryResponse>
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

        public String SignPeople
        {
            get;
            set;
        }

        public String SignDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.epartner.ordersign.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("validateStr" ,this.ValidateStr);
            paramters.Add("partnerAliases" ,this.PartnerAliases);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("orderCode" ,this.OrderCode);
            paramters.Add("signPeople" ,this.SignPeople);
            paramters.Add("signDate" ,this.SignDate);
        }

    }

}
