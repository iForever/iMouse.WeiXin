using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class UpdateReplayRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/updatereplay";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 是否关闭回放 【0：开启，1：关闭】
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("closeReplay")]
        public int CloseReplay { get; set; }
    }

    public class UpdateReplayResponse : BaseResponse
    {


    }
}

