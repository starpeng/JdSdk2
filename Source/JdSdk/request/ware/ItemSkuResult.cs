﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    [Serializable]
    public class ItemSkuResult : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("item_id")]
        public Nullable<Int64> ItemId
        {
            get;
            set;
        }

        [JsonProperty("seller_id")]
        public Nullable<Int64> SellerId
        {
            get;
            set;
        }

        [JsonProperty("sku_status")]
        public Nullable<Int32> SkuStatus
        {
            get;
            set;
        }

        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

        [JsonProperty("item_name")]
        public String ItemName
        {
            get;
            set;
        }

        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        [JsonProperty("item_status")]
        public Nullable<Int32> ItemStatus
        {
            get;
            set;
        }

        [JsonProperty("item_location")]
        public String ItemLocation
        {
            get;
            set;
        }

        [JsonProperty("brand")]
        public String Brand
        {
            get;
            set;
        }

        [JsonProperty("weight")]
        public Nullable<Int32> Weight
        {
            get;
            set;
        }

        [JsonProperty("pack_listing")]
        public String PackListing
        {
            get;
            set;
        }

        [JsonProperty("aft_service")]
        public String AftService
        {
            get;
            set;
        }

        [JsonProperty("spec_param")]
        public String SpecParam
        {
            get;
            set;
        }

        [JsonProperty("item_picture_result_list")]
        public List<ItemPictureResult> ItemPictureResultList
        {
            get;
            set;
        }

    }

}
