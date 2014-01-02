﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.After
{
﻿    [Serializable]
    public class ReturnInfo : JdObject
    {
        [JsonProperty("return_id")]
        public String ReturnId
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        [JsonProperty("send_type")]
        public String SendType
        {
            get;
            set;
        }

        [JsonProperty("receive_state")]
        public String ReceiveState
        {
            get;
            set;
        }

        [JsonProperty("linkman")]
        public String Linkman
        {
            get;
            set;
        }

        [JsonProperty("phone")]
        public String Phone
        {
            get;
            set;
        }

        [JsonProperty("return_address")]
        public String ReturnAddress
        {
            get;
            set;
        }

        [JsonProperty("consignee")]
        public String Consignee
        {
            get;
            set;
        }

        [JsonProperty("consignor")]
        public String Consignor
        {
            get;
            set;
        }

        [JsonProperty("send_time")]
        public String SendTime
        {
            get;
            set;
        }

        [JsonProperty("receive_time")]
        public String ReceiveTime
        {
            get;
            set;
        }

        [JsonProperty("modifid_time")]
        public String ModifidTime
        {
            get;
            set;
        }

        [JsonProperty("return_item_list")]
        public List<ReturnItem> ReturnItemList
        {
            get;
            set;
        }

    }

}
