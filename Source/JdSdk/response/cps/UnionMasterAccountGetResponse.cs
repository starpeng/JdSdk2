﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionMasterAccountGetResponse : JdResponse
    {
        [JsonProperty("union_id")]
        public String UnionId
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        [JsonProperty("nick")]
        public String Nick
        {
            get;
            set;
        }

        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        [JsonProperty("email")]
        public String Email
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

        [JsonProperty("campany_name")]
        public String CampanyName
        {
            get;
            set;
        }

        [JsonProperty("campany_address")]
        public String CampanyAddress
        {
            get;
            set;
        }

        [JsonProperty("bank_name")]
        public String BankName
        {
            get;
            set;
        }

        [JsonProperty("bank_address")]
        public String BankAddress
        {
            get;
            set;
        }

        [JsonProperty("card_no")]
        public String CardNo
        {
            get;
            set;
        }

        [JsonProperty("owner_name")]
        public String OwnerName
        {
            get;
            set;
        }

        [JsonProperty("owner_id")]
        public String OwnerId
        {
            get;
            set;
        }

    }

}
