﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Recommend;

namespace JdSdk.Response.Website.Recommend
{
﻿    [Serializable]
    public class AnotherBuyCombineRecommendResponse : JdResponse
    {
        [JsonProperty("favoritewares")]
        public List<FavoriteWare> FavoriteWares
        {
            get;
            set;
        }

    }

}
