using System;
using iMouse.WeiXin.MiniProgram.Security.Primitives;

namespace iMouse.WeiXin.MiniProgram.Security
{
    public class SecurityService : ISecurityService
    {
        /// <summary>
        /// 获取用户安全等级
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUserRiskRankResponse?> GetUserRiskRankAsync(GetUserRiskRankRequest request)
        {
            return await ServiceInvoker.Request<GetUserRiskRankResponse>(request);
        }

        /// <summary>
        /// 音视频内容安全识别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<MediaCheckAsyncResponse?> MediaCheckAsync(MediaCheckAsyncRequest request)
        {
            return await ServiceInvoker.Request<MediaCheckAsyncResponse>(request);
        }

        /// <summary>
        /// 文本内容安全识别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<MsgSecCheckResponse?> MsgSecCheckAsync(MsgSecCheckRequest request)
        {
            return await ServiceInvoker.Request<MsgSecCheckResponse>(request);
        }
    }
}

