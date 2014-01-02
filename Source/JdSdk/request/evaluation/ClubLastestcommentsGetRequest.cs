﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Evaluation;

namespace JdSdk.Request.Evaluation
{
﻿    public class ClubLastestcommentsGetRequest : JdRequestBase<ClubLastestcommentsGetResponse>
    {
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.club.lastestcomments.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
        }

    }

}
