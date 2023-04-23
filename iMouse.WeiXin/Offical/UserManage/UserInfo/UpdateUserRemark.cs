using System;
namespace iMouse.WeiXin.Offical.UserManage.UserInfo
{
    public class UpdateUserRemarkRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/user/info/updateremark";

        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 新的备注名，长度必须小于30字节
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; } = string.Empty;
    }

    public class UpdateUserRemarkResponse : BaseResponse
    {

    }
}

