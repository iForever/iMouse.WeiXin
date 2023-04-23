using System;
using iMouse.WeiXin.MiniProgram.Live.Role;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public class LiveRoleService : ILiveRoleService
    {

        /// <summary>
        /// 设置成员角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddRoleResponse?> AddRoleAsync(AddRoleRequest request)
        {
            return await ServiceInvoker.Request<AddRoleResponse>(request);
        }

        /// <summary>
        /// 移除成员角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteRoleResponse?> DeleteRoleAsync(DeleteRoleRequest request)
        {
            return await ServiceInvoker.Request<DeleteRoleResponse>(request);
        }


        /// <summary>
        /// 查询成员列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRoleListResponse?> GetRoleListAsync(GetRoleListRequest request)
        {
            return await ServiceInvoker.Request<GetRoleListResponse>(request);
        }


    }
}


