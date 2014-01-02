﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzoneImgInfo : JdObject
    {
        [JsonProperty("picture_id")]
        public String PictureId
        {
            get;
            set;
        }

        [JsonProperty("picture_cate_id")]
        public Nullable<Int32> PictureCateId
        {
            get;
            set;
        }

        [JsonProperty("picture_url")]
        public String PictureUrl
        {
            get;
            set;
        }

        [JsonProperty("picture_name")]
        public String PictureName
        {
            get;
            set;
        }

        [JsonProperty("picture_type")]
        public String PictureType
        {
            get;
            set;
        }

        [JsonProperty("referenced")]
        public Nullable<Int32> Referenced
        {
            get;
            set;
        }

        [JsonProperty("picture_size")]
        public Nullable<Int32> PictureSize
        {
            get;
            set;
        }

        [JsonProperty("picture_width")]
        public Nullable<Int32> PictureWidth
        {
            get;
            set;
        }

        [JsonProperty("picture_height")]
        public Nullable<Int32> PictureHeight
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }

}
