using System;
namespace iMouse.WeiXin.Cache
{
    public interface ICacheProvider
    {
        Task<T?> GetEntryAsync<T>(string appName, string key);

        Task SetEntryAsync<T>(string appName, string key, T entity);

        Task RemoveAsync(string appName, string key);

        Task RefreshAsync(string appName, string key);
    }
}

