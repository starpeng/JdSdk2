using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
    public class ServicePromotionGetcodeResponse:JdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
         [JsonProperty("resultCode")]
        public string ResultCode { get; set; }
         [JsonProperty("resultMessage")]
        public string ResultMessage { get; set; }
         [JsonProperty("siteSize")]
        public string SiteSize { get; set; }
         [JsonProperty("siteSizeList")]
        public System.Collections.Generic.List<object> SiteSizeList { get; set; }
         [JsonProperty("url")]
        public string Url { get; set; }
    }
}