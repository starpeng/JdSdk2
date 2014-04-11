﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class VcReturnOrderListPageGetRequest : JdRequestBase<VcReturnOrderListPageGetResponse>
    {
        public Nullable<Int64> ReturnId
        {
            get;
            set;
        }

        public Nullable<Int32> FromDeliverCenterId
        {
            get;
            set;
        }

        public String ReturnStates
        {
            get;
            set;
        }

        public Nullable<DateTime> CreateDateBegin
        {
            get;
            set;
        }

        public Nullable<DateTime> CreateDateEnd
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.vc.return.order.list.page.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("returnId" ,this.ReturnId);
            paramters.Add("fromDeliverCenterId" ,this.FromDeliverCenterId);
            paramters.Add("returnStates" ,this.ReturnStates);
            paramters.Add("createDateBegin" ,this.CreateDateBegin);
            paramters.Add("createDateEnd" ,this.CreateDateEnd);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("pageIndex" ,this.PageIndex);
        }

    }

}
