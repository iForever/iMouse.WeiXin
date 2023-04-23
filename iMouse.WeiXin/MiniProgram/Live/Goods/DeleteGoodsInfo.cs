using System;
namespace iMouse.WeiXin.MiniProgram.Live.Goods
{
    public class DeleteGoodsInfoRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/delete";

        /// <summary>       
        /// 商品ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }

    public class DeleteGoodsInfoResponse : BaseResponse
    {


    }
}

