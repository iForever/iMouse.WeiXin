using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.OpenApi
{
    public class GetRidInfoRequest : BaseTokenRequest
    {
        internal override string Endpoint => $"/cgi-bin/openapi/rid/get";
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// 调用接口报错返回的rid
        /// </summary>
        [JsonProperty("rid")]
        public string Rid { get; set; } = string.Empty;
    }


    public class GetRidInfoResponse : BaseResponse
    {
        /// <summary>
        /// 该 rid 对应的请求详情
        /// </summary>
        [JsonProperty("request")]
        public RidRequestInfo? RidRequest { get; set; }
    }

    public class RidRequestInfo
    {
        /// <summary>
        /// 发起请求的时间戳
        /// </summary>
        [JsonProperty("invoke_time")]
        public long InvokeTime { get; set; }

        /// <summary>
        /// 请求毫秒级耗时
        /// </summary>
        [JsonProperty("cost_in_ms")]
        public int cost_in_ms { get; set; }

        /// <summary>
        /// 请求的 URL 参数
        /// </summary>
        [JsonProperty("request_url")]
        public string request_url { get; set; } = string.Empty;

        /// <summary>
        /// post请求的请求参数
        /// </summary>
        [JsonProperty("request_body")]
        public string request_body { get; set; } = string.Empty;

        /// <summary>
        /// 接口请求返回参数
        /// </summary>
        [JsonProperty("response_body")]
        public string response_body { get; set; } = string.Empty;

        /// <summary>
        /// 接口请求的客户端ip
        /// </summary>
        [JsonProperty("client_ip")]
        public string client_ip { get; set; } = string.Empty;
    }
}

