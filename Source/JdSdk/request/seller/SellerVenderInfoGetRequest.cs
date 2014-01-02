﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Seller;

namespace JdSdk.Request.Seller
{
﻿    public class SellerVenderInfoGetRequest : JdRequestBase<SellerVenderInfoGetResponse>
    {
        public String ExtJsonParam
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.vender.info.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ext_json_param" ,this.ExtJsonParam);
        }

    }

}
