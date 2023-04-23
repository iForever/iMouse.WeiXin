using System;
namespace iMouse.WeiXin.MiniProgram.Live.Role
{
    public class AddRoleRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/role/addrole";

        /// <summary>       
        /// 用户的微信号
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("username")]
        public string UserName { get; set; } = string.Empty;

        /// <summary>       
        /// 设置用户的角色
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("role")]
        public int Role { get; set; }
    }

    public class AddRoleResponse : BaseResponse
    {
        /// <summary>       
        /// 如果主播未实名认证，需要先前往“小程序直播”小程序进行实名验证, 点击查看小程序二维码链接
        /// </summary>        
        [JsonProperty("codeurl")]
        public string Codeurl { get; set; } = string.Empty;

    }
}

