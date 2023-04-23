using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class UpdateFeedPublicRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/updatefeedpublic";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 是否开启官方收录 【1: 开启，0：关闭】
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("isFeedsPublic")]
        public int IsFeedsPublic { get; set; }
    }

    public class UpdateFeedPublicResponse : BaseResponse
    {


    }



}

