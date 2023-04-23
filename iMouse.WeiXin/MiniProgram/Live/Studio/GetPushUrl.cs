using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class GetPushUrlRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/getpushurl";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [QueryParamater("roomId")]
        public int RoomId { get; set; }
    }

    public class GetPushUrlResponse : BaseResponse
    {
        /// <summary>       
        /// 推流地址
        /// </summary>        
        [JsonProperty("pushAddr")]
        public string PushAddr { get; set; } = string.Empty;
    }
}

