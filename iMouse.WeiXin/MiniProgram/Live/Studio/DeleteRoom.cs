using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class DeleteRoomRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/deleteroom";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DeleteRoomResponse : BaseResponse { }
}

