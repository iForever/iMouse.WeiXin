using System;
using System.Threading.Tasks;

namespace iMouse.WeiXin.Global.Credential
{
    public interface ICredentialService
    {
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="appName">app 名称</param>
        /// <param name="isForce">是否强制获取</param>
        /// <returns></returns>
        Task<GetAccessTokenResponse?> GetAccessTokenAsync(string appName, bool isForce = false);
    }
}

