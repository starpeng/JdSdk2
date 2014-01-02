﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzonePictureUploadRequest : JdRequestBase<ImgzonePictureUploadResponse>
    {
        public Byte[] ImageData
        {
            get;
            set;
        }

        public Nullable<Int32> PictureCateId
        {
            get;
            set;
        }

        public String PictureName
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.upload"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("image_data" ,this.ImageData);
            paramters.Add("picture_cate_id" ,this.PictureCateId);
            paramters.Add("picture_name" ,this.PictureName);
        }

    }

}
