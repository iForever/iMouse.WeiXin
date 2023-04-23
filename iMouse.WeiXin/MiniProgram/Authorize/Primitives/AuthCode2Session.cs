using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.MiniProgram.Authorize
{
    public class AuthCode2SessionRequest : BaseRequest
    {
        internal override string Endpoint => $"/sns/jscode2session";

        [QueryParamater("appid")]
        public string AppId { get; set; } = string.Empty;

        [QueryParamater("secret")]
        public string Secret { get; set; } = string.Empty;

        [QueryParamater("js_code")]
        public string JSCode { get; set; } = string.Empty;

        [QueryParamater("grant_type")]
        public string GrantType { get; } = "authorization_code";
    }


    public class AuthorizeCode2SessionResponse : BaseResponse
    {
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        [JsonProperty("session_key")]
        public string SessionKey { get; set; } = string.Empty;

        [JsonProperty("unionid")]
        public string UnionId { get; set; } = string.Empty;
    }
}
