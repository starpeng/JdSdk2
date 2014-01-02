﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzonePictureQueryResponse : JdResponse
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

        [JsonProperty("total_num")]
        public Nullable<Int32> TotalNum
        {
            get;
            set;
        }

        [JsonProperty("imgList")]
        public List<ImgzoneImgInfo> ImgList
        {
            get;
            set;
        }

    }

}
