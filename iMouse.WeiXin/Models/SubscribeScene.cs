using System;
using Newtonsoft.Json.Converters;

namespace iMouse.WeiXin.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscribeScene
    {
        /// <summary>
        /// 默认
        /// </summary>
        DEFAULT,
        /// <summary>
        /// 公众号搜索
        /// </summary>
        ADD_SCENE_SEARCH,
        /// <summary>
        /// 公众号迁移
        /// </summary>
        ADD_SCENE_ACCOUNT_MIGRATION,
        /// <summary>
        /// 名片分享
        /// </summary>
        ADD_SCENE_PROFILE_CARD,
        /// <summary>
        /// 扫描二维码
        /// </summary>
        ADD_SCENE_QR_CODE,
        /// <summary>
        /// 图文页内名称点击
        /// </summary>
        ADD_SCENE_PROFILE_LINK,
        /// <summary>
        /// 图文页右上角菜单
        /// </summary>
        ADD_SCENE_PROFILE_ITEM,
        /// <summary>
        /// 支付后关注
        /// </summary>
        ADD_SCENE_PAID,
        /// <summary>
        /// 微信广告
        /// </summary>
        ADD_SCENE_WECHAT_ADVERTISEMENT,
        /// <summary>
        /// 他人转载
        /// </summary>
        ADD_SCENE_REPRINT,
        /// <summary>
        /// 视频号直播
        /// </summary>
        ADD_SCENE_LIVESTREAM,
        /// <summary>
        /// 视频号
        /// </summary>
        ADD_SCENE_CHANNELS,
        /// <summary>
        /// 其他
        /// </summary>
        ADD_SCENE_OTHERS,
    }
}

