﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class PopAfsRefundapplyQuerylistRequest : JdRequestBase<PopAfsRefundapplyQuerylistResponse>
    {
        public String Status
        {
            get;
            set;
        }

        public String Id
        {
            get;
            set;
        }

        public String OrderId
        {
            get;
            set;
        }

        public String BuyerId
        {
            get;
            set;
        }

        public String BuyerName
        {
            get;
            set;
        }

        public String ApplyTimeStart
        {
            get;
            set;
        }

        public String ApplyTimeEnd
        {
            get;
            set;
        }

        public String CheckTimeStart
        {
            get;
            set;
        }

        public String CheckTimeEnd
        {
            get;
            set;
        }

        public Nullable<Int32> PageIndex
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
            get{ return "jingdong.pop.afs.refundapply.querylist"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("status" ,this.Status);
            paramters.Add("id" ,this.Id);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("buyer_id" ,this.BuyerId);
            paramters.Add("buyer_name" ,this.BuyerName);
            paramters.Add("apply_time_start" ,this.ApplyTimeStart);
            paramters.Add("apply_time_end" ,this.ApplyTimeEnd);
            paramters.Add("check_time_start" ,this.CheckTimeStart);
            paramters.Add("check_time_end" ,this.CheckTimeEnd);
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
