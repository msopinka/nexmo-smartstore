using Newtonsoft.Json;
using Services.Engine;
using Services.Engine.Nexmo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Services.Controllers
{
    public class NexmoApiController : ApiController
    {
        private string NEXMO_KEY = "";
        private string NEXMO_SECRET = "";
		private string NEXMO_BRAND = "";

        [HttpGet]
        public async Task<NexmoVerifyResponse> Verify(string phone)
        {
            var rsp = new NexmoVerifyResponse();
            try
            {
                string url = string.Format("https://api.nexmo.com/verify/json?api_key={0}&api_secret={1}&number={2}&brand={3}", NEXMO_KEY, NEXMO_SECRET, phone, NEXMO_BRAND);
                string json = await HttpHelper.PostEmptyDataAndGetUrlResponseString(url);
                rsp = JsonConvert.DeserializeObject<NexmoVerifyResponse>(json);
            }
            catch (Exception ex)
            {
            }
            return rsp;
        }

        [HttpGet]
        public async Task<NexmoCheckResponse> Check(string requestId, string code)
        {
            var rsp = new NexmoCheckResponse();
            try
            {
                string url = string.Format("https://api.nexmo.com/verify/check/json?api_key={0}&api_secret={1}&request_id={2}&code={3}", NEXMO_KEY, NEXMO_SECRET, requestId, code);
                string json = await HttpHelper.PostEmptyDataAndGetUrlResponseString(url);
                rsp = JsonConvert.DeserializeObject<NexmoCheckResponse>(json);
            }
            catch (Exception ex)
            {
            }
            return rsp;
        }
    }
}
