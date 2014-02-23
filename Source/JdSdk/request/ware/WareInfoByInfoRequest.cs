﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareInfoByInfoRequest : JdRequestBase<WareInfoByInfoSearchResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public String StartPrice
        {
            get;
            set;
        }

        public String EndPrice
        {
            get;
            set;
        }

        public String Page
        {
            get;
            set;
        }

        public String PageSize
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public String OrderBy
        {
            get;
            set;
        }

        public String StartTime
        {
            get;
            set;
        }

        public String EndTime
        {
            get;
            set;
        }

        public String StartModified
        {
            get;
            set;
        }

        public String EndModified
        {
            get;
            set;
        }

        public String WareStatus
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public String ParentShopCategoryId
        {
            get;
            set;
        }

        public String ShopCategoryId
        {
            get;
            set;
        }

        public String ItemNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.wares.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("start_price" ,this.StartPrice);
            paramters.Add("end_price" ,this.EndPrice);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("title" ,this.Title);
            paramters.Add("order_by" ,this.OrderBy);
            paramters.Add("start_time" ,this.StartTime);
            paramters.Add("end_time" ,this.EndTime);
            paramters.Add("start_modified" ,this.StartModified);
            paramters.Add("end_modified" ,this.EndModified);
            paramters.Add("ware_status" ,this.WareStatus);
            paramters.Add("fields" ,this.Fields);
            paramters.Add("parentShopCategoryId" ,this.ParentShopCategoryId);
            paramters.Add("shopCategoryId" ,this.ShopCategoryId);
            paramters.Add("itemNum" ,this.ItemNum);
        }

    }

}
