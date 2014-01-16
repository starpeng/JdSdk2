﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class PartReceiveOut : JdObject
    {
        [JsonProperty("receivePin")]
        public String ReceivePin
        {
            get;
            set;
        }

        [JsonProperty("receiveName")]
        public String ReceiveName
        {
            get;
            set;
        }

        [JsonProperty("partReceiveId")]
        public Nullable<Int32> PartReceiveId
        {
            get;
            set;
        }

        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("waybill")]
        public String Waybill
        {
            get;
            set;
        }

        [JsonProperty("receiveJudgment")]
        public Nullable<Int32> ReceiveJudgment
        {
            get;
            set;
        }

        [JsonProperty("partQuality")]
        public Nullable<Int32> PartQuality
        {
            get;
            set;
        }

        [JsonProperty("wareId")]
        public Nullable<Int32> WareId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("wareSn")]
        public String WareSn
        {
            get;
            set;
        }

        [JsonProperty("wareAttachment")]
        public String WareAttachment
        {
            get;
            set;
        }

        [JsonProperty("partAppearance")]
        public Nullable<Int32> PartAppearance
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        [JsonProperty("createName")]
        public String CreateName
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

    }

}
