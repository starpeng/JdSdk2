﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mall;

namespace JdSdk.Request.Mall
{
﻿    public class EccMallRecommendDeleteRequest : JdRequestBase<EccMallRecommendDeleteResponse>
    {
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public Nullable<Int32> Position
        {
            get;
            set;
        }

        public Nullable<Int32> RecType
        {
            get;
            set;
        }

        public Nullable<Int64> MallId
        {
            get;
            set;
        }

        public String RecommendWareListJson
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
            get{ return "jingdong.ecc.mall.recommend.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("title" ,this.Title);
            paramters.Add("position" ,this.Position);
            paramters.Add("rec_type" ,this.RecType);
            paramters.Add("mall_id" ,this.MallId);
            paramters.Add("recommend_ware_list_json" ,this.RecommendWareListJson);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
