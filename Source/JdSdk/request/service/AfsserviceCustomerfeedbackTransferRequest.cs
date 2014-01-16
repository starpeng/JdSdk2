﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceCustomerfeedbackTransferRequest : JdRequestBase<AfsserviceCustomerfeedbackTransferResponse>
    {
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public String Reason
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.customerfeedback.transfer"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("reason" ,this.Reason);
        }

    }

}
