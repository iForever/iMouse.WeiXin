using System;
using System.Threading.Tasks;
using iMouse.WeiXin.ApiInvoker;

namespace iMouse.WeiXin.MiniProgram.User
{
    public class UserService : IUserService
    {

        /// <summary>
        /// 获取插件用户openpid - 通过 wx.pluginLogin 接口获得插件用户标志凭证 code 后传到开发者服务器，开发者服务器调用此接口换取插件用户的唯一标识 openpid
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPluginOpenPidResponse?> GetPluginOpenPidAsync(GetPluginOpenPidRequest request)
        {
            return await ServiceInvoker.Request<GetPluginOpenPidResponse>(request);
        }


        /// <summary>
        /// 检查加密信息 - 检查加密信息是否由微信生成（当前只支持手机号加密数据），只能检测最近3天生成的加密数据。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CheckEncryptedDataResponse?> CheckEncryptedDataAsync(CheckEncryptedDataRequest request)
        {
            return await ServiceInvoker.Request<CheckEncryptedDataResponse>(request);
        }


        /// <summary>
        /// 该接口用于在用户支付完成后，获调用本接口前需要用户完成支付，用户支付完成后，取该用户的 UnionId，无需用户授权。本接口支付后的五分钟内有效。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<GetPaidUnionIdResponse?> GetPaidUnionIdAsync(GetPaidUnionIdRequest request)
        {
            return await ServiceInvoker.Request<GetPaidUnionIdResponse>(request);
        }

        /// <summary>
        /// 该接口用于将 code 换取用户手机号。 说明，每个 code 只能使用一次，code的有效期为5min。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPhoneNumberResponse?> GetPhoneNumberAsync(GetPhoneNumberRequest request)
        {
            return await ServiceInvoker.Request<GetPhoneNumberResponse>(request);
        }
    }
}

