﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzoneUserinfoQueryRequest : JdRequestBase<ImgzoneUserinfoQueryResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.imgzone.userinfo.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
