using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class GetAssistantListRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/getassistantlist";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }
    }

    public class GetAssistantListResponse : BaseResponse
    {

        /// <summary>       
        /// 小助手列表
        /// </summary>        
        [JsonProperty("list")]
        public List<GetAssistantListResponseAssistantInfo>? List { get; set; }

        /// <summary>       
        /// 小助手个数
        /// </summary>        
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>       
        /// 小助手最大个数
        /// </summary>        
        [JsonProperty("maxCount")]
        public int MaxCount { get; set; }
    }

    public class GetAssistantListResponseAssistantInfo
    {
        /// <summary>       
        /// 修改时间
        /// </summary>        
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>       
        /// 头像
        /// </summary>        
        [JsonProperty("headimg")]
        public string HeadImg { get; set; } = string.Empty;

        /// <summary>       
        /// 昵称
        /// </summary>        
        [JsonProperty("nickname")]
        public string NickName { get; set; } = string.Empty;

        /// <summary>       
        /// 微信号
        /// </summary>        
        [JsonProperty("alias")]
        public string Alias { get; set; } = string.Empty;

        /// <summary>       
        /// openid
        /// </summary>        
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}

