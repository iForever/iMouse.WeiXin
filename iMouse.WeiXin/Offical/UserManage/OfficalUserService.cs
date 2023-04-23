using System;
namespace iMouse.WeiXin.Offical.UserManage
{
    using BlackList;
    using UserInfo;
    using UserTags;

    /// <summary>
    /// 公众号用户管理服务
    /// </summary>
    public class OfficalUserService : IOfficalUserService
    {

        #region 用户标签管理

        /// <summary>
        /// 创建标签
        /// <para>一个公众号，最多可以创建100个标签。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CreateTagResponse?> CreateTagAsync(CreateTagRequest request)
        {
            return await ServiceInvoker.Request<CreateTagResponse>(request);
        }

        /// <summary>
        /// 获取公众号已创建的标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetTagsResponse?> GetTagsAsync(GetTagsRequest request)
        {
            return await ServiceInvoker.Request<GetTagsResponse>(request);
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateTagResponse?> UpdateTagAsync(UpdateTagRequest request)
        {
            return await ServiceInvoker.Request<UpdateTagResponse>(request);
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteTagResponse?> DeleteTagAsync(DeleteTagRequest request)
        {
            return await ServiceInvoker.Request<DeleteTagResponse>(request);
        }


        /// <summary>
        /// 获取标签下粉丝列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUsersByTagResponse?> GetUsersByTagAsync(GetUsersByTagRequest request)
        {
            return await ServiceInvoker.Request<GetUsersByTagResponse>(request);
        }

        /// <summary>
        /// 批量为用户打标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchTaggingResponse?> BatchTaggingAsync(BatchTaggingRequest request)
        {
            return await ServiceInvoker.Request<BatchTaggingResponse>(request);
        }

        /// <summary>
        /// 批量为用户取消标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchUntaggingResponse?> BatchUntaggingAsync(BatchUntaggingRequest request)
        {
            return await ServiceInvoker.Request<BatchUntaggingResponse>(request);
        }

        /// <summary>
        /// 获取用户身上的标签列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetTagIdsByUserResponse?> GetTagIdsByUserAsync(GetTagIdsByUserRequest request)
        {
            return await ServiceInvoker.Request<GetTagIdsByUserResponse>(request);
        }

        #endregion

        #region 用户管理

        /// <summary>
        /// 设置用户备注名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateUserRemarkResponse?> UpdateUserRemarkAsync(UpdateUserRemarkRequest request)
        {
            return await ServiceInvoker.Request<UpdateUserRemarkResponse>(request);
        }

        /// <summary>
        /// 获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUserInfoResponse?> GetUserInfoAsync(GetUserInfoRequest request)
        {
            return await ServiceInvoker.Request<GetUserInfoResponse>(request);
        }

        /// <summary>
        /// 批量获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchGetUserInfoResponse?> BatchGetUserInfoAsync(BatchGetUserInfoRequest request)
        {
            return await ServiceInvoker.Request<BatchGetUserInfoResponse>(request);
        }

        /// <summary>
        /// 批量获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUserListResponse?> GetUserListAsync(GetUserListRequest request)
        {
            return await ServiceInvoker.Request<GetUserListResponse>(request);
        }

        #endregion

        #region 黑名单管理

        /// <summary>
        /// 获取公众号的黑名单列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetBlackListResponse?> GetBlackListAsync(GetBlackListRequest request)
        {
            return await ServiceInvoker.Request<GetBlackListResponse>(request);
        }

        /// <summary>
        /// 拉黑用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchBlackListResponse?> BatchBlackListAsync(BatchBlackListRequest request)
        {
            return await ServiceInvoker.Request<BatchBlackListResponse>(request);
        }

        /// <summary>
        /// 取消拉黑用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchUnblackListResponse?> BatchUnblackListAsync(BatchUnblackListRequest request)
        {
            return await ServiceInvoker.Request<BatchUnblackListResponse>(request);
        }

        #endregion
    }
}

