using System;
namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public interface ISubscribeMessageService
    {
        /// <summary>
        /// 删除模板 - deleteMessageTemplate
        /// <para>
        /// 该接口用于删除帐号下的个人模板。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteMessageTemplateResponse?> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest request);

        /// <summary>
        /// 获取类目 - getCategory
        /// <para>
        /// 该接口用于获取小程序账号的类目。
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetCategoryResponse?> GetCategoryAsync(GetCategoryRequest request);

        /// <summary>
        /// 获取关键词列表 - getPubTemplateKeyWordsById
        /// <para>该接口用于获取模板标题下的关键词列表。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetPubTemplateKeyWordsByIdResponse?> GetGetPubTemplateKeyWordsByIdAsync(GetPubTemplateKeyWordsByIdRequest request);

        /// <summary>
        /// 获取所属类目下的公共模板 - getPubTemplateTitleList
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetPubTemplateTitleListResponse?> GetPubTemplateTitleListAsync(GetPubTemplateTitleListRequest request);

        /// <summary>
        /// 获取个人模板列表 - getTemplateList
        /// <para>该接口用于获取当前帐号下的个人模板列表。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetTemplateListResponse?> GetTemplateListAsync(GetTemplateListRequest request);

        /// <summary>
        /// 小程序发送订阅消息 - sendMessage
        /// <para>该接口用于发送订阅消息。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SendMessageResponse?> SendMessageAsync(SendMessageRequest request);

        /// <summary>
        /// 添加模板 - addMessageTemplate
        /// <para>该接口用于组合模板并添加至帐号下的个人模板库。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddMessageTemplateResponse?> AddMessageTemplateAsync(AddMessageTemplateRequest request);

        /// <summary>
        /// 公众号发送订阅消息 - sendMessage
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BizSendMessageResponse?> BizSendMessageAsync(BizSendMessageRequest request);
    }
}

