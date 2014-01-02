﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Workorder;

namespace JdSdk.Request.Workorder
{
﻿    public class WosSubbiztypelistGetRequest : JdRequestBase<WosSubbiztypelistGetResponse>
    {
        public Nullable<Int64> BiztypeId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.wos.subbiztypelist.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("biztype_id" ,this.BiztypeId);
        }

    }

}
