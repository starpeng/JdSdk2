﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class VcCreateReturnOrderRequest : JdRequestBase<VcCreateReturnOrderResponse>
    {
        public Nullable<Int32> FromDeliverCenterId
        {
            get;
            set;
        }

        public Nullable<Int32> ToDeliverCenterId
        {
            get;
            set;
        }

        public String PurchaseErpCode
        {
            get;
            set;
        }

        public Nullable<Int32> BalanceType
        {
            get;
            set;
        }

        public Nullable<Int32> TransportType
        {
            get;
            set;
        }

        public String ReceiverName
        {
            get;
            set;
        }

        public String ReceiverCell
        {
            get;
            set;
        }

        public String PikerID
        {
            get;
            set;
        }

        public Nullable<DateTime> ReservedPickUpDate
        {
            get;
            set;
        }

        public String ReceiverAddress
        {
            get;
            set;
        }

        public String PostCode
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String ReturnNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.vc.create.return.order"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fromDeliverCenterId" ,this.FromDeliverCenterId);
            paramters.Add("toDeliverCenterId" ,this.ToDeliverCenterId);
            paramters.Add("purchaseErpCode" ,this.PurchaseErpCode);
            paramters.Add("balanceType" ,this.BalanceType);
            paramters.Add("transportType" ,this.TransportType);
            paramters.Add("receiverName" ,this.ReceiverName);
            paramters.Add("receiverCell" ,this.ReceiverCell);
            paramters.Add("pikerID" ,this.PikerID);
            paramters.Add("reservedPickUpDate" ,this.ReservedPickUpDate);
            paramters.Add("receiverAddress" ,this.ReceiverAddress);
            paramters.Add("postCode" ,this.PostCode);
            paramters.Add("wareId" ,this.WareId);
            paramters.Add("returnNum" ,this.ReturnNum);
        }

    }

}
