﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class PrintResult : JdResponse
    {
        [JsonProperty("htmlcontent")]
        public String HtmlContent
        {
            get;
            set;
        }

        [JsonProperty("html_content")]
        public String HtmlContentBase64
        {
            get;
            set;
        }

        [JsonProperty("image_data")]
        public String ImageData
        {
            get;
            set;
        }

    }

}
