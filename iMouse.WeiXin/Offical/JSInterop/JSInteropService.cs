using System;
using System.Threading;
using iMouse.WeiXin.Offical.JSInterop.Primitives;

namespace iMouse.WeiXin.Offical.JSInterop
{
    public class JSInteropService : IJSInteropService
    {
        private static readonly Mutex mMutex = new Mutex();

        public ICacheProvider CacheProvider { get; }

        public JSInteropService(ICacheProvider cacheProvider)
        {
            CacheProvider = cacheProvider;
        }

        public async Task<GetTicketResponse?> GetTicketAsync(string appName, bool isForce = false)
        {
            var ticketCacheKey = $"TicketKey-{appName}";
            GetTicketResponse? response = null;
            if (!isForce)
            {
                response = await CacheProvider.GetEntryAsync<GetTicketResponse>(appName, ticketCacheKey);
            }

            if (response == null || response.IsExpired)
            {
                mMutex.WaitOne();
                try
                {
                    if (!isForce)
                    {
                        // 再次从缓存中读取数据
                        response = await CacheProvider.GetEntryAsync<GetTicketResponse>(appName, ticketCacheKey);
                        if (response != null && !response.IsExpired)
                        {
                            return response;
                        }
                    }

                    var request = new GetTicketRequest
                    {
                        AppName = appName
                    };
                    response = await ServiceInvoker.Request<GetTicketResponse>(request);
                    await CacheProvider.SetEntryAsync(appName, ticketCacheKey, response);
                }
                finally
                {
                    //确保释放互斥量
                    mMutex.ReleaseMutex();
                }
            }

            return response;
        }

        public async Task<JsConfigParameters?> GetConfigParametersAsync(string appName, string url)
        {
            var ticket = await GetTicketAsync(appName);
            if (ticket == null)
            {
                return default;
            }

            var result = new JsConfigParameters(url);
            var sortedSets = result.GetSortedKeyValues();
            sortedSets.Add($"jsapi_ticket={ticket?.Ticket}");
            result.Signature = WeiXinHelper.Sha1Hash(sortedSets);

            return result;
        }
    }
}

