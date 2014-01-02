﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionAdvdetailGetRequest : JdRequestBase<UnionAdvdetailGetResponse>
    {
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        public Nullable<Int32> GoodsPageSize
        {
            get;
            set;
        }

        public Nullable<Int32> GoodsPageIndex
        {
            get;
            set;
        }

        public String GoodsSortColumn
        {
            get;
            set;
        }

        public String GoodsSort
        {
            get;
            set;
        }

        public Nullable<Int32> ActivityPageSize
        {
            get;
            set;
        }

        public Nullable<Int32> ActivityPageIndex
        {
            get;
            set;
        }

        public String ActivitySortColumn
        {
            get;
            set;
        }

        public String ActivitySort
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.advdetail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_id" ,this.PlanId);
            paramters.Add("goods_page_size" ,this.GoodsPageSize);
            paramters.Add("goods_page_index" ,this.GoodsPageIndex);
            paramters.Add("goods_sort_column" ,this.GoodsSortColumn);
            paramters.Add("goods_sort" ,this.GoodsSort);
            paramters.Add("activity_page_size" ,this.ActivityPageSize);
            paramters.Add("activity_page_index" ,this.ActivityPageIndex);
            paramters.Add("activity_sort_column" ,this.ActivitySortColumn);
            paramters.Add("activity_sort" ,this.ActivitySort);
        }

    }

}
