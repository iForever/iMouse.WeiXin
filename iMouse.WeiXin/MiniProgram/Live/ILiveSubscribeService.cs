using System;
using iMouse.WeiXin.MiniProgram.Live.Subscribe;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public interface ILiveSubscribeService
    {

        /// <summary>
        /// 发送直播开始事件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PushMessageResponse?> PushMessageAsync(PushMessageRequest request);

        /// <summary>
        /// 获取长期订阅用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetFollowersResponse?> GetFollowersAsync(GetFollowersRequest request);


    }
}

