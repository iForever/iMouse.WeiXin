using System;
using iMouse.WeiXin.MiniProgram.Live.Role;

namespace iMouse.WeiXin.MiniProgram.Live
{
    public interface ILiveRoleService
    {

        /// <summary>
        /// 设置成员角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddRoleResponse?> AddRoleAsync(AddRoleRequest request);

        /// <summary>
        /// 移除成员角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteRoleResponse?> DeleteRoleAsync(DeleteRoleRequest request);


        /// <summary>
        /// 查询成员列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetRoleListResponse?> GetRoleListAsync(GetRoleListRequest request);



    }
}
