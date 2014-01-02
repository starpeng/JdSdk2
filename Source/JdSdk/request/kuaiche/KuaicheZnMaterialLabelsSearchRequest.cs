﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnMaterialLabelsSearchRequest : JdRequestBase<KuaicheZnMaterialLabelsSearchResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.material.labels.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
