using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.OpenApi
{
    public class ClearQuotaRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => $"/cgi-bin/clear_quota";

        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// 要被清空的账号的appid
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;
    }

    public class ClearQuotaResponse : BaseResponse { }


}

