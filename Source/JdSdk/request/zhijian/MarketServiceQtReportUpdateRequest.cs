﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Zhijian;

namespace JdSdk.Request.Zhijian
{
﻿    public class MarketServiceQtReportUpdateRequest : JdRequestBase<MarketServiceQtReportUpdateResponse>
    {
        public String ServiceItemCode
        {
            get;
            set;
        }

        public String QtCode
        {
            get;
            set;
        }

        public String QtName
        {
            get;
            set;
        }

        public Nullable<Int32> QtType
        {
            get;
            set;
        }

        public String QtStandard
        {
            get;
            set;
        }

        public Nullable<Int32> IsPassed
        {
            get;
            set;
        }

        public String SpName
        {
            get;
            set;
        }

        public String Message
        {
            get;
            set;
        }

        public String SubmitTime
        {
            get;
            set;
        }

        public String ReportTime
        {
            get;
            set;
        }

        public String ExpiryTime
        {
            get;
            set;
        }

        public String ItemUrl
        {
            get;
            set;
        }

        public String ItemDesc
        {
            get;
            set;
        }

        public String ReportUrl
        {
            get;
            set;
        }

        public String ExtAttr
        {
            get;
            set;
        }

        public Nullable<Int32> NumIid
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public String Pin
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.market.service.qt.report.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("service_item_code" ,this.ServiceItemCode);
            paramters.Add("qt_code" ,this.QtCode);
            paramters.Add("qt_name" ,this.QtName);
            paramters.Add("qt_type" ,this.QtType);
            paramters.Add("qt_standard" ,this.QtStandard);
            paramters.Add("is_passed" ,this.IsPassed);
            paramters.Add("sp_name" ,this.SpName);
            paramters.Add("message" ,this.Message);
            paramters.Add("submit_time" ,this.SubmitTime);
            paramters.Add("report_time" ,this.ReportTime);
            paramters.Add("expiry_time" ,this.ExpiryTime);
            paramters.Add("item_url" ,this.ItemUrl);
            paramters.Add("item_desc" ,this.ItemDesc);
            paramters.Add("report_url" ,this.ReportUrl);
            paramters.Add("ext_attr" ,this.ExtAttr);
            paramters.Add("num_iid" ,this.NumIid);
            paramters.Add("status" ,this.Status);
            paramters.Add("pin" ,this.Pin);
        }

    }

}
