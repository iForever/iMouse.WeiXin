using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Subscribe
{
    public class PushMessageRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/push_message";

        /// <summary>       
        /// 直播开始事件的房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("room_id")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 接收该群发开播事件的订阅用户 OpenId 列表
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("user_openid")]
        public List<string>? Users { get; set; }
    }

    public class PushMessageResponse : BaseResponse
    {
        /// <summary>       
        /// 此次群发消息的标识ID，用于对应【长期订阅群发结果回调】的message_id
        /// </summary>        
        [JsonProperty("message_id")]
        public string MessageId { get; set; } = string.Empty;

    }
}

