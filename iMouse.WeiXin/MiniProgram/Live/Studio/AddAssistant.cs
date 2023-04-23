using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class AddAssistantRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/addassistant";


        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 用户数组
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("users")]
        public List<AddAssistantRequestAssistantInfo>? Users { get; set; }
    }

    public class AddAssistantRequestAssistantInfo
    {
        /// <summary>       
        /// 用户微信号
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("username")]
        public string UserName { get; set; } = string.Empty;

        /// <summary>       
        /// 用户昵称
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("nickname")]
        public string NickName { get; set; } = string.Empty;
    }

    public class AddAssistantResponse : BaseResponse
    {


    }
}

