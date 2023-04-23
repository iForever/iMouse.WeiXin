using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class SaleGoodsRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/onsale";

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

        /// <summary>       
        /// 上下架 【0：下架，1：上架】
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("onSale")]
        public int OnSale { get; set; }
    }

    public class SaleGoodsResponse : BaseResponse
    {


    }
}

