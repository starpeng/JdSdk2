﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareUpdateRequest : JdRequestBase<WareUpdateResponse>
    {
        public String IsPayFirst
        {
            get;
            set;
        }

        public String IsCanVAT
        {
            get;
            set;
        }

        public String IsImported
        {
            get;
            set;
        }

        public String IsHealthProduct
        {
            get;
            set;
        }

        public String ShelfLifeDays
        {
            get;
            set;
        }

        public String IsSerialNo
        {
            get;
            set;
        }

        public String IsAppliancesCard
        {
            get;
            set;
        }

        public String IsSpecialWet
        {
            get;
            set;
        }

        public String WareBigSmallModel
        {
            get;
            set;
        }

        public String WarePackType
        {
            get;
            set;
        }

        public String IsShelfLife
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String ShopCategory
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public String UpcCode
        {
            get;
            set;
        }

        public String OptionType
        {
            get;
            set;
        }

        public String ItemNum
        {
            get;
            set;
        }

        public String StockNum
        {
            get;
            set;
        }

        public String Producter
        {
            get;
            set;
        }

        public String Wrap
        {
            get;
            set;
        }

        public String Length
        {
            get;
            set;
        }

        public String Wide
        {
            get;
            set;
        }

        public String High
        {
            get;
            set;
        }

        public String Weight
        {
            get;
            set;
        }

        public String CostPrice
        {
            get;
            set;
        }

        public String MarketPrice
        {
            get;
            set;
        }

        public String JdPrice
        {
            get;
            set;
        }

        public String Notes
        {
            get;
            set;
        }

        public String Rate
        {
            get;
            set;
        }

        public String PackListing
        {
            get;
            set;
        }

        public String Service
        {
            get;
            set;
        }

        public String SkuProperties
        {
            get;
            set;
        }

        public String Attributes
        {
            get;
            set;
        }

        public String SkuPrices
        {
            get;
            set;
        }

        public String SkuStocks
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public String PropertyAlias
        {
            get;
            set;
        }

        public String OuterId
        {
            get;
            set;
        }

        public String InputPids
        {
            get;
            set;
        }

        public String InputStrs
        {
            get;
            set;
        }

        public String HasCheckCode
        {
            get;
            set;
        }

        public String AdContent
        {
            get;
            set;
        }

        public String ListTime
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("is_pay_first" ,this.IsPayFirst);
            paramters.Add("is_can_vat" ,this.IsCanVAT);
            paramters.Add("is_imported" ,this.IsImported);
            paramters.Add("is_health_product" ,this.IsHealthProduct);
            paramters.Add("shelf_life_days" ,this.ShelfLifeDays);
            paramters.Add("is_serial_no" ,this.IsSerialNo);
            paramters.Add("is_appliances_card" ,this.IsAppliancesCard);
            paramters.Add("is_special_wet" ,this.IsSpecialWet);
            paramters.Add("ware_big_small_model" ,this.WareBigSmallModel);
            paramters.Add("ware_pack_type" ,this.WarePackType);
            paramters.Add("is_shelf_life" ,this.IsShelfLife);
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("shop_category" ,this.ShopCategory);
            paramters.Add("title" ,this.Title);
            paramters.Add("upc_code" ,this.UpcCode);
            paramters.Add("option_type" ,this.OptionType);
            paramters.Add("item_num" ,this.ItemNum);
            paramters.Add("stock_num" ,this.StockNum);
            paramters.Add("producter" ,this.Producter);
            paramters.Add("wrap" ,this.Wrap);
            paramters.Add("length" ,this.Length);
            paramters.Add("wide" ,this.Wide);
            paramters.Add("high" ,this.High);
            paramters.Add("weight" ,this.Weight);
            paramters.Add("cost_price" ,this.CostPrice);
            paramters.Add("market_price" ,this.MarketPrice);
            paramters.Add("jd_price" ,this.JdPrice);
            paramters.Add("notes" ,this.Notes);
            paramters.Add("rate" ,this.Rate);
            paramters.Add("pack_listing" ,this.PackListing);
            paramters.Add("service" ,this.Service);
            paramters.Add("sku_properties" ,this.SkuProperties);
            paramters.Add("attributes" ,this.Attributes);
            paramters.Add("sku_prices" ,this.SkuPrices);
            paramters.Add("sku_stocks" ,this.SkuStocks);
            paramters.Add("trade_no" ,this.TradeNo);
            paramters.Add("property_alias" ,this.PropertyAlias);
            paramters.Add("outer_id" ,this.OuterId);
            paramters.Add("input_pids" ,this.InputPids);
            paramters.Add("input_strs" ,this.InputStrs);
            paramters.Add("has_check_code" ,this.HasCheckCode);
            paramters.Add("ad_content" ,this.AdContent);
            paramters.Add("list_time" ,this.ListTime);
        }

    }

}
