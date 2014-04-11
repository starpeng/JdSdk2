﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class PoDetailPageGetRequest : JdRequestBase<PoDetailPageGetResponse>
    {
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public String SortFiled
        {
            get;
            set;
        }

        public String SortMode
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
            get{ return "jingdong.po.detail.page.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("orderId" ,this.OrderId);
            paramters.Add("sortFiled" ,this.SortFiled);
            paramters.Add("sortMode" ,this.SortMode);
            paramters.Add("pageIndex" ,this.PageIndex);
            paramters.Add("pageSize" ,this.PageSize);
        }

    }

}
