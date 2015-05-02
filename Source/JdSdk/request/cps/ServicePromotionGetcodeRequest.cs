using System.Collections.Generic;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
    public class ServicePromotionGetcodeRequest : JdRequestBase<ServicePromotionGetcodeResponse>
    {
        public int PromotionType { get; set; }
        public string MaterialId { get; set; }
        public int UnionId { get; set; }
        public string SubUnionId { get; set; }
        public string SiteSize { get; set; }
        public string SiteId { get; set; }
        public string Channel { get; set; }
        public string WebId { get; set; }
        public string ExtendId { get; set; }
        public string Ext1 { get; set; }
         
        public override string ApiName
        {
            get { return "jingdong.service.promotion.getcode"; }
        }

        protected override void PrepareParam(IDictionary<string, object> paramters)
        {
            paramters.Add("promotionType", PromotionType);
            paramters.Add("materialId", MaterialId);
            paramters.Add("unionId", UnionId);
            paramters.Add("subUnionId", SubUnionId);
            paramters.Add("siteSize", SiteSize);
            paramters.Add("siteId", SiteId);
            paramters.Add("channel", Channel);
            paramters.Add("webId", WebId);
            paramters.Add("extendId", ExtendId);
            paramters.Add("ext1", Ext1);
        }
    }
}