﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WarePromotionActivitiesListGetRequest : JdRequestBase<WarePromotionActivitiesListGetResponse>
    {
        public Nullable<Int32> PromotionsId
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

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.promotion.activities.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promotionsId" ,this.PromotionsId);
            paramters.Add("page" ,this.Page);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("client" ,this.Client);
        }

    }

}
