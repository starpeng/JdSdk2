﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Imgzone;

namespace JdSdk.Request.Imgzone
{
﻿    public class ImgzoneCategoryAddRequest : JdRequestBase<ImgzoneCategoryAddResponse>
    {
        public String CateName
        {
            get;
            set;
        }

        public Nullable<Int32> ParentCateId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.category.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cate_name" ,this.CateName);
            paramters.Add("parent_cate_id" ,this.ParentCateId);
        }

    }

}
