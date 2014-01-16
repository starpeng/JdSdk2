﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionAddRequest : JdRequestBase<SellerPromotionAddResponse>
    {
        public String Name
        {
            get;
            set;
        }

        public Nullable<Int32> Type
        {
            get;
            set;
        }

        public String BeginTime
        {
            get;
            set;
        }

        public String EndTime
        {
            get;
            set;
        }

        public Nullable<Int32> Bound
        {
            get;
            set;
        }

        public Nullable<Int32> Member
        {
            get;
            set;
        }

        public String Slogan
        {
            get;
            set;
        }

        public String Comment
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("name" ,this.Name);
            paramters.Add("type" ,this.Type);
            paramters.Add("begin_time" ,this.BeginTime);
            paramters.Add("end_time" ,this.EndTime);
            paramters.Add("bound" ,this.Bound);
            paramters.Add("member" ,this.Member);
            paramters.Add("slogan" ,this.Slogan);
            paramters.Add("comment" ,this.Comment);
        }

    }

}
