using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.Global.Credential
{
    public class GetAccessTokenRequest : BaseRequest
    {
        internal override string Endpoint => $"/cgi-bin/token";
        internal override HttpMethod RequestMethod => HttpMethod.Get;

        [QueryParamater("appid")]
        public string AppId { get; set; } = string.Empty;

        [QueryParamater("secret")]
        public string Secret { get; set; } = string.Empty;

        [QueryParamater("grant_type")]
        public string GrantType { get; } = "client_credential";
    }

    public class GetAccessTokenResponse : BaseResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; } = string.Empty;

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("createAt")]
        public DateTime CreateAt { get; } = DateTime.Now;

        [JsonIgnore]
        public bool IsExpired => (CreateAt.AddSeconds(ExpiresIn) < DateTime.Now);
    }
}

