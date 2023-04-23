using System;
using iMouse.WeiXin.MiniProgram.Live.Goods;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public interface ILiveGoodService
    {
        /// <summary>
        /// 添加并提审商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddGoodsResponse?> AddGoodsAsync(AddGoodsRequest request);

        /// <summary>
        /// 重新提交商品审核
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ResubmitAuditResponse?> ResubmitAuditAsync(ResubmitAuditRequest request);

        /// <summary>
        /// 获取商品的信息与审核状态
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGoodsAuditInfoResponse?> GetGoodsAuditInfoAsync(GetGoodsAuditInfoRequest request);

        /// <summary>
        /// 撤回商品审核
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ResetAuditResponse?> ResetAuditAsync(ResetAuditRequest request);

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<UpdateGoodsInfoResponse?> UpdateGoodsinfoAsync(UpdateGoodsInfoRequest request);



    }
}

