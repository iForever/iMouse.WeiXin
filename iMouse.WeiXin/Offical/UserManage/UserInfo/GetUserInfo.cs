using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserInfo
{
    public class GetUserInfoRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/cgi-bin/user/info";

        [QueryParamater("openid")]
        public string OpenId { get; set; } = string.Empty;

        [QueryParamater("lang")]
        public string Lang { get; set; } = "zh_CN";
    }

    public class GetUserInfoResponse : BaseResponse
    {
        /// <summary>
        /// 用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。
        /// </summary>
        [JsonProperty("subscribe")]
        public int Subscribed { get; set; }

        /// <summary>
        /// 用户是否订阅该公众号标识
        /// </summary>
        public bool IsSubscribed => Subscribed != 0;

        /// <summary>
        /// 用户的标识，对当前公众号唯一
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 用户的语言，简体中文为zh_CN
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// 用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间
        /// </summary>
        [JsonProperty("subscribe_time")]
        public long SubscribeTime { get; set; }

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号运营者对粉丝的备注，公众号运营者可在微信公众平台用户管理界面对粉丝添加备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; } = string.Empty;

        /// <summary>
        /// 用户所在的分组ID（兼容旧的用户分组接口）
        /// </summary>
        [Obsolete]
        [JsonProperty("groupid")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 用户被打上的标签 ID 列表
        /// </summary>
        [JsonProperty("tagid_list")]
        public List<int>? TagIds { get; set; }

        /// <summary>
        /// 返回用户关注的渠道来源
        /// </summary>
        [JsonProperty("subscribe_scene")]
        public SubscribeScene SubscribeScene { get; set; } = SubscribeScene.DEFAULT;

        /// <summary>
        /// 二维码扫码场景（开发者自定义）
        /// </summary>
        [JsonProperty("qr_scene")]
        public int QRScene { get; set; }

        /// <summary>
        /// 二维码扫码场景描述（开发者自定义）
        /// </summary>
        [JsonProperty("qr_scene_str")]
        public string QRSceneString { get; set; } = string.Empty;
    }
}

