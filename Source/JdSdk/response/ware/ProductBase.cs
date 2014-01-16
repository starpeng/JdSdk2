﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ProductBase : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("image_path")]
        public String ImagePath
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public Nullable<Int32> State
        {
            get;
            set;
        }

        [JsonProperty("is_delete")]
        public Nullable<Int32> IsDelete
        {
            get;
            set;
        }

        [JsonProperty("brand_name")]
        public String BrandName
        {
            get;
            set;
        }

        [JsonProperty("value_weight")]
        public String ValueWeight
        {
            get;
            set;
        }

        [JsonProperty("length")]
        public Nullable<Int32> Length
        {
            get;
            set;
        }

        [JsonProperty("width")]
        public Nullable<Int32> Width
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public Nullable<Int32> Height
        {
            get;
            set;
        }

        [JsonProperty("value_pay_first")]
        public Nullable<Int32> ValuePayFirst
        {
            get;
            set;
        }

        [JsonProperty("weight")]
        public Nullable<double> Weight
        {
            get;
            set;
        }

        [JsonProperty("cid2")]
        public Nullable<Int32> Cid2
        {
            get;
            set;
        }

        [JsonProperty("product_area")]
        public String ProductArea
        {
            get;
            set;
        }

        [JsonProperty("sale_date")]
        public Nullable<DateTime> SaleDate
        {
            get;
            set;
        }

        [JsonProperty("wserve")]
        public String Wserve
        {
            get;
            set;
        }

        [JsonProperty("allnum")]
        public Nullable<Int32> Allnum
        {
            get;
            set;
        }

        [JsonProperty("brand_id")]
        public Nullable<Int32> BrandId
        {
            get;
            set;
        }

        [JsonProperty("color")]
        public String Color
        {
            get;
            set;
        }

        [JsonProperty("color_sequence")]
        public Nullable<Int32> ColorSequence
        {
            get;
            set;
        }

        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

        [JsonProperty("size_sequence")]
        public Nullable<Int32> SizeSequence
        {
            get;
            set;
        }

        [JsonProperty("ebrand")]
        public String Ebrand
        {
            get;
            set;
        }

        [JsonProperty("cbrand")]
        public String Cbrand
        {
            get;
            set;
        }

        [JsonProperty("model")]
        public String Model
        {
            get;
            set;
        }

        [JsonProperty("category")]
        public String Category
        {
            get;
            set;
        }

    }

}
