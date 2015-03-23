using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
    public class UnionOrderServiceQueryOrdersResponse : JdResponse
    {
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("start")]
        public int Start { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("unionId")]
        public int UnionId { get; set; }
        [JsonProperty("success")]
        public int Success { get; set; }
        [JsonProperty("data")]
        public System.Collections.Generic.List<Order> Data { get; set; }
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }


        public class Order
        {
            [JsonProperty("subUnion")]
            public string SubUnion { get; set; }
            [JsonProperty("orderTime")]
            public string OrderTime { get; set; }
            [JsonProperty("orderId")]
            public string OrderId { get; set; }
            [JsonProperty("parentId")]
            public string ParentId { get; set; }
            [JsonProperty("popId")]
            public long PopId { get; set; }
            [JsonProperty("sourceEmt")]
            public long SourceEmt { get; set; }
            [JsonProperty("yn")]
            public long Yn { get; set; }
            [JsonProperty("SplitType")]
            public string SplitType { get; set; }
            [JsonProperty("totalMoney")]
            public decimal TotalMoney { get; set; }
            [JsonProperty("cosPrice")]
            public decimal CosPrice { get; set; }
            [JsonProperty("unionUserName")]
            public string UnionUserName { get; set; }
            [JsonProperty("details")]
            public System.Collections.Generic.List<OrderDetail> Details { get; set; }
        }

        public class OrderDetail
        {
            [JsonProperty("wareId")]
            public string WareId { get; set; }
            [JsonProperty("Quantity")]
            public int Quantity { get; set; }
            [JsonProperty("firstLevle")]
            public string FirstLevle { get; set; }
            [JsonProperty("secondLevel")]
            public string SecondLevel { get; set; }
            [JsonProperty("thirdLevle")]
            public string ThirdLevle { get; set; }
            [JsonProperty("totalPrice")]
            public decimal TotalPrice { get; set; }
        }
    }
}