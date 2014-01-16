﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CmsActivityWareList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("totalCount")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("couponStatus")]
        public Nullable<Int32> CouponStatus
        {
            get;
            set;
        }

        [JsonProperty("couponURL")]
        public String CouponURL
        {
            get;
            set;
        }

        [JsonProperty("roleIds")]
        public String RoleIds
        {
            get;
            set;
        }

        [JsonProperty("cmsActivityRebateImg")]
        public String CmsActivityRebateImg
        {
            get;
            set;
        }

        [JsonProperty("cmsActivityWareLists")]
        public List<CmsActivityWare> CmsActivityWareLists
        {
            get;
            set;
        }

    }

}
