using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class RemoveAssistantRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/removeassistant";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 用户微信号
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("username")]
        public string UserName { get; set; } = string.Empty;
    }

    public class RemoveAssistantResponse : BaseResponse
    {


    }
}

