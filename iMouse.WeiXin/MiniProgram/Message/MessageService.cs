using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iMouse.WeiXin.MiniProgram.Message.ActivityMessage;
using iMouse.WeiXin.MiniProgram.Message.UniformMessage;
using Microsoft.Extensions.Options;

namespace iMouse.WeiXin.MiniProgram.Message
{
    public class MessageService : IMessageService
    {

        /// <summary>
        /// 下发统一消息
        /// <para>
        /// 该接口用于下发小程序和公众号统一的服务消息
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendUniformMessageResponse?> SendUniformMessageAsync(SendUniformMessageRequest request)
        {
            return await ServiceInvoker.Request<SendUniformMessageResponse>(request);
        }

        /// <summary>
        /// 创建activity_id - createActivityId
        /// <para>
        /// 该接口用于创建被分享动态消息或私密消息的 activity_id。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CreateActivityIdResponse?> CreateActivityIdAsync(CreateActivityIdRequest request)
        {
            return await ServiceInvoker.Request<CreateActivityIdResponse>(request);
        }

        /// <summary>
        /// 修改动态消息 - setUpdatableMsg
        /// <para>
        /// 该接口用于修改被分享的动态消息。
        /// 详见：<see cref="https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-message-management/updatable-message/setUpdatableMsg.html"/>
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SetUpdatableMessageResponse?> SetUpdatableMessageAsync(SetUpdatableMessageRequest request)
        {
            return await ServiceInvoker.Request<SetUpdatableMessageResponse>(request);
        }



    }
}

