using System;
using System.Threading.Tasks;

namespace iMouse.WeiXin.OpenApi
{
    public interface IOpenApiService
    {
        Task<ClearQuotaResponse?> ClearQuotaAsync(string accessToken);
        Task<GetApiQuotaResponse?> GetApiQuotaInfoAsync(string accessToken, string apiPath);
        Task<GetRidInfoResponse?> GetRidInfoAsync(string accessToken, string rid);
    }
}

