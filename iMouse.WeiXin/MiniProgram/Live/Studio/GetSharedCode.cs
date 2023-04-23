using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class GetSharedCodeRequest : BaseTokenRequest
    {

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/getsharedcode";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [QueryParamater("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 自定义参数
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("params")]
        public string Params { get; set; } = string.Empty;
    }

    public class GetSharedCodeResponse : BaseResponse
    {
        /// <summary>       
        /// 分享二维码cdn url
        /// </summary>        
        [JsonProperty("cdnUrl")]
        public string CDNUrl { get; set; } = string.Empty;

        /// <summary>       
        /// 分享路径
        /// </summary>        
        [JsonProperty("pagePath")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>       
        /// 分享海报 url
        /// </summary>        
        [JsonProperty("posterUrl")]
        public string PosterUrl { get; set; } = string.Empty;

    }
}

