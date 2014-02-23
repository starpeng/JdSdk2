﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareSearchHotkeywordsListGetRequest : JdRequestBase<WareSearchHotkeywordsListGetResponse>
    {
        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.search.hotkeywords.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("client" ,this.Client);
        }

    }

}
