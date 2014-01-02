﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WarePropimgDeleteRequest : JdRequestBase<WarePropimgDeleteResponse>
    {
        public String WareId
        {
            get;
            set;
        }

        public String AttributeValueId
        {
            get;
            set;
        }

        public String ImageId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.propimg.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("attribute_value_id" ,this.AttributeValueId);
            paramters.Add("image_id" ,this.ImageId);
        }

    }

}
