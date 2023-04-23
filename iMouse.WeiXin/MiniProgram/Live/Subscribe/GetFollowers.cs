using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Subscribe
{
    public class GetFollowersRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/get_wxa_followers";

        /// <summary>       
        /// 获取长期订阅用户的个数限制，默认200，最大2000
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("limit")]
        public int Limit { get; set; } = 200;

        /// <summary>       
        /// 翻页标记，获取第一页时不带，第二页开始需带上上一页返回结果中的page_break
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("page_break")]
        public int PageBreak { get; set; }
    }

    public class GetFollowersResponse : BaseResponse
    {
        /// <summary>       
        /// 长期订阅用户列表
        /// </summary>        
        [JsonProperty("followers")]
        public List<GetFollowersResponseFollowerInfo>? Followers { get; set; }

        /// <summary>       
        /// 翻页标记，获取下一页时带上该值
        /// </summary>        
        [JsonProperty("page_break")]
        public string PageBreak { get; set; } = string.Empty;

    }

    public class GetFollowersResponseFollowerInfo
    {
        /// <summary>       
        /// 长期订阅用户OpenId
        /// </summary>        
        [JsonProperty("openid")]
        public string Openid { get; set; } = string.Empty;

        /// <summary>       
        /// 长期订阅用户订阅时间
        /// </summary>        
        [JsonProperty("subscribe_time")]
        public long SubscribeTime { get; set; }

        /// <summary>       
        /// 用户订阅时所处房间
        /// </summary>        
        [JsonProperty("room_id")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 用户订阅时房间状态
        /// </summary>        
        [JsonProperty("room_status")]
        public int RoomStatus { get; set; }
    }
}

