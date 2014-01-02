﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceServicelogGetRequest : JdRequestBase<AfsserviceServicelogGetResponse>
    {
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public Nullable<Int32> PageNumber
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.servicelog.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("pageNumber" ,this.PageNumber);
            paramters.Add("pageSize" ,this.PageSize);
        }

    }

}
