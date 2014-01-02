﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceWaitprocesstaskGetRequest : JdRequestBase<AfsserviceWaitprocesstaskGetResponse>
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

        public Nullable<DateTime> ApprovedDateBegin
        {
            get;
            set;
        }

        public Nullable<DateTime> ApprovedDateEnd
        {
            get;
            set;
        }

        public String ExpressCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.waitprocesstask.get"; }
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
            paramters.Add("approvedDateBegin" ,this.ApprovedDateBegin);
            paramters.Add("approvedDateEnd" ,this.ApprovedDateEnd);
            paramters.Add("expressCode" ,this.ExpressCode);
        }

    }

}
