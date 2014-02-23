﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class EccItemSearchRequest : JdRequestBase<EccItemSearchResponse>
    {
        public Nullable<Int64> ItemId
        {
            get;
            set;
        }

        public Nullable<Int32> ItemStatus
        {
            get;
            set;
        }

        public String ItemName
        {
            get;
            set;
        }

        public Nullable<Int64> CategoryId
        {
            get;
            set;
        }

        public String Ip
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

        public String OrderCloumn
        {
            get;
            set;
        }

        public String OrderType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.item.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("item_id" ,this.ItemId);
            paramters.Add("item_status" ,this.ItemStatus);
            paramters.Add("item_name" ,this.ItemName);
            paramters.Add("category_id" ,this.CategoryId);
            paramters.Add("ip" ,this.Ip);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("order_cloumn" ,this.OrderCloumn);
            paramters.Add("order_type" ,this.OrderType);
        }

    }

}
