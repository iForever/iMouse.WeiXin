using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class DownloadGoodsVideoRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/getVideo";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 商品ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }

    public class DownloadGoodsVideoResponse : BaseResponse
    {
        /// <summary>       
        /// 讲解链接
        /// </summary>        
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

    }
}

