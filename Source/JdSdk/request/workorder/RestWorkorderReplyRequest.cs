﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Workorder;

namespace JdSdk.Request.Workorder
{
﻿    public class RestWorkorderReplyRequest : JdRequestBase<RestWorkorderReplyResponse>
    {
        public Nullable<Int64> WorkId
        {
            get;
            set;
        }

        public String ReplyContent
        {
            get;
            set;
        }

        public Nullable<Int64> WorkType
        {
            get;
            set;
        }

        public Nullable<Int64> Work2Type
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.rest.workorder.reply"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("work_id" ,this.WorkId);
            paramters.Add("reply_content" ,this.ReplyContent);
            paramters.Add("work_type" ,this.WorkType);
            paramters.Add("work2_type" ,this.Work2Type);
        }

    }

}
