using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace Services.Engine
{
    public class HttpHelper
    {
        public async static Task<string> PostEmptyDataAndGetUrlResponseString(string url)
        {
            string result = string.Empty;
            await Task.Factory.StartNew(() =>
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    result = client.UploadString(url, string.Empty);
                }
                result = WebUtility.HtmlDecode(result);
            });
            return result;
        }
    }
}