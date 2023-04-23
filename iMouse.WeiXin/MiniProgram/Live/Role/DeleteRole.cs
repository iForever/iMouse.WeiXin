using System;
namespace iMouse.WeiXin.MiniProgram.Live.Role
{
    public class DeleteRoleRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/role/deleterole";

        /// <summary>       
        /// 用户的微信号
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("username")]
        public string UserName { get; set; } = string.Empty;

        /// <summary>       
        /// 删除用户的角色
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("role")]
        public int Role { get; set; }
    }

    public class DeleteRoleResponse : BaseResponse
    {


    }

}

