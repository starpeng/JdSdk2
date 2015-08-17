﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WarePropimgAddRequest : JdRequestBase<WarePropimgAddResponse>,IJdUploadRequest<WarePropimgAddResponse>
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

        public Nullable<Boolean> IsMainPic
        {
            get;
            set;
        }

        public FileItem Image
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.propimg.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("attribute_value_id" ,this.AttributeValueId);
            paramters.Add("is_main_pic" ,this.IsMainPic);
        }

        public IDictionary<String, FileItem> GetFileParameters()
        {
            Dictionary<String, FileItem> paramters = new Dictionary<String, FileItem>();
            paramters.Add("image", this.Image);
            return paramters;
        }

    }

}
