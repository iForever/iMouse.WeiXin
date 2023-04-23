using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class GetSubAnchorRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/getsubanchor";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [QueryParamater("roomId")]
        public int RoomId { get; set; }
    }

    public class GetSubAnchorResponse : BaseResponse
    {

        /// <summary>       
        /// 主播微信号
        /// </summary>        
        [JsonProperty("username")]
        public string UserName { get; set; } = string.Empty;
    }
}

