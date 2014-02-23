﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class ActivityProductsList : JdObject
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

        [JsonProperty("page")]
        public Nullable<Int32> Page
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

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("promotionDetail")]
        public String PromotionDetail
        {
            get;
            set;
        }

        [JsonProperty("horizontalImag")]
        public String HorizontalImag
        {
            get;
            set;
        }

        [JsonProperty("activityProducts")]
        public List<WareInfo> ActivityProducts
        {
            get;
            set;
        }

    }

}
