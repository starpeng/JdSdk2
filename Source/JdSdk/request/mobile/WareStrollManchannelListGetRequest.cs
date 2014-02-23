﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareStrollManchannelListGetRequest : JdRequestBase<WareStrollManchannelListGetResponse>
    {
        public Nullable<Int32> Page
        {
            get;
            set;
        }

        public Nullable<Int32> Pagesize
        {
            get;
            set;
        }

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.stroll.manchannel.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("page" ,this.Page);
            paramters.Add("pagesize" ,this.Pagesize);
            paramters.Add("client" ,this.Client);
        }

    }

}
