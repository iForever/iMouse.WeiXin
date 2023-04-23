using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Role
{
    public class GetRoleListRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/role/getrolelist";

        /// <summary>       
        /// 查询的用户角色，取值 [-1-所有成员， 0-超级管理员，1-管理员，2-主播，3-运营者]，默认-1
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("role")]
        public int Role { get; set; } = -1;

        /// <summary>       
        /// 起始偏移量, 默认0
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("offset")]
        public int Offset { get; set; }

        /// <summary>       
        /// 查询个数，最大30，默认10
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("limit")]
        public int Limit { get; set; } = 10;

        /// <summary>       
        /// 搜索的微信号或昵称，不传则返回全部
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("keyword")]
        public string Keyword { get; set; } = string.Empty;
    }

    public class GetRoleListResponse : BaseResponse
    {

        /// <summary>       
        /// 总个数
        /// </summary>        
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>       
        /// 角色列表
        /// </summary>        
        [JsonProperty("list")]
        public List<GetRoleListResponseRoleInfo>? List { get; set; }
    }

    public class GetRoleListResponseRoleInfo
    {
        /// <summary>       
        /// 微信用户头像url
        /// </summary>        
        [JsonProperty("headingImg")]
        public string HeadingImg { get; set; } = string.Empty;

        /// <summary>       
        /// 微信用户昵称
        /// </summary>        
        [JsonProperty("nickName")]
        public string NickName { get; set; } = string.Empty;

        /// <summary>       
        /// openid
        /// </summary>        
        [JsonProperty("openId")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>       
        /// 具有的身份，[0-超级管理员，1-管理员，2-主播，3-运营者]
        /// </summary>        
        [JsonProperty("roleList")]
        public List<int>? RoleList { get; set; }

        /// <summary>       
        /// 更新时间
        /// </summary>        
        [JsonProperty("updateTimestamp")]
        public long UpdateTimestamp { get; set; }

        /// <summary>       
        /// 微信号
        /// </summary>        
        [JsonProperty("userName")]
        public string UserName { get; set; } = string.Empty;
    }
}

