﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareBarcodeGetRequest : JdRequestBase<WareBarcodeGetResponse>
    {
        public String Barcode
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
            get{ return "jingdong.ware.barcode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("barcode" ,this.Barcode);
            paramters.Add("client" ,this.Client);
        }

    }

}
