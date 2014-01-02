﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class CommodityInfo : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
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

        [JsonProperty("original_title")]
        public String OriginalTitle
        {
            get;
            set;
        }

        [JsonProperty("material_url")]
        public String[] MaterialUrl
        {
            get;
            set;
        }

        [JsonProperty("target_url")]
        public String TargetUrl
        {
            get;
            set;
        }

        [JsonProperty("domain")]
        public String Domain
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public Nullable<Decimal> Price
        {
            get;
            set;
        }

        [JsonProperty("menu_name")]
        public String MenuName
        {
            get;
            set;
        }

        [JsonProperty("goods_path")]
        public List<String> GoodsPath
        {
            get;
            set;
        }

        [JsonProperty("page_category_id")]
        public Nullable<Int64> PageCategoryId
        {
            get;
            set;
        }

        [JsonProperty("page_category_id_all")]
        public String PageCategoryIdAll
        {
            get;
            set;
        }

        [JsonProperty("material_spu")]
        public List<CommoditySpu> MaterialSpu
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        [JsonProperty("space_id")]
        public Nullable<Int64> SpaceId
        {
            get;
            set;
        }

        [JsonProperty("review_status")]
        public Nullable<Int32> ReviewStatus
        {
            get;
            set;
        }

        [JsonProperty("review_mark")]
        public String ReviewMark
        {
            get;
            set;
        }

        [JsonProperty("show_days")]
        public List<Int32> ShowDays
        {
            get;
            set;
        }

    }

}
