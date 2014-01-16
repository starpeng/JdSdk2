﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Im;

namespace JdSdk.Request.Im
{
﻿    public class ImPopChatlogGetRequest : JdRequestBase<ImPopChatlogGetResponse>
    {
        public String Waiter
        {
            get;
            set;
        }

        public String Customer
        {
            get;
            set;
        }

        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        public Nullable<DateTime> StartTime
        {
            get;
            set;
        }

        public Nullable<DateTime> EndTime
        {
            get;
            set;
        }

        public Nullable<Int32> Page
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
            get{ return "jingdong.im.pop.chatlog.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waiter" ,this.Waiter);
            paramters.Add("customer" ,this.Customer);
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("startTime" ,this.StartTime);
            paramters.Add("endTime" ,this.EndTime);
            paramters.Add("page" ,this.Page);
            paramters.Add("pageSize" ,this.PageSize);
        }

    }

}
