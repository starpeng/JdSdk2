﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class PoListPageGetRequest : JdRequestBase<PoListPageGetResponse>
    {
        public Nullable<Int32> DeliverCenterId
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public Nullable<DateTime> CreatedDateStart
        {
            get;
            set;
        }

        public Nullable<DateTime> CreatedDateEnd
        {
            get;
            set;
        }

        public Nullable<Boolean> IsEptCustomized
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

        public String OrderIds
        {
            get;
            set;
        }

        public String WareIds
        {
            get;
            set;
        }

        public String States
        {
            get;
            set;
        }

        public String ConfirmStates
        {
            get;
            set;
        }

        public String OrderAttributes
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.po.list.page.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("deliverCenterId" ,this.DeliverCenterId);
            paramters.Add("status" ,this.Status);
            paramters.Add("createdDateStart" ,this.CreatedDateStart);
            paramters.Add("createdDateEnd" ,this.CreatedDateEnd);
            paramters.Add("isEptCustomized" ,this.IsEptCustomized);
            paramters.Add("pageIndex" ,this.PageIndex);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("orderIds" ,this.OrderIds);
            paramters.Add("wareIds" ,this.WareIds);
            paramters.Add("states" ,this.States);
            paramters.Add("confirmStates" ,this.ConfirmStates);
            paramters.Add("orderAttributes" ,this.OrderAttributes);
        }

    }

}
