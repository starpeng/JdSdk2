﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareAreaLimitUpdateRequest : JdRequestBase<WareAreaLimitUpdateResponse>
    {
        public String Levs
        {
            get;
            set;
        }

        public String AreaIds
        {
            get;
            set;
        }

        public String AreaFids
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String Type
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.area.limit.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("levs" ,this.Levs);
            paramters.Add("area_ids" ,this.AreaIds);
            paramters.Add("area_fids" ,this.AreaFids);
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("type" ,this.Type);
        }

    }

}
