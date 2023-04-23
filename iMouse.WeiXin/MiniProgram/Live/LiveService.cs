using System;
using iMouse.WeiXin.MiniProgram.Live.Studio;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public class LiveService : ILiveService
    {

        /// <summary>
        /// 创建直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CreateRoomResponse?> CreateRoomAsync(CreateRoomRequest request)
        {
            return await ServiceInvoker.Request<CreateRoomResponse>(request);
        }

        /// <summary>
        /// 获取直播间列表和回放
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetLiveInfoResponse?> GetLiveInfoAsync(GetLiveInfoRequest request)
        {
            return await ServiceInvoker.Request<GetLiveInfoResponse>(request);
        }

        /// <summary>
        /// 删除直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteRoomResponse?> DeleteRoomAsync(DeleteRoomRequest request)
        {
            return await ServiceInvoker.Request<DeleteRoomResponse>(request);
        }

        /// <summary>
        /// 编辑直播间
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<EditRoomResponse?> EditRoomAsync(EditRoomRequest request)
        {
            return await ServiceInvoker.Request<EditRoomResponse>(request);
        }

        /// <summary>
        /// 获取直播间推流地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPushUrlResponse?> GetPushUrlAsync(GetPushUrlRequest request)
        {
            return await ServiceInvoker.Request<GetPushUrlResponse>(request);
        }

        /// <summary>
        /// 获取直播间分享二维码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetSharedCodeResponse?> GetSharedCodeAsync(GetSharedCodeRequest request)
        {
            return await ServiceInvoker.Request<GetSharedCodeResponse>(request);
        }

        /// <summary>
        /// 获取主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetSubAnchorResponse?> GetSubAnchorAsync(GetSubAnchorRequest request)
        {
            return await ServiceInvoker.Request<GetSubAnchorResponse>(request);
        }

        /// <summary>
        /// 修改主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ModifySubAnchorResponse?> ModifySubAnchorAsync(ModifySubAnchorRequest request)
        {
            return await ServiceInvoker.Request<ModifySubAnchorResponse>(request);
        }

        /// <summary>
        /// 删除主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteSubAnchorResponse?> DeleteSubAnchorAsync(DeleteSubAnchorRequest request)
        {
            return await ServiceInvoker.Request<DeleteSubAnchorResponse>(request);
        }

        /// <summary>
        /// 添加主播副号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddSubAnchorResponse?> AddSubAnchorAsync(AddSubAnchorRequest request)
        {
            return await ServiceInvoker.Request<AddSubAnchorResponse>(request);
        }

        /// <summary>
        /// 修改直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ModifyAssistantResponse?> ModifyAssistantAsync(ModifyAssistantRequest request)
        {
            return await ServiceInvoker.Request<ModifyAssistantResponse>(request);
        }

        /// <summary>
        /// 查询直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetAssistantListResponse?> GetAssistantListAsync(GetAssistantListRequest request)
        {
            return await ServiceInvoker.Request<GetAssistantListResponse>(request);
        }

        /// <summary>
        /// 删除直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RemoveAssistantResponse?> RemoveAssistantAsync(RemoveAssistantRequest request)
        {
            return await ServiceInvoker.Request<RemoveAssistantResponse>(request);
        }

        /// <summary>
        /// 添加管理直播间小助手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddAssistantResponse?> AddveAssistantAsync(AddAssistantRequest request)
        {
            return await ServiceInvoker.Request<AddAssistantResponse>(request);
        }

        /// <summary>
        /// 禁言管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateCommentResponse?> UpdateCommentAsync(UpdateCommentRequest request)
        {
            return await ServiceInvoker.Request<UpdateCommentResponse>(request);
        }

        /// <summary>
        /// 官方收录管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateFeedPublicResponse?> UpdateFeedPublicAsync(UpdateFeedPublicRequest request)
        {
            return await ServiceInvoker.Request<UpdateFeedPublicResponse>(request);
        }

        /// <summary>
        /// 客服功能管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateKFResponse?> UpdateKFAsync(UpdateKFRequest request)
        {
            return await ServiceInvoker.Request<UpdateKFResponse>(request);
        }

        /// <summary>
        /// 回放功能管理
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateReplayResponse?> UpdateReplayAsync(UpdateReplayRequest request)
        {
            return await ServiceInvoker.Request<UpdateReplayResponse>(request);
        }

        /// <summary>
        /// 下载商品讲解视频
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DownloadGoodsVideoResponse?> DownloadGoodsVideoAsync(DownloadGoodsVideoRequest request)
        {
            return await ServiceInvoker.Request<DownloadGoodsVideoResponse>(request);
        }

        /// <summary>
        /// 导入商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ImportGoodsResponse?> ImportGoodsAsync(ImportGoodsRequest request)
        {
            return await ServiceInvoker.Request<ImportGoodsResponse>(request);
        }

        /// <summary>
        /// 删除直播间商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteDoodsResponse?> DeleteDoodsAsync(DeleteDoodsRequest request)
        {
            return await ServiceInvoker.Request<DeleteDoodsResponse>(request);
        }

        /// <summary>
        /// 推送商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PushGoodsResponse?> PushGoodsAsync(PushGoodsRequest request)
        {
            return await ServiceInvoker.Request<PushGoodsResponse>(request);
        }

        /// <summary>
        /// 上下架商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SaleGoodsResponse?> SaleGoodsAsync(SaleGoodsRequest request)
        {
            return await ServiceInvoker.Request<SaleGoodsResponse>(request);
        }

        /// <summary>
        /// 直播间商品排序
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SortGoodsResponse?> SortGoodsAsync(SortGoodsRequest request)
        {
            return await ServiceInvoker.Request<SortGoodsResponse>(request);
        }
    }
}
