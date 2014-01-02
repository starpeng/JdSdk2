﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Ware;

namespace JdSdk.Request.Website.Ware
{
﻿    public class WareGetRequest : JdRequestBase<WareGetResponse>
    {
        public String WareId
        {
            get;
            set;
        }

        public String RegionId
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("region_id" ,this.RegionId);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
