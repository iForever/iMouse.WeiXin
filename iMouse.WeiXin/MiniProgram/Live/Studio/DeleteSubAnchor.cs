using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class DeleteSubAnchorRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/deletesubanchor";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }
    }

    public class DeleteSubAnchorResponse : BaseResponse
    {


    }
}

