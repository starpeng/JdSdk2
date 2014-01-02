﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class PromotionInfo : JdObject
    {
        [JsonProperty("promoId")]
        public String PromoId
        {
            get;
            set;
        }

        [JsonProperty("promoType")]
        public Nullable<Int32> PromoType
        {
            get;
            set;
        }

        [JsonProperty("extType")]
        public Nullable<Int32> ExtType
        {
            get;
            set;
        }

        [JsonProperty("fullRefundType")]
        public Nullable<Int32> FullRefundType
        {
            get;
            set;
        }

        [JsonProperty("userLevel")]
        public Nullable<Int32> UserLevel
        {
            get;
            set;
        }

        [JsonProperty("minNum")]
        public Nullable<Int32> MinNum
        {
            get;
            set;
        }

        [JsonProperty("maxNum")]
        public Nullable<Int32> MaxNum
        {
            get;
            set;
        }

        [JsonProperty("limitUserType")]
        public Nullable<Int32> LimitUserType
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        [JsonProperty("discount")]
        public String Discount
        {
            get;
            set;
        }

        [JsonProperty("reward")]
        public String Reward
        {
            get;
            set;
        }

        [JsonProperty("addMoney")]
        public String AddMoney
        {
            get;
            set;
        }

        [JsonProperty("needMondey")]
        public String NeedMondey
        {
            get;
            set;
        }

        [JsonProperty("needNum")]
        public Nullable<Int32> NeedNum
        {
            get;
            set;
        }

        [JsonProperty("deliverNum")]
        public Nullable<Int32> DeliverNum
        {
            get;
            set;
        }

        [JsonProperty("topMoney")]
        public String TopMoney
        {
            get;
            set;
        }

        [JsonProperty("percent")]
        public Nullable<Double> Percent
        {
            get;
            set;
        }

        [JsonProperty("rebate")]
        public Nullable<Double> Rebate
        {
            get;
            set;
        }

        [JsonProperty("haveFullRefundGifts")]
        public Nullable<Boolean> HaveFullRefundGifts
        {
            get;
            set;
        }

        [JsonProperty("score")]
        public Nullable<Int32> Score
        {
            get;
            set;
        }

        [JsonProperty("promoEndTime")]
        public Nullable<Int64> PromoEndTime
        {
            get;
            set;
        }

        [JsonProperty("adwordCouponList")]
        public List<AdwordCoupon> AdwordCouponList
        {
            get;
            set;
        }

        [JsonProperty("adwordGiftSkuList")]
        public List<AdwordGiftSku> AdwordGiftSkuList
        {
            get;
            set;
        }

    }

}
