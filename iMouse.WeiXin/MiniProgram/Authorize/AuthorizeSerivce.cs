using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iMouse.WeiXin.ApiInvoker;
using iMouse.WeiXin.Models;
using iMouse.WeiXin.Options;
using iMouse.WeiXin.Utilities;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin.MiniProgram.Authorize
{
    public class AuthorizeSerivce : IAuthorizeService
    {
        public WeiXinOptions Options { get; }

        public AuthorizeSerivce(IOptions<WeiXinOptions> options)
        {
            Options = options.Value;
        }

        public async Task<AuthorizeCode2SessionResponse?> Code2Session(string appName, string jsCode)
        {
            var option = Options.Apps?.FirstOrDefault(x => x.Name.Equals(appName));
            if (option == null)
            {
                throw new KeyNotFoundException($"App name ({appName}) does not found in WeiXinOptions settings.");
            }

            var request = new AuthCode2SessionRequest
            {
                AppName = appName,
                AppId = option.AppId ?? "",
                Secret = option.AppSecret ?? "",
                JSCode = jsCode
            };

            return await ServiceInvoker.Request<AuthorizeCode2SessionResponse>(request);
        }

        public async Task<UserSummaryInfo?> GetUserSummary(UserSessionInfo session, string encryptedData, string iv)
        {
            if (session == null || string.IsNullOrWhiteSpace(session.SessionKey))
            {
                return null;
            }

            var wxUser = SecurityHelper.AESDecrypt<UserSummaryInfo>(encryptedData, session.SessionKey, iv);
            return await Task.FromResult(wxUser);
        }

        public async Task<PhoneNumberInfo?> GetPhoneNumber(UserSessionInfo session, string encryptedData, string iv)
        {
            if (session == null || string.IsNullOrWhiteSpace(session.SessionKey))
            {
                return null;
            }

            var wxUser = SecurityHelper.AESDecrypt<PhoneNumberInfo>(encryptedData, session.SessionKey, iv);
            return await Task.FromResult(wxUser);
        }
    }
}
