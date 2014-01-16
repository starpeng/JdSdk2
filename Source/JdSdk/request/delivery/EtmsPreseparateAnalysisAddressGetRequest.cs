﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsPreseparateAnalysisAddressGetRequest : JdRequestBase<EtmsPreseparateAnalysisAddressGetResponse>
    {
        public String FullAddress
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.preseparate.analysis.address.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fullAddress" ,this.FullAddress);
        }

    }

}
