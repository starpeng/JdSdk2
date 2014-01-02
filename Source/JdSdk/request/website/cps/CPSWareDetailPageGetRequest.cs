﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Cps;

namespace JdSdk.Request.Website.Cps
{
﻿    public class CPSWareDetailPageGetRequest : JdRequestBase<CPSWareDetailPageGetResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public String SkuIds
        {
            get;
            set;
        }

        public String IsMobile
        {
            get;
            set;
        }

        public String LinkType
        {
            get;
            set;
        }

        public String ImgSizeType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.tuiguang.wares.detail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
            paramters.Add("sku_ids" ,this.SkuIds);
            paramters.Add("is_mobile" ,this.IsMobile);
            paramters.Add("link_type" ,this.LinkType);
            paramters.Add("img_size_type" ,this.ImgSizeType);
        }

    }

}
