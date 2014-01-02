﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class ProductInfo : JdObject
    {
        [JsonProperty("imgUrlN5")]
        public String ImgUrlN5
        {
            get;
            set;
        }

        [JsonProperty("secKill")]
        public Nullable<Boolean> SecKill
        {
            get;
            set;
        }

        [JsonProperty("wname")]
        public String Wname
        {
            get;
            set;
        }

        [JsonProperty("adword")]
        public String Adword
        {
            get;
            set;
        }

        [JsonProperty("marketPrice")]
        public Nullable<Double> MarketPrice
        {
            get;
            set;
        }

        [JsonProperty("averageScore")]
        public Nullable<Int32> AverageScore
        {
            get;
            set;
        }

        [JsonProperty("promotion")]
        public Nullable<Boolean> Promotion
        {
            get;
            set;
        }

        [JsonProperty("jdPrice")]
        public Nullable<Double> JdPrice
        {
            get;
            set;
        }

        [JsonProperty("good")]
        public String Good
        {
            get;
            set;
        }

        [JsonProperty("canConsultFlag")]
        public Nullable<Boolean> CanConsultFlag
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

        [JsonProperty("isbook")]
        public Nullable<Boolean> Isbook
        {
            get;
            set;
        }

        [JsonProperty("totalCount")]
        public Nullable<Int64> TotalCount
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

        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        [JsonProperty("directShow")]
        public Nullable<Boolean> DirectShow
        {
            get;
            set;
        }

        [JsonProperty("canFreeRead")]
        public Nullable<Boolean> CanFreeRead
        {
            get;
            set;
        }

        [JsonProperty("showMartPrice")]
        public Nullable<Boolean> ShowMartPrice
        {
            get;
            set;
        }

        [JsonProperty("skuId")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("imgUrlN1")]
        public String ImgUrlN1
        {
            get;
            set;
        }

        [JsonProperty("imgurl")]
        public String Imgurl
        {
            get;
            set;
        }

    }

}
