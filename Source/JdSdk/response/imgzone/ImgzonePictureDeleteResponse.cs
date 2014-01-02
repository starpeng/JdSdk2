﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzonePictureDeleteResponse : JdResponse
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

        [JsonProperty("success_num")]
        public Nullable<Int32> SuccessNum
        {
            get;
            set;
        }

        [JsonProperty("illegal")]
        public List<String> Illegal
        {
            get;
            set;
        }

        [JsonProperty("referenced")]
        public List<String> Referenced
        {
            get;
            set;
        }

        [JsonProperty("fail")]
        public List<String> Fail
        {
            get;
            set;
        }

    }

}
