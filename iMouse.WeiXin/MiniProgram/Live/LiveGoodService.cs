using System;
using iMouse.WeiXin.MiniProgram.Live.Goods;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public class LiveGoodService : ILiveGoodService
    {
        /// <summary>
        /// 添加并提审商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddGoodsResponse?> AddGoodsAsync(AddGoodsRequest request)
        {
            return await ServiceInvoker.Request<AddGoodsResponse>(request);
        }

        /// <summary>
        /// 重新提交商品审核
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResubmitAuditResponse?> ResubmitAuditAsync(ResubmitAuditRequest request)
        {
            return await ServiceInvoker.Request<ResubmitAuditResponse>(request);
        }

        /// <summary>
        /// 获取商品的信息与审核状态
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetGoodsAuditInfoResponse?> GetGoodsAuditInfoAsync(GetGoodsAuditInfoRequest request)
        {
            return await ServiceInvoker.Request<GetGoodsAuditInfoResponse>(request);
        }

        /// <summary>
        /// 撤回商品审核
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResetAuditResponse?> ResetAuditAsync(ResetAuditRequest request)
        {
            return await ServiceInvoker.Request<ResetAuditResponse>(request);
        }

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UpdateGoodsInfoResponse?> UpdateGoodsinfoAsync(UpdateGoodsInfoRequest request)
        {
            return await ServiceInvoker.Request<UpdateGoodsInfoResponse>(request);
        }




    }
}

