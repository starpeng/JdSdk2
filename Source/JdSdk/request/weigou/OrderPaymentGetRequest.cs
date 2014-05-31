﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Weigou;

namespace JdSdk.Request.Weigou
{
﻿    public class OrderPaymentGetRequest : JdRequestBase<OrderPaymentGetResponse>
    {
        public String ServerName
        {
            get;
            set;
        }

        public String UserIP
        {
            get;
            set;
        }

        public Nullable<Int64> CountKey
        {
            get;
            set;
        }

        public String ServerIp
        {
            get;
            set;
        }

        public Nullable<Int32> OriginId
        {
            get;
            set;
        }

        public Nullable<Int64> Id
        {
            get;
            set;
        }

        public Nullable<Int32> ProvinceId
        {
            get;
            set;
        }

        public Nullable<Int32> CityId
        {
            get;
            set;
        }

        public Nullable<Int32> CountyId
        {
            get;
            set;
        }

        public Nullable<Int32> TownId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public String Mobile
        {
            get;
            set;
        }

        public String Phone
        {
            get;
            set;
        }

        public String Postcode
        {
            get;
            set;
        }

        public Nullable<Int32> PickId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.payment.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("serverName" ,this.ServerName);
            paramters.Add("userIP" ,this.UserIP);
            paramters.Add("countKey" ,this.CountKey);
            paramters.Add("serverIp" ,this.ServerIp);
            paramters.Add("originId" ,this.OriginId);
            paramters.Add("id" ,this.Id);
            paramters.Add("provinceId" ,this.ProvinceId);
            paramters.Add("cityId" ,this.CityId);
            paramters.Add("countyId" ,this.CountyId);
            paramters.Add("townId" ,this.TownId);
            paramters.Add("name" ,this.Name);
            paramters.Add("address" ,this.Address);
            paramters.Add("email" ,this.Email);
            paramters.Add("mobile" ,this.Mobile);
            paramters.Add("phone" ,this.Phone);
            paramters.Add("postcode" ,this.Postcode);
            paramters.Add("pickId" ,this.PickId);
        }

    }

}
