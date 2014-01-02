﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzonePictureIsreferencedRequest : JdRequestBase<ImgzonePictureIsreferencedResponse>
    {
        public String PictureId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.isreferenced"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("picture_id" ,this.PictureId);
        }

    }

}
