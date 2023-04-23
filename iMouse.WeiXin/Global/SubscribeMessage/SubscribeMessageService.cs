using System;
namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class SubscribeMessageService : ISubscribeMessageService
    {
        /// <summary>
        /// 删除模板 - deleteMessageTemplate
        /// <para>
        /// 该接口用于删除帐号下的个人模板。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteMessageTemplateResponse?> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest request)
        {
            return await ServiceInvoker.Request<DeleteMessageTemplateResponse>(request);
        }

        /// <summary>
        /// 获取类目 - getCategory
        /// <para>
        /// 该接口用于获取小程序账号的类目。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetCategoryResponse?> GetCategoryAsync(GetCategoryRequest request)
        {
            return await ServiceInvoker.Request<GetCategoryResponse>(request);
        }

        /// <summary>
        /// 获取关键词列表 - getPubTemplateKeyWordsById
        /// <para>该接口用于获取模板标题下的关键词列表。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPubTemplateKeyWordsByIdResponse?> GetGetPubTemplateKeyWordsByIdAsync(GetPubTemplateKeyWordsByIdRequest request)
        {
            return await ServiceInvoker.Request<GetPubTemplateKeyWordsByIdResponse>(request);
        }

        /// <summary>
        /// 获取所属类目下的公共模板 - getPubTemplateTitleList
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPubTemplateTitleListResponse?> GetPubTemplateTitleListAsync(GetPubTemplateTitleListRequest request)
        {
            return await ServiceInvoker.Request<GetPubTemplateTitleListResponse>(request);
        }

        /// <summary>
        /// 获取个人模板列表 - getTemplateList
        /// <para>该接口用于获取当前帐号下的个人模板列表。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetTemplateListResponse?> GetTemplateListAsync(GetTemplateListRequest request)
        {
            return await ServiceInvoker.Request<GetTemplateListResponse>(request);
        }

        /// <summary>
        /// 发送订阅消息 - sendMessage
        /// <para>该接口用于发送订阅消息。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendMessageResponse?> SendMessageAsync(SendMessageRequest request)
        {
            return await ServiceInvoker.Request<SendMessageResponse>(request);
        }

        /// <summary>
        /// 添加模板 - addMessageTemplate
        /// <para>该接口用于组合模板并添加至帐号下的个人模板库。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddMessageTemplateResponse?> AddMessageTemplateAsync(AddMessageTemplateRequest request)
        {
            return await ServiceInvoker.Request<AddMessageTemplateResponse>(request);
        }

        /// <summary>
        /// 公众号发送订阅消息 - sendMessage
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BizSendMessageResponse?> BizSendMessageAsync(BizSendMessageRequest request)
        {
            return await ServiceInvoker.Request<BizSendMessageResponse>(request);
        }
    }
}

