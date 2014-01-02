﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Ware;

namespace JdSdk.Request.Website.Ware
{
﻿    public class RegionInfoGetRequest : JdRequestBase<RegionInfoGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.regioninfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
