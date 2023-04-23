using System;
namespace iMouse.WeiXin.ApiInvoker
{

    public abstract class BaseTokenRequest : BaseRequest
    {
        /// <summary>
        /// 接口调用凭证 - access_token可通过getAccessToken接口获得；如果是第三方代调用请传入authorizer_access_token；
        /// </summary>
        [JsonIgnore]
        [QueryParamater("access_token")]
        public string AccessToken { get; set; } = string.Empty;

    }
}

