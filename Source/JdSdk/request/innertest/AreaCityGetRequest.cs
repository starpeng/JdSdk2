﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Innertest;

namespace JdSdk.Request.Innertest
{
﻿    public class AreaCityGetRequest : JdRequestBase<AreaCityGetResponse>
    {
        public Nullable<Int64> ParentId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.area.city.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("parent_id" ,this.ParentId);
        }

    }

}
