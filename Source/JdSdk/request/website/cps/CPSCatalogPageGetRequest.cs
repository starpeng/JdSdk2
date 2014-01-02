﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Cps;

namespace JdSdk.Request.Website.Cps
{
﻿    public class CPSCatalogPageGetRequest : JdRequestBase<CPSCatalogPageGetResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public String ACid
        {
            get;
            set;
        }

        public String BCid
        {
            get;
            set;
        }

        public String CCid
        {
            get;
            set;
        }

        public String Level
        {
            get;
            set;
        }

        public String IsMobile
        {
            get;
            set;
        }

        public String PageIndex
        {
            get;
            set;
        }

        public String PageSize
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
            get{ return "jingdong.tuiguang.cat.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
            paramters.Add("a_cid" ,this.ACid);
            paramters.Add("b_cid" ,this.BCid);
            paramters.Add("c_cid" ,this.CCid);
            paramters.Add("level" ,this.Level);
            paramters.Add("is_mobile" ,this.IsMobile);
            paramters.Add("page" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("is_need_img" ,this.IsNeedImg);
            paramters.Add("img_size_type" ,this.ImgSizeType);
            paramters.Add("serial_number" ,this.SerialNumber);
        }

    }

}
