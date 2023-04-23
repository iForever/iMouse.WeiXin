using System;
using System.Threading.Tasks;
using iMouse.WeiXin.Models;

namespace iMouse.WeiXin.MiniProgram.Authorize
{
    /// <summary>
    /// 小程序授权验证服务
    /// </summary>
    public interface IAuthorizeService
    {
        /// <summary>
        /// auth.code2Session <br />
        /// 登录凭证校验。通过 wx.login 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程。
        /// </summary>
        /// <param name="jsCode"></param>
        /// <returns></returns>
        Task<AuthorizeCode2SessionResponse?> Code2Session(string appName, string jsCode);

        /// <summary>
        /// GetUserSummary
        /// </summary>
        /// <param name="session"></param>
        /// <param name="encryptedData"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        Task<UserSummaryInfo?> GetUserSummary(UserSessionInfo session, string encryptedData, string iv);

        /// <summary>
        /// GetPhoneNumber
        /// </summary>
        /// <param name="session"></param>
        /// <param name="encryptedData"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        Task<PhoneNumberInfo?> GetPhoneNumber(UserSessionInfo session, string encryptedData, string iv);
    }
}
