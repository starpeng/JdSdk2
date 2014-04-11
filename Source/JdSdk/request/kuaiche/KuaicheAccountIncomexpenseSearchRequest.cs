﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheAccountIncomexpenseSearchRequest : JdRequestBase<KuaicheAccountIncomexpenseSearchResponse>
    {
        public Nullable<Int64> InOutType
        {
            get;
            set;
        }

        public Nullable<Int64> Type
        {
            get;
            set;
        }

        public Nullable<Int64> CheckType
        {
            get;
            set;
        }

        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.account.incomexpense.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("in_out_type" ,this.InOutType);
            paramters.Add("type" ,this.Type);
            paramters.Add("check_type" ,this.CheckType);
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
