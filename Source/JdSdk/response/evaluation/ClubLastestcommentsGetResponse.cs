﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Evaluation
{
﻿    [Serializable]
    public class ClubLastestcommentsGetResponse : JdResponse
    {
        [JsonProperty("result_code")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("comments")]
        public List<CommentVo> Comments
        {
            get;
            set;
        }

    }

}
