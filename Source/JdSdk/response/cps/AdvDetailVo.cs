﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class AdvDetailVo : JdObject
    {
        [JsonProperty("promotion_plan")]
        public PromotionPlanVO PromotionPlan
        {
            get;
            set;
        }

        [JsonProperty("promotion_shop")]
        public PromotionShopVO PromotionShop
        {
            get;
            set;
        }

        [JsonProperty("promotion_goods")]
        public PromotionGoodsVO PromotionGoods
        {
            get;
            set;
        }

        [JsonProperty("promotion_activity")]
        public PromotionActivityVO PromotionActivity
        {
            get;
            set;
        }

    }

}
