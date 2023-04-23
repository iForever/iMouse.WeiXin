using System;
namespace iMouse.WeiXin.Offical.WebAuthorize
{
    public class CheckWebAccessTokenRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/sns/auth";

        [QueryParamater("openid")]
        public string OpenId { get; set; } = string.Empty;
    }

    public class CheckWebAccessTokenResponse : BaseResponse { }
}

