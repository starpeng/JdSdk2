﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzonePictureReplaceRequest : JdRequestBase<ImgzonePictureReplaceResponse>
    {
        public String PictureId
        {
            get;
            set;
        }

        public byte[] ImageData
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.replace"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("picture_id" ,this.PictureId);
            paramters.Add("image_data" ,this.ImageData);
        }

    }

}
