﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsPrerefundRequest : JdRequestBase<DropshipDpsPrerefundResponse>
    {
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        public String ApprovalSuggestion
        {
            get;
            set;
        }

        public String ApprovalState
        {
            get;
            set;
        }

        public Nullable<Int64> Id
        {
            get;
            set;
        }

        public Nullable<Int32> OperatorState
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.prerefund"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("customOrderId" ,this.CustomOrderId);
            paramters.Add("approvalSuggestion" ,this.ApprovalSuggestion);
            paramters.Add("approvalState" ,this.ApprovalState);
            paramters.Add("id" ,this.Id);
            paramters.Add("operatorState" ,this.OperatorState);
        }

    }

}
