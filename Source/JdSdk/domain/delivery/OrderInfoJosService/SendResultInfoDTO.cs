﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.OrderInfoJosService
{
﻿    [Serializable]
    public class SendResultInfoDTO : JdObject
    {
        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("orderId")]
        public String OrderId
        {
            get;
            set;
        }

        [JsonProperty("deliveryId")]
        public String DeliveryId
        {
            get;
            set;
        }

    }

}
