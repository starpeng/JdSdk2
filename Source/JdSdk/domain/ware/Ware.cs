﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Ware
{
﻿    [Serializable]
    public class Ware : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("skus")]
        public List<Sku> Skus
        {
            get;
            set;
        }

        [JsonProperty("spu_id")]
        public Nullable<Int64> SpuId
        {
            get;
            set;
        }

        [JsonProperty("cid")]
        public Nullable<Int64> CategoryId
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        [JsonProperty("ware_status")]
        public String WareStatus
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("item_num")]
        public String ItemNum
        {
            get;
            set;
        }

        [JsonProperty("upc_code")]
        public String UpcCode
        {
            get;
            set;
        }

        [JsonProperty("transport_id")]
        public Nullable<Int64> TransportId
        {
            get;
            set;
        }

        [JsonProperty("online_time")]
        public String OnlineTime
        {
            get;
            set;
        }

        [JsonProperty("offline_time")]
        public String OfflineTime
        {
            get;
            set;
        }

        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        [JsonProperty("cost_price")]
        public String CostPrice
        {
            get;
            set;
        }

        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        [JsonProperty("stock_num")]
        public Nullable<Int64> StockNum
        {
            get;
            set;
        }

        [JsonProperty("logo")]
        public String Logo
        {
            get;
            set;
        }

        [JsonProperty("creator")]
        public String Creator
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        [JsonProperty("weight")]
        public String Weight
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("outer_id")]
        public String OuterId
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

        [JsonProperty("cubage")]
        public String Cubage
        {
            get;
            set;
        }

        [JsonProperty("pack_listing")]
        public String PackListing
        {
            get;
            set;
        }

        [JsonProperty("producter")]
        public String Producter
        {
            get;
            set;
        }

        [JsonProperty("wrap")]
        public String Wrap
        {
            get;
            set;
        }

        [JsonProperty("service")]
        public String Service
        {
            get;
            set;
        }

        [JsonProperty("shop_categorys")]
        public String ShopCategorys
        {
            get;
            set;
        }

        [JsonProperty("ispayfirst")]
        public Nullable<Boolean> IsPayFirst
        {
            get;
            set;
        }

        [JsonProperty("isshelflife")]
        public Nullable<Boolean> IsShelfLife
        {
            get;
            set;
        }

        [JsonProperty("isimported")]
        public Nullable<Boolean> IsImported
        {
            get;
            set;
        }

        [JsonProperty("iscanvat")]
        public Nullable<Boolean> IsCanVat
        {
            get;
            set;
        }

        [JsonProperty("isspecialwet")]
        public Nullable<Boolean> IsSpecialWet
        {
            get;
            set;
        }

        [JsonProperty("isappliancescard")]
        public Nullable<Boolean> IsAppliancesCard
        {
            get;
            set;
        }

        [JsonProperty("ishealthproduct")]
        public Nullable<Boolean> IsHealthProduct
        {
            get;
            set;
        }

        [JsonProperty("isserialno")]
        public Nullable<Boolean> IsSerialNo
        {
            get;
            set;
        }

        [JsonProperty("shelf_life_days")]
        public Nullable<Int32> ShelfLifeDays
        {
            get;
            set;
        }

        [JsonProperty("ware_big_small_model")]
        public Nullable<Int32> WareBigSmallModel
        {
            get;
            set;
        }

        [JsonProperty("ware_pack_type")]
        public Nullable<Int32> WarePackType
        {
            get;
            set;
        }

        [JsonProperty("property_alias")]
        public String PropertyAlias
        {
            get;
            set;
        }

        [JsonProperty("ad_content")]
        public String AdContent
        {
            get;
            set;
        }

    }

}
