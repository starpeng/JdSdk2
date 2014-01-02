﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Response;
using JdSdk.Request;

namespace JdSdk.Domain.Website.Request
{
﻿    public class OrderCreateRequest : JdRequestBase<OrderCreateResponse>
    {
        public String SkusInfo
        {
            get;
            set;
        }

        public String BuyerName
        {
            get;
            set;
        }

        public String ReceiverName
        {
            get;
            set;
        }

        public String ReceiverProvinc
        {
            get;
            set;
        }

        public String ReceiverCity
        {
            get;
            set;
        }

        public String ReceiverArea
        {
            get;
            set;
        }

        public String ReceiverAddress
        {
            get;
            set;
        }

        public String ReceiverZip
        {
            get;
            set;
        }

        public String ReceiverPhone
        {
            get;
            set;
        }

        public String ReceiverMobile
        {
            get;
            set;
        }

        public String ReceiverEmail
        {
            get;
            set;
        }

        public String Price
        {
            get;
            set;
        }

        public String PromotionPrice
        {
            get;
            set;
        }

        public String PaymentType
        {
            get;
            set;
        }

        public String PaymentWay
        {
            get;
            set;
        }

        public String ShipmentType
        {
            get;
            set;
        }

        public String CodTime
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.create"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skus_info" ,this.SkusInfo);
            paramters.Add("buyer_name" ,this.BuyerName);
            paramters.Add("receiver_name" ,this.ReceiverName);
            paramters.Add("receiver_provinc" ,this.ReceiverProvinc);
            paramters.Add("receiver_city" ,this.ReceiverCity);
            paramters.Add("receiver_area" ,this.ReceiverArea);
            paramters.Add("receiver_address" ,this.ReceiverAddress);
            paramters.Add("receiver_zip" ,this.ReceiverZip);
            paramters.Add("receiver_phone" ,this.ReceiverPhone);
            paramters.Add("receiver_mobile" ,this.ReceiverMobile);
            paramters.Add("receiver_email" ,this.ReceiverEmail);
            paramters.Add("price" ,this.Price);
            paramters.Add("promotion_price" ,this.PromotionPrice);
            paramters.Add("payment_type" ,this.PaymentType);
            paramters.Add("payment_way" ,this.PaymentWay);
            paramters.Add("shipment_type" ,this.ShipmentType);
            paramters.Add("cod_time" ,this.CodTime);
        }

    }

}
