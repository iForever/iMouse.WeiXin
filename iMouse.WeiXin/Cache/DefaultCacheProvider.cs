using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Microsoft.Extensions.Caching.Distributed;

namespace iMouse.WeiXin.Cache
{
    public class DefaultCacheProvider : ICacheProvider
    {

        public DefaultCacheProvider(IDistributedCache distributedCache)
        {
            DistributedCache = distributedCache;
        }

        public IDistributedCache DistributedCache { get; }


        public async Task<T?> GetEntryAsync<T>(string appName, string key)
        {
            var bytes = await DistributedCache.GetAsync(key);
            if (bytes != null)
            {
                return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(bytes));
            }
            return default;
        }

        public async Task RefreshAsync(string appName, string key)
        {
            await DistributedCache.RefreshAsync(key);
        }

        public async Task RemoveAsync(string appName, string key)
        {
            await DistributedCache.RemoveAsync(key);
        }

        public async Task SetEntryAsync<T>(string appName, string key, T entity)
        {
            var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(entity));
            await DistributedCache.SetAsync(key, bytes);
        }

    }
}

