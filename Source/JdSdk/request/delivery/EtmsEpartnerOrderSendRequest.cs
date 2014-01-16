﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsEpartnerOrderSendRequest : JdRequestBase<EtmsEpartnerOrderSendResponse>
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

        public String SendPeople
        {
            get;
            set;
        }

        public String SendPhone
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.epartner.order.send"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("validateStr" ,this.ValidateStr);
            paramters.Add("partnerAliases" ,this.PartnerAliases);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("orderCode" ,this.OrderCode);
            paramters.Add("sendPeople" ,this.SendPeople);
            paramters.Add("sendPhone" ,this.SendPhone);
        }

    }

}
