using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iMouse.WeiXin.ApiInvoker;
using iMouse.WeiXin.Options;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin.OpenApi
{
    public class OpenApiService : IOpenApiService
    {
        public OpenApiService(IOptions<WeiXinOptions> options)
        {
            Options = options.Value;
        }

        public WeiXinOptions Options { get; }

        public async Task<ClearQuotaResponse?> ClearQuotaAsync(string accessToken)
        {
            var request = new ClearQuotaRequest
            {
                AccessToken = accessToken
            };

            return await ServiceInvoker.Request<ClearQuotaResponse>(request);
        }

        public async Task<GetApiQuotaResponse?> GetApiQuotaInfoAsync(string accessToken, string apiPath)
        {
            var request = new GetApiQuotaRequest
            {
                AccessToken = accessToken,
                ApiPath = apiPath
            };

            return await ServiceInvoker.Request<GetApiQuotaResponse>(request);
        }

        public async Task<GetRidInfoResponse?> GetRidInfoAsync(string accessToken, string rid)
        {
            var request = new GetRidInfoRequest
            {
                AccessToken = accessToken,
                Rid = rid
            };

            return await ServiceInvoker.Request<GetRidInfoResponse>(request);
        }
    }
}

