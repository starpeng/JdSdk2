﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class PlanDetailInfo : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("space_id")]
        public Nullable<Int64> SpaceId
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("budget")]
        public Nullable<Decimal> Budget
        {
            get;
            set;
        }

        [JsonProperty("total_budget")]
        public Nullable<Decimal> TotalBudget
        {
            get;
            set;
        }

        [JsonProperty("mode")]
        public Nullable<Int32> Mode
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

        [JsonProperty("allow_split")]
        public Nullable<Int32> AllowSplit
        {
            get;
            set;
        }

        [JsonProperty("schedule_start")]
        public String ScheduleStart
        {
            get;
            set;
        }

        [JsonProperty("schedule_end")]
        public String ScheduleEnd
        {
            get;
            set;
        }

        [JsonProperty("insert_time")]
        public String InsertTime
        {
            get;
            set;
        }

        [JsonProperty("update_time")]
        public String UpdateTime
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

        [JsonProperty("show_day")]
        public String[] ShowDay
        {
            get;
            set;
        }

        [JsonProperty("show_type")]
        public Nullable<Int32> ShowType
        {
            get;
            set;
        }

        [JsonProperty("material_list")]
        public List<CommodityInfo> MaterialList
        {
            get;
            set;
        }

        [JsonProperty("keyword_list")]
        public List<SelectedKeywordInfo> KeywordList
        {
            get;
            set;
        }

        [JsonProperty("space_page_vo")]
        public SpacePageInfo SpacePageVo
        {
            get;
            set;
        }

        [JsonProperty("space_vo")]
        public SpaceInfo SpaceVo
        {
            get;
            set;
        }

    }

}
