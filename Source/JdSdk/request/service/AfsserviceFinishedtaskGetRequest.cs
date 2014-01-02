﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceFinishedtaskGetRequest : JdRequestBase<AfsserviceFinishedtaskGetResponse>
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

        public String CustomerPin
        {
            get;
            set;
        }

        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public Nullable<DateTime> AfsApplyTimeBegin
        {
            get;
            set;
        }

        public Nullable<DateTime> AfsApplyTimeEnd
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.finishedtask.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("pageNumber" ,this.PageNumber);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("customerPin" ,this.CustomerPin);
            paramters.Add("orderId" ,this.OrderId);
            paramters.Add("afsApplyTimeBegin" ,this.AfsApplyTimeBegin);
            paramters.Add("afsApplyTimeEnd" ,this.AfsApplyTimeEnd);
        }

    }

}
