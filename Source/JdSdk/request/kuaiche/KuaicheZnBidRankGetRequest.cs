﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnBidRankGetRequest : JdRequestBase<KuaicheZnBidRankGetResponse>
    {
        public String PlanJson
        {
            get;
            set;
        }

        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        public Nullable<Int64> KwgId
        {
            get;
            set;
        }

        public String PlanDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.bid.rank.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_json" ,this.PlanJson);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("kwg_id" ,this.KwgId);
            paramters.Add("plan_date" ,this.PlanDate);
        }

    }

}
