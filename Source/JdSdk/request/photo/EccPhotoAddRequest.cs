﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Photo;

namespace JdSdk.Request.Photo
{
﻿    public class EccPhotoAddRequest : JdRequestBase<EccPhotoAddResponse>
    {
        public byte[] File
        {
            get;
            set;
        }

        public String Ip
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.photo.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("file" ,this.File);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
