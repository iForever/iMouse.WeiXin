using System;

namespace iMouse.WeiXin.Offical.UserManage
{
    using BlackList;
    using UserInfo;
    using UserTags;

    /// <summary>
    /// 公众号用户管理服务
    /// </summary>
    public interface IOfficalUserService
    {
        #region 用户标签管理

        /// <summary>
        /// 创建标签
        /// <para>一个公众号，最多可以创建100个标签。</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateTagResponse?> CreateTagAsync(CreateTagRequest request);

        /// <summary>
        /// 获取公众号已创建的标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetTagsResponse?> GetTagsAsync(GetTagsRequest request);

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateTagResponse?> UpdateTagAsync(UpdateTagRequest request);

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteTagResponse?> DeleteTagAsync(DeleteTagRequest request);


        /// <summary>
        /// 获取标签下粉丝列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetUsersByTagResponse?> GetUsersByTagAsync(GetUsersByTagRequest request);

        /// <summary>
        /// 批量为用户打标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchTaggingResponse?> BatchTaggingAsync(BatchTaggingRequest request);

        /// <summary>
        /// 批量为用户取消标签
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchUntaggingResponse?> BatchUntaggingAsync(BatchUntaggingRequest request);

        /// <summary>
        /// 获取用户身上的标签列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetTagIdsByUserResponse?> GetTagIdsByUserAsync(GetTagIdsByUserRequest request);
        #endregion

        #region 用户管理

        /// <summary>
        /// 设置用户备注名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateUserRemarkResponse?> UpdateUserRemarkAsync(UpdateUserRemarkRequest request);

        /// <summary>
        /// 获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetUserInfoResponse?> GetUserInfoAsync(GetUserInfoRequest request);

        /// <summary>
        /// 批量获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchGetUserInfoResponse?> BatchGetUserInfoAsync(BatchGetUserInfoRequest request);

        /// <summary>
        /// 批量获取用户基本信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetUserListResponse?> GetUserListAsync(GetUserListRequest request);
        #endregion

        #region 黑名单管理

        /// <summary>
        /// 获取公众号的黑名单列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetBlackListResponse?> GetBlackListAsync(GetBlackListRequest request);

        /// <summary>
        /// 拉黑用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchBlackListResponse?> BatchBlackListAsync(BatchBlackListRequest request);

        /// <summary>
        /// 取消拉黑用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchUnblackListResponse?> BatchUnblackListAsync(BatchUnblackListRequest request);

        #endregion
    }
}

