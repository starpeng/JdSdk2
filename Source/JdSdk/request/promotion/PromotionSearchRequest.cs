﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Promotion;

namespace JdSdk.Request.Promotion
{
﻿    public class PromotionSearchRequest : JdRequestBase<PromotionSearchResponse>
    {
        public String EvtId
        {
            get;
            set;
        }

        public String TimeBeginStart
        {
            get;
            set;
        }

        public String TimeBeginEnd
        {
            get;
            set;
        }

        public String TimeEndStart
        {
            get;
            set;
        }

        public String TimeEndEnd
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String LevelMember
        {
            get;
            set;
        }

        public String EvtType
        {
            get;
            set;
        }

        public String EvtStatus
        {
            get;
            set;
        }

        public String CheckStatus
        {
            get;
            set;
        }

        public String Page
        {
            get;
            set;
        }

        public String PageSize
        {
            get;
            set;
        }

        public String SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.promotion.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("evt_id" ,this.EvtId);
            paramters.Add("time_begin_start" ,this.TimeBeginStart);
            paramters.Add("time_begin_end" ,this.TimeBeginEnd);
            paramters.Add("time_end_start" ,this.TimeEndStart);
            paramters.Add("time_end_end" ,this.TimeEndEnd);
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("level_member" ,this.LevelMember);
            paramters.Add("evt_type" ,this.EvtType);
            paramters.Add("evt_status" ,this.EvtStatus);
            paramters.Add("check_status" ,this.CheckStatus);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("sku_id" ,this.SkuId);
        }

    }

}
