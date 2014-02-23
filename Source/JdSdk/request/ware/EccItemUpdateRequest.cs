﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class EccItemUpdateRequest : JdRequestBase<EccItemUpdateResponse>
    {
        public Nullable<Int64> ItemId
        {
            get;
            set;
        }

        public String ItemName
        {
            get;
            set;
        }

        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        public Nullable<Int32> ItemStatus
        {
            get;
            set;
        }

        public String ItemLocation
        {
            get;
            set;
        }

        public String Brand
        {
            get;
            set;
        }

        public Nullable<Int32> Weight
        {
            get;
            set;
        }

        public String PackListing
        {
            get;
            set;
        }

        public String AftService
        {
            get;
            set;
        }

        public String SpecParam
        {
            get;
            set;
        }

        public String ItemDes
        {
            get;
            set;
        }

        public String Operator
        {
            get;
            set;
        }

        public String SkuListJson
        {
            get;
            set;
        }

        public String ItemPictureListJson
        {
            get;
            set;
        }

        public String Ip
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.item.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("item_id" ,this.ItemId);
            paramters.Add("item_name" ,this.ItemName);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("item_status" ,this.ItemStatus);
            paramters.Add("item_location" ,this.ItemLocation);
            paramters.Add("brand" ,this.Brand);
            paramters.Add("weight" ,this.Weight);
            paramters.Add("pack_listing" ,this.PackListing);
            paramters.Add("aft_service" ,this.AftService);
            paramters.Add("spec_param" ,this.SpecParam);
            paramters.Add("item_des" ,this.ItemDes);
            paramters.Add("operator" ,this.Operator);
            paramters.Add("sku_list_json" ,this.SkuListJson);
            paramters.Add("item_picture_list_json" ,this.ItemPictureListJson);
            paramters.Add("ip" ,this.Ip);
        }

    }

}
