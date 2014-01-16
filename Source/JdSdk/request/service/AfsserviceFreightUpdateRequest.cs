﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceFreightUpdateRequest : JdRequestBase<AfsserviceFreightUpdateResponse>
    {
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public String ExpressCode
        {
            get;
            set;
        }

        public String ExpressCompany
        {
            get;
            set;
        }

        public Nullable<Decimal> ModifiedMoney
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.freight.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("expressCode" ,this.ExpressCode);
            paramters.Add("expressCompany" ,this.ExpressCompany);
            paramters.Add("modifiedMoney" ,this.ModifiedMoney);
        }

    }

}
