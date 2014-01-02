﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsSkuUpdateRequest : JdRequestBase<LogisticsSkuUpdateResponse>
    {
        public String GoodsNo
        {
            get;
            set;
        }

        public String BarCode
        {
            get;
            set;
        }

        public String SkuId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String GoodsAbbreviation
        {
            get;
            set;
        }

        public String CategoryId
        {
            get;
            set;
        }

        public String CategoryName
        {
            get;
            set;
        }

        public String BrandNo
        {
            get;
            set;
        }

        public String BrandName
        {
            get;
            set;
        }

        public String Format
        {
            get;
            set;
        }

        public String Color
        {
            get;
            set;
        }

        public String Size
        {
            get;
            set;
        }

        public String GrossWeight
        {
            get;
            set;
        }

        public String NetWeight
        {
            get;
            set;
        }

        public String SizeDefinition
        {
            get;
            set;
        }

        public String SuppliersName
        {
            get;
            set;
        }

        public String Manufacturer
        {
            get;
            set;
        }

        public String SuppliersNo
        {
            get;
            set;
        }

        public String ProductArea
        {
            get;
            set;
        }

        public Single Length
        {
            get;
            set;
        }

        public Single Width
        {
            get;
            set;
        }

        public Single Height
        {
            get;
            set;
        }

        public Single Volume
        {
            get;
            set;
        }

        public Nullable<Int32> IsSafe
        {
            get;
            set;
        }

        public String SafeDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.sku.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("bar_code" ,this.BarCode);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("name" ,this.Name);
            paramters.Add("goods_abbreviation" ,this.GoodsAbbreviation);
            paramters.Add("category_id" ,this.CategoryId);
            paramters.Add("category_name" ,this.CategoryName);
            paramters.Add("brand_no" ,this.BrandNo);
            paramters.Add("brand_name" ,this.BrandName);
            paramters.Add("format" ,this.Format);
            paramters.Add("color" ,this.Color);
            paramters.Add("size" ,this.Size);
            paramters.Add("gross_weight" ,this.GrossWeight);
            paramters.Add("net_weight" ,this.NetWeight);
            paramters.Add("size_definition" ,this.SizeDefinition);
            paramters.Add("suppliers_name" ,this.SuppliersName);
            paramters.Add("manufacturer" ,this.Manufacturer);
            paramters.Add("suppliers_no" ,this.SuppliersNo);
            paramters.Add("product_area" ,this.ProductArea);
            paramters.Add("length" ,this.Length);
            paramters.Add("width" ,this.Width);
            paramters.Add("height" ,this.Height);
            paramters.Add("volume" ,this.Volume);
            paramters.Add("is_safe" ,this.IsSafe);
            paramters.Add("safe_date" ,this.SafeDate);
        }

    }

}
