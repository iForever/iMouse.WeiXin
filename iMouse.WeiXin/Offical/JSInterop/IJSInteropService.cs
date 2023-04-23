using System;
using iMouse.WeiXin.Offical.JSInterop.Primitives;

namespace iMouse.WeiXin.Offical.JSInterop
{
    public interface IJSInteropService
    {
        /// <summary>
        /// 请求获得jsapi_ticket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetTicketResponse?> GetTicketAsync(string appName, bool isForce = false);

        /// <summary>
        /// 获取 JS-SDK 中 wx.config 所需的参数
        /// </summary>
        /// <param name="url">当前网页的URL</param>
        /// <returns></returns>
        Task<JsConfigParameters?> GetConfigParametersAsync(string appName, string url);
    }
}

