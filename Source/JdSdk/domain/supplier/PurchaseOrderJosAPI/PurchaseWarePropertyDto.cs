﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.PurchaseOrderJosAPI
{
﻿    [Serializable]
    public class PurchaseWarePropertyDto : JdObject
    {
        [JsonProperty("wareId")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("chest")]
        public Nullable<Double> Chest
        {
            get;
            set;
        }

        [JsonProperty("waistline")]
        public Nullable<Double> Waistline
        {
            get;
            set;
        }

        [JsonProperty("hip")]
        public Nullable<Double> Hip
        {
            get;
            set;
        }

        [JsonProperty("dressLength")]
        public Nullable<Double> DressLength
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public Nullable<Double> Height
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

        [JsonProperty("mainPictureLink")]
        public String MainPictureLink
        {
            get;
            set;
        }

    }

}
