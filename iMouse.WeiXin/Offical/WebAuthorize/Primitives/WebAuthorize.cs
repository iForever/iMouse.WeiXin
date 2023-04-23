using System;
using System.Net;
using Newtonsoft.Json.Converters;

namespace iMouse.WeiXin.Offical.WebAuthorize
{
    public class WebAuthorizeRequest : BaseRequest
    {
        internal override string ApiHost => "https://open.weixin.qq.com";

        internal override string Endpoint => "/connect/oauth2/authorize";

        internal override string Fragment => "#wechat_redirect";

        private string mRedirectURI = string.Empty;

        /// <summary>
        /// 公众号的唯一标识
        /// </summary>
        [QueryParamater("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 授权后重定向的回调链接地址
        /// </summary>
        public string RedirectURI { get; set; } = string.Empty;

        /// <summary>
        /// UrlEncode后的重定向的回调链接地址
        /// </summary>
        [QueryParamater("redirect_uri")]
        public string RedirectURIEncoded => WebUtility.UrlEncode(RedirectURI) ?? string.Empty;


        /// <summary>
        /// 返回类型
        /// </summary>
        [QueryParamater("response_type")]
        public string ResponseType { get; } = "code";

        /// <summary>
        /// 应用授权作用域
        /// <para>
        /// snsapi_base （不弹出授权页面，直接跳转，只能获取用户openid) <br />
        /// snsapi_userinfo （弹出授权页面，可通过 openid 拿到昵称、性别、所在地。即使在未关注的情况下，只要用户授权，也能获取其信息 ）
        /// </para>
        /// </summary>
        [QueryParamater("scope")]
        public WebAuthorizeScope Scope { get; set; } = WebAuthorizeScope.SNSApiBase;

        /// <summary>
        /// 重定向后会带上 state 参数，开发者可以填写a-zA-Z0-9的参数值，最多128字节
        /// </summary>
        [QueryParamater("state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// 强制此次授权需要用户弹窗确认；默认为false；需要注意的是，若用户命中了特殊场景下的静默授权逻辑，则此参数不生效
        /// </summary>
        [QueryParamater("forcePopup")]
        public bool ForcePopup { get; set; } = false;


        /// <summary>
        /// 强制此次授权进入快照页；默认为false；需要注意的是，若本次登录命中了近期登录过免授权逻辑逻辑或特殊场景下的静默授权逻辑，则此参数不生效
        /// </summary>
        [QueryParamater("forceSnapShot")]
        public bool ForceSnapShot { get; set; } = false;
    }

    public enum WebAuthorizeScope
    {
        /// <summary>
        /// 不弹出授权页面，直接跳转，只能获取用户openid
        /// </summary>
        [QueryParamaterValue("snsapi_base")]
        SNSApiBase,

        /// <summary>
        /// 弹出授权页面，可通过 openid 拿到昵称、性别、所在地。 即使在未关注的情况下，只要用户授权，也能获取其信息
        /// </summary>
        [QueryParamaterValue("snsapi_userinfo")]
        SNSApiUserInfo
    }
}

