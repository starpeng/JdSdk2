﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnScheduleAvailableSearchRequest : JdRequestBase<KuaicheZnScheduleAvailableSearchResponse>
    {
        public Nullable<Int64> SpaceId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.schedule.available.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("space_id" ,this.SpaceId);
        }

    }

}
