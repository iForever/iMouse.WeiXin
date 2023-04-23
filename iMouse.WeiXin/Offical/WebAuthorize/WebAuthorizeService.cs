using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin.Offical.WebAuthorize
{
    public class WebAuthorizeService : IWebAuthorizeService
    {
        public WeiXinOptions Options { get; set; }

        public WebAuthorizeService(IOptions<WeiXinOptions> options)
        {
            Options = options.Value;
        }

        /// <summary>
        /// 获取网页授权引导URL
        /// </summary>
        /// <param name="redirectURI">授权后重定向的回调链接地址</param>
        /// <param name="scope">应用授权作用域</param>
        /// <param name="state">重定向后会带上 state 参数，开发者可以填写a-zA-Z0-9的参数值，最多128字节</param>
        /// <param name="forcePopup">强制此次授权需要用户弹窗确认；默认为false；需要注意的是，若用户命中了特殊场景下的静默授权逻辑，则此参数不生效</param>
        /// <param name="forceSnapShot">强制此次授权进入快照页；默认为false；需要注意的是，若本次登录命中了近期登录过免授权逻辑逻辑或特殊场景下的静默授权逻辑，则此参数不生效</param>
        /// <returns></returns>
        public string GetWebAuthorizeURL(
            string redirectURI,
            WebAuthorizeScope scope = WebAuthorizeScope.SNSApiBase,
            string state = "",
            bool forcePopup = false,
            bool forceSnapShot = false)
        {
            var request = new WebAuthorizeRequest
            {
                //AppId = Options.Offical?.AppId ?? "",
                RedirectURI = redirectURI,
                Scope = scope,
                State = state,
                ForcePopup = forcePopup,
                ForceSnapShot = forceSnapShot
            };
            return request.ApiURL;
        }

        /// <summary>
        /// 通过 code 换取网页授权access_token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Code2WebAccessTokenResponse?> Code2WebAccessTokenAsync(Code2WebAccessTokenRequest request)
        {
            return await ServiceInvoker.Request<Code2WebAccessTokenResponse>(request);
        }

        /// <summary>
        /// 刷新access_token
        /// <para>
        /// 由于access_token拥有较短的有效期，当access_token超时后，可以使用refresh_token进行刷新。<br />
        /// refresh_token有效期为30天，当refresh_token失效之后，需要用户重新授权。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RefreshTokenResponse?> RefreshTokenAsync(RefreshTokenRequest request)
        {
            return await ServiceInvoker.Request<RefreshTokenResponse>(request);
        }

        /// <summary>
        /// 拉取用户信息
        /// <para>如果网页授权作用域为snsapi_userinfo，则此时开发者可以通过access_token和 openid 拉取用户信息了。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetScopeUserInfoResponse?> GetScopeUserInfoAsync(GetScopeUserInfoRequest request)
        {
            return await ServiceInvoker.Request<GetScopeUserInfoResponse>(request);
        }

        /// <summary>
        /// 检验授权凭证（access_token）是否有效
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CheckWebAccessTokenResponse?> CheckWebAccessTokenAsync(CheckWebAccessTokenRequest request)
        {
            return await ServiceInvoker.Request<CheckWebAccessTokenResponse>(request);
        }
    }
}

