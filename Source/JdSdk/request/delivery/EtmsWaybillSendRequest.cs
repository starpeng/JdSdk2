﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsWaybillSendRequest : JdRequestBase<EtmsWaybillSendResponse>
    {
        public String DeliveryId
        {
            get;
            set;
        }

        public String SalePlat
        {
            get;
            set;
        }

        public String CustomerCode
        {
            get;
            set;
        }

        public String OrderId
        {
            get;
            set;
        }

        public String ThrOrderId
        {
            get;
            set;
        }

        public Nullable<Int32> SelfPrintWayBill
        {
            get;
            set;
        }

        public String PickMethod
        {
            get;
            set;
        }

        public String PackageRequired
        {
            get;
            set;
        }

        public String SenderName
        {
            get;
            set;
        }

        public String SenderAddress
        {
            get;
            set;
        }

        public String SenderTel
        {
            get;
            set;
        }

        public String SenderMobile
        {
            get;
            set;
        }

        public String SenderPostcode
        {
            get;
            set;
        }

        public String ReceiveName
        {
            get;
            set;
        }

        public String ReceiveAddress
        {
            get;
            set;
        }

        public String Province
        {
            get;
            set;
        }

        public String City
        {
            get;
            set;
        }

        public String County
        {
            get;
            set;
        }

        public String Town
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

        public Nullable<Int32> SiteType
        {
            get;
            set;
        }

        public Nullable<Int32> SiteId
        {
            get;
            set;
        }

        public String SiteName
        {
            get;
            set;
        }

        public String ReceiveTel
        {
            get;
            set;
        }

        public String ReceiveMobile
        {
            get;
            set;
        }

        public String Postcode
        {
            get;
            set;
        }

        public Nullable<Int32> PackageCount
        {
            get;
            set;
        }

        public Nullable<Double> Weight
        {
            get;
            set;
        }

        public Nullable<Double> VloumLong
        {
            get;
            set;
        }

        public Nullable<Double> VloumWidth
        {
            get;
            set;
        }

        public Nullable<Double> VloumHeight
        {
            get;
            set;
        }

        public Nullable<Double> Vloumn
        {
            get;
            set;
        }

        public String Description
        {
            get;
            set;
        }

        public Nullable<Int32> CollectionValue
        {
            get;
            set;
        }

        public Nullable<Double> CollectionMoney
        {
            get;
            set;
        }

        public Nullable<Int32> GuaranteeValue
        {
            get;
            set;
        }

        public Nullable<Double> GuaranteeValueAmount
        {
            get;
            set;
        }

        public Nullable<Int32> SignReturn
        {
            get;
            set;
        }

        public Nullable<Int32> Aging
        {
            get;
            set;
        }

        public Nullable<Int32> TransType
        {
            get;
            set;
        }

        public String ExtendField1
        {
            get;
            set;
        }

        public String ExtendField2
        {
            get;
            set;
        }

        public String ExtendField3
        {
            get;
            set;
        }

        public Nullable<Int32> ExtendField4
        {
            get;
            set;
        }

        public Nullable<Int32> ExtendField5
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.waybill.send"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("deliveryId" ,this.DeliveryId);
            paramters.Add("salePlat" ,this.SalePlat);
            paramters.Add("customerCode" ,this.CustomerCode);
            paramters.Add("orderId" ,this.OrderId);
            paramters.Add("thrOrderId" ,this.ThrOrderId);
            paramters.Add("selfPrintWayBill" ,this.SelfPrintWayBill);
            paramters.Add("pickMethod" ,this.PickMethod);
            paramters.Add("packageRequired" ,this.PackageRequired);
            paramters.Add("senderName" ,this.SenderName);
            paramters.Add("senderAddress" ,this.SenderAddress);
            paramters.Add("senderTel" ,this.SenderTel);
            paramters.Add("senderMobile" ,this.SenderMobile);
            paramters.Add("senderPostcode" ,this.SenderPostcode);
            paramters.Add("receiveName" ,this.ReceiveName);
            paramters.Add("receiveAddress" ,this.ReceiveAddress);
            paramters.Add("province" ,this.Province);
            paramters.Add("city" ,this.City);
            paramters.Add("county" ,this.County);
            paramters.Add("town" ,this.Town);
            paramters.Add("provinceId" ,this.ProvinceId);
            paramters.Add("cityId" ,this.CityId);
            paramters.Add("countyId" ,this.CountyId);
            paramters.Add("townId" ,this.TownId);
            paramters.Add("siteType" ,this.SiteType);
            paramters.Add("siteId" ,this.SiteId);
            paramters.Add("siteName" ,this.SiteName);
            paramters.Add("receiveTel" ,this.ReceiveTel);
            paramters.Add("receiveMobile" ,this.ReceiveMobile);
            paramters.Add("postcode" ,this.Postcode);
            paramters.Add("packageCount" ,this.PackageCount);
            paramters.Add("weight" ,this.Weight);
            paramters.Add("vloumLong" ,this.VloumLong);
            paramters.Add("vloumWidth" ,this.VloumWidth);
            paramters.Add("vloumHeight" ,this.VloumHeight);
            paramters.Add("vloumn" ,this.Vloumn);
            paramters.Add("description" ,this.Description);
            paramters.Add("collectionValue" ,this.CollectionValue);
            paramters.Add("collectionMoney" ,this.CollectionMoney);
            paramters.Add("guaranteeValue" ,this.GuaranteeValue);
            paramters.Add("guaranteeValueAmount" ,this.GuaranteeValueAmount);
            paramters.Add("signReturn" ,this.SignReturn);
            paramters.Add("aging" ,this.Aging);
            paramters.Add("transType" ,this.TransType);
            paramters.Add("extendField1" ,this.ExtendField1);
            paramters.Add("extendField2" ,this.ExtendField2);
            paramters.Add("extendField3" ,this.ExtendField3);
            paramters.Add("extendField4" ,this.ExtendField4);
            paramters.Add("extendField5" ,this.ExtendField5);
        }

    }

}
