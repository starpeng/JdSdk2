﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Cps;

namespace JdSdk.Request.Website.Cps
{
﻿    public class CPSSpreadHomeInfoRequest : JdRequestBase<CPSSpreadHomeInfoResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public String IsMobile
        {
            get;
            set;
        }

        public Nullable<Boolean> IsNeedImg
        {
            get;
            set;
        }

        public String ImgSizeType
        {
            get;
            set;
        }

        public String SerialNumber
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.tuiguang.homepage.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
            paramters.Add("is_mobile" ,this.IsMobile);
            paramters.Add("is_need_img" ,this.IsNeedImg);
            paramters.Add("img_size_type" ,this.ImgSizeType);
            paramters.Add("serial_number" ,this.SerialNumber);
        }

    }

}
