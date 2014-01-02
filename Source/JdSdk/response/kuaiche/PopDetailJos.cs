﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class PopDetailJos : JdObject
    {
        [JsonProperty("result_code")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("result_description")]
        public String ResultDescription
        {
            get;
            set;
        }

        [JsonProperty("vender_name")]
        public String VenderName
        {
            get;
            set;
        }

        [JsonProperty("vender_contact")]
        public String VenderContact
        {
            get;
            set;
        }

        [JsonProperty("vender_tel")]
        public String VenderTel
        {
            get;
            set;
        }

        [JsonProperty("vender_fax")]
        public String VenderFax
        {
            get;
            set;
        }

        [JsonProperty("vender_qq")]
        public String VenderQq
        {
            get;
            set;
        }

        [JsonProperty("vender_msn")]
        public String VenderMsn
        {
            get;
            set;
        }

        [JsonProperty("vender_email")]
        public String VenderEmail
        {
            get;
            set;
        }

        [JsonProperty("vender_areacode")]
        public String VenderAreacode
        {
            get;
            set;
        }

        [JsonProperty("vender_street")]
        public String VenderStreet
        {
            get;
            set;
        }

        [JsonProperty("vender_cellphone")]
        public String VenderCellphone
        {
            get;
            set;
        }

    }

}
