﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Zhijian.QTReportService
{
﻿    [Serializable]
    public class QTReportVO : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("qt_code")]
        public String QtCode
        {
            get;
            set;
        }

        [JsonProperty("qt_name")]
        public String QtName
        {
            get;
            set;
        }

        [JsonProperty("qt_type")]
        public Nullable<Int32> QtType
        {
            get;
            set;
        }

        [JsonProperty("qt_standard")]
        public String QtStandard
        {
            get;
            set;
        }

        [JsonProperty("is_passed")]
        public Nullable<Int32> IsPassed
        {
            get;
            set;
        }

        [JsonProperty("sp_name")]
        public String SpName
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("submit_time")]
        public String SubmitTime
        {
            get;
            set;
        }

        [JsonProperty("report_time")]
        public String ReportTime
        {
            get;
            set;
        }

        [JsonProperty("expiry_time")]
        public String ExpiryTime
        {
            get;
            set;
        }

        [JsonProperty("item_url")]
        public String ItemUrl
        {
            get;
            set;
        }

        [JsonProperty("item_desc")]
        public String ItemDesc
        {
            get;
            set;
        }

        [JsonProperty("report_url")]
        public String ReportUrl
        {
            get;
            set;
        }

        [JsonProperty("ext_attr")]
        public String ExtAttr
        {
            get;
            set;
        }

        [JsonProperty("num_iid")]
        public Nullable<Int32> NumIid
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

    }

}
