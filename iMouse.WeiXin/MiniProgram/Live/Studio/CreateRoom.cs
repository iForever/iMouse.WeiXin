using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class CreateRoomRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/create";

        /// <summary>       
        /// 直播间名字，最短3个汉字，最长17个汉字，1个汉字相当于2个字符
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 背景图，填入mediaID（mediaID获取后，三天内有效）；图片 mediaID 的获取，
        /// 请参考以下文档： https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html；
        /// 直播间背景图，图片规则：建议像素1080*1920，大小不超过2M
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("coverImg")]
        public string CoverImg { get; set; } = string.Empty;

        /// <summary>       
        /// 直播计划开始时间（开播时间需要在当前时间的10分钟后 并且 开始时间不能在 6 个月后）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("startTime")]
        public long StartTime { get; set; }

        /// <summary>       
        /// 直播计划结束时间（开播时间和结束时间间隔不得短于30分钟，不得超过24小时）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("endTime")]
        public long EndTime { get; set; }

        /// <summary>       
        /// 主播昵称，最短2个汉字，最长15个汉字，1个汉字相当于2个字符
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("anchorName")]
        public string AnchorName { get; set; } = string.Empty;

        /// <summary>       
        /// 主播微信号，如果未实名认证，需要先前往“小程序直播”小程序进行实名验证,
        /// 小程序二维码链接：https://res.wx.qq.com/op_res/9rSix1dhHfK4rR049JL0PHJ7TpOvkuZ3mE0z7Ou_Etvjf-w1J_jVX0rZqeStLfwh
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("anchorWechat")]
        public string AnchorWechat { get; set; } = string.Empty;

        /// <summary>       
        /// 主播副号微信号，如果未实名认证，需要先前往“小程序直播”小程序进行实名验证,
        /// 小程序二维码链接：https://res.wx.qq.com/op_res/9rSix1dhHfK4rR049JL0PHJ7TpOvkuZ3mE0z7Ou_Etvjf-w1J_jVX0rZqeStLfwh
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("subAnchorWechat")]
        public string SubAnchorWechat { get; set; } = string.Empty;

        /// <summary>       
        /// 创建者微信号，不传入则此直播间所有成员可见。传入则此房间仅创建者、管理员、超管、直播间主播可见
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("createrWechat")]
        public string CreaterWechat { get; set; } = string.Empty;

        /// <summary>       
        /// 分享图，填入mediaID（mediaID获取后，三天内有效）；图片 mediaID 的获取，
        /// 请参考以下文档： https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html；
        /// 直播间分享图，图片规则：建议像素800*640，大小不超过1M；
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("shareImg")]
        public string ShareImg { get; set; } = string.Empty;

        /// <summary>       
        /// 购物直播频道封面图，填入mediaID（mediaID获取后，三天内有效）；图片 mediaID 的获取，
        /// 请参考以下文档： https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html;
        /// 购买直播频道封面图，图片规则：建议像素800*800，大小不超过100KB；
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("feedsImg")]
        public string FeedsImg { get; set; } = string.Empty;

        /// <summary>       
        /// 是否开启官方收录 【1: 开启，0：关闭】，默认开启收录
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("isFeedsPublic")]
        public int IsFeedsPublic { get; set; } = 1;

        /// <summary>       
        /// 直播间类型 【1: 推流，0：手机直播】
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>       
        /// 是否关闭点赞 【0：开启，1：关闭】（若关闭，观众端将隐藏点赞按钮，直播开始后不允许开启）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("closeLike")]
        public int CloseLike { get; set; }

        /// <summary>       
        /// 是否关闭货架 【0：开启，1：关闭】（若关闭，观众端将隐藏商品货架，直播开始后不允许开启）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("closeGoods")]
        public int CloseGoods { get; set; }

        /// <summary>       
        /// 是否关闭评论 【0：开启，1：关闭】（若关闭，观众端将隐藏评论入口，直播开始后不允许开启）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("closeComment")]
        public int CloseComment { get; set; }

        /// <summary>       
        /// 是否关闭回放 【0：开启，1：关闭】默认关闭回放（直播开始后允许开启）
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("closeReplay")]
        public int CloseReplay { get; set; } = 1;

        /// <summary>       
        /// 是否关闭分享 【0：开启，1：关闭】默认开启分享（直播开始后不允许修改）
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("closeShare")]
        public int CloseShare { get; set; }

        /// <summary>       
        /// 是否关闭客服 【0：开启，1：关闭】 默认关闭客服（直播开始后允许开启）
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("closeKf")]
        public int CloseKf { get; set; } = 1;
    }

    public class CreateRoomResponse : BaseResponse
    {
        /// <summary>
        /// 房间ID
        /// </summary>
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>
        /// "小程序直播" 小程序码
        /// </summary>
        [JsonProperty("qrcode_url")]
        public string QRCodeURL { get; set; } = string.Empty;
    }
}

