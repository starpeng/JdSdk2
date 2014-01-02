﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionGoodsCodeGetRequest : JdRequestBase<UnionGoodsCodeGetResponse>
    {
        public Nullable<Int64> GoodId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.goods.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("good_id" ,this.GoodId);
        }

    }

}
