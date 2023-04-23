using System;
using iMouse.WeiXin.MiniProgram.Security.Primitives;

namespace iMouse.WeiXin.MiniProgram.Security
{
    public interface ISecurityService
    {
        /// <summary>
        /// 获取用户安全等级
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetUserRiskRankResponse?> GetUserRiskRankAsync(GetUserRiskRankRequest request);

        /// <summary>
        /// 音视频内容安全识别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MediaCheckAsyncResponse?> MediaCheckAsync(MediaCheckAsyncRequest request);

        /// <summary>
        /// 文本内容安全识别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MsgSecCheckResponse?> MsgSecCheckAsync(MsgSecCheckRequest request);
    }
}

