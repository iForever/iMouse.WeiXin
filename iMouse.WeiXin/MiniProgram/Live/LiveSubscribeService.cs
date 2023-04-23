using System;
using iMouse.WeiXin.MiniProgram.Live.Subscribe;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public class LiveSubscribeService : ILiveSubscribeService
    {
        /// <summary>
        /// 发送直播开始事件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PushMessageResponse?> PushMessageAsync(PushMessageRequest request)
        {
            return await ServiceInvoker.Request<PushMessageResponse>(request);
        }

        /// <summary>
        /// 获取长期订阅用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetFollowersResponse?> GetFollowersAsync(GetFollowersRequest request)
        {
            return await ServiceInvoker.Request<GetFollowersResponse>(request);
        }

    }
}

