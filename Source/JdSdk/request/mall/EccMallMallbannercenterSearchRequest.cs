﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mall;

namespace JdSdk.Request.Mall
{
﻿    public class EccMallMallbannercenterSearchRequest : JdRequestBase<EccMallMallbannercenterSearchResponse>
    {
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        public Nullable<Int64> MallId
        {
            get;
            set;
        }

        public Nullable<Int32> SortNumber
        {
            get;
            set;
        }

        public String BannerUrl
        {
            get;
            set;
        }

        public String BannerLink
        {
            get;
            set;
        }

        public String Ip
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.mall.mallbannercenter.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("mall_id" ,this.MallId);
            paramters.Add("sort_number" ,this.SortNumber);
            paramters.Add("banner_url" ,this.BannerUrl);
            paramters.Add("banner_link" ,this.BannerLink);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
