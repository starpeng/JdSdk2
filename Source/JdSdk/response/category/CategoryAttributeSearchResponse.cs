﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class CategoryAttributeSearchResponse : JdResponse
    {
        [JsonProperty("attributes")]
        public List<attribute> Attributes
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

﻿        [Serializable]
        public class attribute : JdObject
        {
            [JsonProperty("aid")]
            public Nullable<Int64> Aid
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

            [JsonProperty("iskeyprop")]
            public Nullable<Boolean> IsKeyProp
            {
                get;
                set;
            }

            [JsonProperty("iscolorprop")]
            public Nullable<Boolean> IsColorProp
            {
                get;
                set;
            }

            [JsonProperty("issizeprop")]
            public Nullable<Boolean> IsSizeProp
            {
                get;
                set;
            }

            [JsonProperty("issaleprop")]
            public Nullable<Boolean> IsSaleProp
            {
                get;
                set;
            }

            [JsonProperty("index_id")]
            public Nullable<Int64> IndexId
            {
                get;
                set;
            }

            [JsonProperty("status")]
            public String Status
            {
                get;
                set;
            }

            [JsonProperty("att_type")]
            public String AttType
            {
                get;
                set;
            }

            [JsonProperty("input_type")]
            public Nullable<Int64> InputType
            {
                get;
                set;
            }

            [JsonProperty("options")]
            public String Options
            {
                get;
                set;
            }

            [JsonProperty("isreq")]
            public String IsReq
            {
                get;
                set;
            }

            [JsonProperty("isfet")]
            public String IsFet
            {
                get;
                set;
            }

            [JsonProperty("isnav")]
            public String IsNav
            {
                get;
                set;
            }

            [JsonProperty("cid")]
            public String Cid
            {
                get;
                set;
            }

            [JsonProperty("group_id")]
            public String GroupId
            {
                get;
                set;
            }

        }

    }

}
