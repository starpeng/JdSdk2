﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzonePictureUpdateRequest : JdRequestBase<ImgzonePictureUpdateResponse>
    {
        public String PictureId
        {
            get;
            set;
        }

        public String PictureName
        {
            get;
            set;
        }

        public Nullable<Int32> PictureCateId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("picture_id" ,this.PictureId);
            paramters.Add("picture_name" ,this.PictureName);
            paramters.Add("picture_cate_id" ,this.PictureCateId);
        }

    }

}
