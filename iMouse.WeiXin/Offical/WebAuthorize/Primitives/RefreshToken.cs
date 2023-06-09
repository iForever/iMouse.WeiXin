﻿using System;
namespace iMouse.WeiXin.Offical.WebAuthorize
{
    public class RefreshTokenRequest : BaseRequest
    {
        internal override string Endpoint => "/sns/oauth2/refresh_token";

        /// <summary>
        /// 公众号的唯一标识
        /// </summary>
        [QueryParamater("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取到到刷新令牌
        /// </summary>
        [QueryParamater("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;


        /// <summary>
        /// Grant Type (readonly)
        /// </summary>
        [QueryParamater("grant_type")]
        public string GrantType => "refresh_token";
    }

    public class RefreshTokenResponse : BaseResponse
    {
        /// <summary>
        /// 网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒）
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 用户刷新access_token
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;

        /// <summary>
        /// 用户唯一标识，请注意，在未关注公众号时，用户访问公众号的网页，也会产生一个用户和公众号唯一的OpenID
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 用户授权的作用域，使用逗号（,）分隔
        /// </summary>
        [JsonProperty("scope")]
        public string Scopes { get; set; } = string.Empty;
    }
}

