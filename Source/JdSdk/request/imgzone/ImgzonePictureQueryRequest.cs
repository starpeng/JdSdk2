﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzonePictureQueryRequest : JdRequestBase<ImgzonePictureQueryResponse>
    {
        public String PictureId
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

        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        public Nullable<Int32> PageNum
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("picture_id" ,this.PictureId);
            paramters.Add("picture_cate_id" ,this.PictureCateId);
            paramters.Add("picture_name" ,this.PictureName);
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_Date" ,this.EndDate);
            paramters.Add("page_num" ,this.PageNum);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
