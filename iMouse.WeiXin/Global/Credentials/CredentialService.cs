using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using iMouse.WeiXin.ApiInvoker;
using iMouse.WeiXin.Options;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin.Global.Credential
{
    public class CredentialService : ICredentialService
    {
        public CredentialService(IOptions<WeiXinOptions> options, ICacheProvider cacheProvider)
        {
            Options = options.Value;
            CacheProvider = cacheProvider;
        }

        public WeiXinOptions Options { get; }
        public ICacheProvider CacheProvider { get; }

        private string GetAccessTokenCacheKey(string appName) => $"AccessTokenKey-{appName}";

        /// <summary>
        /// 设置微信接口访问AccessToken
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="accessTokenInfo"></param>
        /// <returns></returns>
        public async Task SetAccessTokenAsync(string appName, GetAccessTokenResponse accessTokenInfo)
        {
            var accessTokenCacheKey = GetAccessTokenCacheKey(appName);
            await CacheProvider.SetEntryAsync(appName, accessTokenCacheKey, accessTokenInfo);
        }

        /// <summary>
        /// 获取微信接口访问AccessToken
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="isForce"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public async Task<GetAccessTokenResponse?> GetAccessTokenAsync(string appName, bool isForce = false)
        {
            var option = Options.Apps?.FirstOrDefault(x => x.Name.Equals(appName));
            if (option == null)
            {
                throw new KeyNotFoundException($"App name ({appName}) does not found in WeiXinOptions settings.");
            }

            var accessTokenCacheKey = GetAccessTokenCacheKey(appName);
            GetAccessTokenResponse? response = null;
            if (!isForce)
            {
                response = await CacheProvider.GetEntryAsync<GetAccessTokenResponse>(appName, accessTokenCacheKey);
            }

            if (response == null || response.IsExpired)
            {
                var request = new GetAccessTokenRequest()
                {
                    AppId = option.AppId,
                    Secret = option.AppSecret
                };
                response = await ServiceInvoker.Request<GetAccessTokenResponse>(request);
                await CacheProvider.SetEntryAsync(appName, accessTokenCacheKey, response);
            }

            return response;
        }
    }
}

