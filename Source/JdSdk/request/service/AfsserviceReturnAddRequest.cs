﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceReturnAddRequest : JdRequestBase<AfsserviceReturnAddResponse>
    {
        public Nullable<Int32> ShipWay
        {
            get;
            set;
        }

        public String ShipWayName
        {
            get;
            set;
        }

        public String Waybill
        {
            get;
            set;
        }

        public String PartCodes
        {
            get;
            set;
        }

        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public Nullable<Int32> Province
        {
            get;
            set;
        }

        public Nullable<Int32> City
        {
            get;
            set;
        }

        public Nullable<Int32> County
        {
            get;
            set;
        }

        public Nullable<Int32> Village
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String ZipCode
        {
            get;
            set;
        }

        public String ConsigneeName
        {
            get;
            set;
        }

        public String ConsigneeTel
        {
            get;
            set;
        }

        public String ApplayRemark
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.return.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("shipWay" ,this.ShipWay);
            paramters.Add("shipWayName" ,this.ShipWayName);
            paramters.Add("waybill" ,this.Waybill);
            paramters.Add("partCodes" ,this.PartCodes);
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("province" ,this.Province);
            paramters.Add("city" ,this.City);
            paramters.Add("county" ,this.County);
            paramters.Add("village" ,this.Village);
            paramters.Add("address" ,this.Address);
            paramters.Add("zipCode" ,this.ZipCode);
            paramters.Add("consigneeName" ,this.ConsigneeName);
            paramters.Add("consigneeTel" ,this.ConsigneeTel);
            paramters.Add("applayRemark" ,this.ApplayRemark);
        }

    }

}
