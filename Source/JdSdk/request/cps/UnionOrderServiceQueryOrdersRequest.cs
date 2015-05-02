using System;
using System.Collections.Generic;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
    public class UnionOrderServiceQueryOrdersRequest : JdRequestBase<UnionOrderServiceQueryOrdersResponse>
    {
        public string Time { get; set; } 
        public long? PageIndex{get;set;} 
        public long? PageSize{get;set;}
        public string UnionId { get; set; }

        public override string ApiName
        {
            get { return "jingdong.UnionOrderService.queryOrders"; }
        }

        protected override void PrepareParam(IDictionary<string, object> paramters)
        {
            paramters.Add("time", Time);
            paramters.Add("pageIndex", PageIndex);
            paramters.Add("pageSize", PageSize);
            paramters.Add("unionId", UnionId);
        }
    }
}