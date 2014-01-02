﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzonePictureIsreferencedResponse : JdResponse
    {
        [JsonProperty("return_code")]
        public Nullable<Int32> ReturnCode
        {
            get;
            set;
        }

        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        [JsonProperty("is_referenced")]
        public Nullable<Boolean> IsReferenced
        {
            get;
            set;
        }

    }

}
