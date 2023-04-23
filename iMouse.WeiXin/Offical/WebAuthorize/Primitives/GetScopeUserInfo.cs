using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.WebAuthorize
{
    public class GetScopeUserInfoRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/sns/userinfo";

        [QueryParamater("openid")]
        public string OpenId { get; set; } = string.Empty;

        [QueryParamater("lang")]
        public string Lang { get; set; } = "zh_CN";
    }

    public class GetScopeUserInfoResponse : BaseResponse
    {
        /// <summary>
        /// 用户的唯一标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; } = string.Empty;

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string NickName { get; set; } = string.Empty;

        /// <summary>
        /// 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像 URL 将失效。
        /// </summary>
        [JsonProperty("headimgurl")]
        public string Avatar { get; set; } = string.Empty;

        /// <summary>
        /// 普通用户个人资料填写的城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// 国家，如中国为CN
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// 用户的性别
        /// </summary>
        [JsonProperty("sex")]
        public Gender Gender { get; set; } = Gender.Unknown;

        /// <summary>
        /// 用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
        /// </summary>
        [JsonProperty("privilege")]
        public List<string>? Privileges { get; set; }
    }
}

