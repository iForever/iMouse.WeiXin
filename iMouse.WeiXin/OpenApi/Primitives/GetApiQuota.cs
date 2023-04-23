using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.OpenApi
{
    public class GetApiQuotaRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => $"/cgi-bin/openapi/quota/get";

        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// 需查询的api的请求地址，例如"/cgi-bin/message/custom/send";
        /// 不要前缀“https://api.weixin.qq.com” ，也不要漏了"/",否则都会76003的报错
        /// </summary>
        [JsonProperty("cgi_path")]
        public string ApiPath { get; set; } = string.Empty;
    }


    public class GetApiQuotaResponse : BaseResponse
    {
        [JsonProperty("quota")]
        public ApiQuotaInfo? ApiQuota { get; set; }
    }

    public class ApiQuotaInfo
    {
        /// <summary>
        /// 当天该账号可调用该接口的次数
        /// </summary>
        [JsonProperty("daily_limit")]
        public int DailyLimit { get; set; }

        /// <summary>
        /// 当天已经调用的次数
        /// </summary>
        [JsonProperty("used")]
        public int Used { get; set; }

        /// <summary>
        /// 当天剩余调用次数
        /// </summary>
        [JsonProperty("remain")]
        public int Remain { get; set; }
    }
}

