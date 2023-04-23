using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class UpdateKFRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/updatekf";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 是否关闭客服 【0：开启，1：关闭】
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("closeKf")]
        public int CloseKf { get; set; }
    }

    public class UpdateKFResponse : BaseResponse
    {


    }
}

