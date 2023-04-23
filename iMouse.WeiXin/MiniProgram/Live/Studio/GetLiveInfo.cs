using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class GetLiveInfoRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/getliveinfo";

        /// <summary>       
        /// 起始拉取视频，0表示从第一个视频片段开始拉取
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("start")]
        public int Start { get; set; }

        /// <summary>       
        /// 每次拉取的数量，建议100以内
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>       
        /// 只能填"get_replay"，表示获取回放。
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>       
        /// 当 action 有值时该字段必填，直播间ID
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("room_id")]
        public int RoomId { get; set; }
    }

    public class GetLiveInfoResponse : BaseResponse
    {
        /// <summary>       
        /// action="get_replay"不返回。
        /// </summary>        
        [JsonProperty("room_info")]
        public List<GetLiveInfoResponseReplayInfo>? Rooms { get; set; }

        /// <summary>       
        /// 拉取房间总数
        /// </summary>        
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>       
        /// action="get_replay"才返回。
        /// </summary>        
        [JsonProperty("live_replay")]
        public List<GetLiveInfoResponseReplayInfo>? Replays { get; set; }

    }

    public class GetLiveInfoResponseRoomInfo
    {
        /// <summary>       
        /// 直播间名称
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 直播间背景图链接
        /// </summary>        
        [JsonProperty("cover_img")]
        public string CoverImg { get; set; } = string.Empty;

        /// <summary>       
        /// 直播间开始时间，列表按照start_time降序排列
        /// </summary>        
        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        /// <summary>       
        /// 直播计划结束时间
        /// </summary>        
        [JsonProperty("end_time")]
        public int EndTime { get; set; }

        /// <summary>       
        /// 主播名
        /// </summary>        
        [JsonProperty("anchor_name")]
        public string AnchorName { get; set; } = string.Empty;

        /// <summary>       
        /// 直播间ID
        /// </summary>        
        [JsonProperty("roomid")]
        public int Roomid { get; set; }

        /// <summary>       
        /// 商品
        /// </summary>        
        [JsonProperty("goods")]
        public List<GetLiveInfoResponseGoodInfo>? Goods { get; set; }

        /// <summary>       
        /// 直播间状态。101：直播中，102：未开始，103已结束，104禁播，105：暂停，106：异常，107：已过期
        /// </summary>        
        [JsonProperty("live_status")]
        public int LiveStatus { get; set; }

        /// <summary>       
        /// 直播间分享图链接
        /// </summary>        
        [JsonProperty("share_img")]
        public string ShareImg { get; set; } = string.Empty;

        /// <summary>       
        /// 直播类型，1 推流 0 手机直播
        /// </summary>        
        [JsonProperty("live_type")]
        public int LiveType { get; set; }

        /// <summary>       
        /// 是否关闭点赞 【0：开启，1：关闭】（若关闭，观众端将隐藏点赞按钮，直播开始后不允许开启）
        /// </summary>        
        [JsonProperty("close_like")]
        public int CloseLike { get; set; }

        /// <summary>       
        /// 是否关闭货架 【0：开启，1：关闭】（若关闭，观众端将隐藏商品货架，直播开始后不允许开启）
        /// </summary>        
        [JsonProperty("close_goods")]
        public int CloseGoods { get; set; }

        /// <summary>       
        /// 是否关闭评论 【0：开启，1：关闭】（若关闭，观众端将隐藏评论入口，直播开始后不允许开启）
        /// </summary>        
        [JsonProperty("close_comment")]
        public int CloseComment { get; set; }

        /// <summary>       
        /// 是否关闭客服 【0：开启，1：关闭】 默认关闭客服（直播开始后允许开启）
        /// </summary>        
        [JsonProperty("close_kf")]
        public int CloseKf { get; set; }

        /// <summary>       
        /// 是否关闭回放 【0：开启，1：关闭】默认关闭回放（直播开始后允许开启）
        /// </summary>        
        [JsonProperty("close_replay")]
        public int CloseReplay { get; set; }

        /// <summary>       
        /// 是否开启官方收录，1 开启，0 关闭
        /// </summary>        
        [JsonProperty("is_feeds_public")]
        public int IsFeedsPublic { get; set; }

        /// <summary>       
        /// 创建者openid
        /// </summary>        
        [JsonProperty("creater_openid")]
        public string CreaterOpenid { get; set; } = string.Empty;

        /// <summary>       
        /// 官方收录封面
        /// </summary>        
        [JsonProperty("feeds_img")]
        public string FeedsImg { get; set; } = string.Empty;
    }


    public class GetLiveInfoResponseGoodInfo
    {
        /// <summary>       
        /// 商品名称
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 商品封面图链接
        /// </summary>        
        [JsonProperty("cover_img")]
        public string CoverImg { get; set; } = string.Empty;

        /// <summary>       
        /// 商品小程序路径
        /// </summary>        
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>       
        /// 商品价格（分）
        /// </summary>        
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>       
        /// 商品价格，使用方式看price_type
        /// </summary>        
        [JsonProperty("price2")]
        public int Price2 { get; set; }

        /// <summary>       
        /// 价格类型，1：一口价（只需要传入price，price2不传） 2：价格区间（price字段为左边界，price2字段为右边界，price和price2必传） 3：显示折扣价（price字段为原价，price2字段为现价， price和price2必传）
        /// </summary>        
        [JsonProperty("price_type")]
        public int PriceType { get; set; }

        /// <summary>       
        /// 商品id
        /// </summary>        
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>       
        /// 第三方商品appid ,当前小程序商品则为空
        /// </summary>        
        [JsonProperty("third_party_appid")]
        public string ThirdPartyAppid { get; set; } = string.Empty;
    }

    public class GetLiveInfoResponseReplayInfo
    {
        /// <summary>       
        /// 回放视频创建时间
        /// </summary>        
        [JsonProperty("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>       
        /// 回放视频 url 过期时间
        /// </summary>        
        [JsonProperty("expire_time")]
        public string ExpireTime { get; set; } = string.Empty;

        /// <summary>       
        /// 回放视频链接
        /// </summary>        
        [JsonProperty("media_url")]
        public string MediaUrl { get; set; } = string.Empty;
    }
}

