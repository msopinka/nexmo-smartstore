using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Engine.Nexmo
{
    public class NexmoVerifyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("error_text")]
        public string ErrorText { get; set; }
    }

    public class NexmoCheckResponse
    {
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("error_text")]
        public string ErrorText { get; set; }
    }
}
