using System;
using iMouse.WeiXin.MiniProgram.Live.Studio;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public interface ILiveService
    {
        /// <summary>
        /// 创建直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateRoomResponse?> CreateRoomAsync(CreateRoomRequest request);

        /// <summary>
        /// 获取直播间列表和回放
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetLiveInfoResponse?> GetLiveInfoAsync(GetLiveInfoRequest request);

        /// <summary>
        /// 删除直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteRoomResponse?> DeleteRoomAsync(DeleteRoomRequest request);

        /// <summary>
        /// 编辑直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<EditRoomResponse?> EditRoomAsync(EditRoomRequest request);

        /// <summary>
        /// 获取直播间推流地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetPushUrlResponse?> GetPushUrlAsync(GetPushUrlRequest request);

        /// <summary>
        /// 获取直播间分享二维码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetSharedCodeResponse?> GetSharedCodeAsync(GetSharedCodeRequest request);

        /// <summary>
        /// 获取主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetSubAnchorResponse?> GetSubAnchorAsync(GetSubAnchorRequest request);

        /// <summary>
        /// 修改主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ModifySubAnchorResponse?> ModifySubAnchorAsync(ModifySubAnchorRequest request);

        /// <summary>
        /// 删除主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteSubAnchorResponse?> DeleteSubAnchorAsync(DeleteSubAnchorRequest request);

        /// <summary>
        /// 添加主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddSubAnchorResponse?> AddSubAnchorAsync(AddSubAnchorRequest request);

        /// <summary>
        /// 修改直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ModifyAssistantResponse?> ModifyAssistantAsync(ModifyAssistantRequest request);

        /// <summary>
        /// 查询直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetAssistantListResponse?> GetAssistantListAsync(GetAssistantListRequest request);

        /// <summary>
        /// 删除直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<RemoveAssistantResponse?> RemoveAssistantAsync(RemoveAssistantRequest request);

        /// <summary>
        /// 添加管理直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddAssistantResponse?> AddveAssistantAsync(AddAssistantRequest request);

        /// <summary>
        /// 禁言管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateCommentResponse?> UpdateCommentAsync(UpdateCommentRequest request);

        /// <summary>
        /// 官方收录管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateFeedPublicResponse?> UpdateFeedPublicAsync(UpdateFeedPublicRequest request);

        /// <summary>
        /// 客服功能管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateKFResponse?> UpdateKFAsync(UpdateKFRequest request);

        /// <summary>
        /// 回放功能管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateReplayResponse?> UpdateReplayAsync(UpdateReplayRequest request);

        /// <summary>
        /// 下载商品讲解视频
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DownloadGoodsVideoResponse?> DownloadGoodsVideoAsync(DownloadGoodsVideoRequest request);

        /// <summary>
        /// 导入商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ImportGoodsResponse?> ImportGoodsAsync(ImportGoodsRequest request);

        /// <summary>
        /// 删除直播间商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteDoodsResponse?> DeleteDoodsAsync(DeleteDoodsRequest request);


        /// <summary>
        /// 推送商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PushGoodsResponse?> PushGoodsAsync(PushGoodsRequest request);


        /// <summary>
        /// 上下架商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SaleGoodsResponse?> SaleGoodsAsync(SaleGoodsRequest request);

        /// <summary>
        /// 直播间商品排序
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SortGoodsResponse?> SortGoodsAsync(SortGoodsRequest request);










    }
}

