using System;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin
{
    internal static class ServiceProvider
    {
        /// <summary>
        /// 根服务
        /// </summary>
        internal static IServiceProvider? RootServices;

        public static T? GetService<T>() where T : class
        {
            return RootServices?.GetService(typeof(T)) as T;
        }

        public static T? GetOptions<T>() where T : class
        {
            return GetService<IOptions<T>>()?.Value;
        }
    }
}

