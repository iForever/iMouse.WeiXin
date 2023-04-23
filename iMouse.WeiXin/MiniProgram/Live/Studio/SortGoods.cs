using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class SortGoodsRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/sort";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        /// <summary>       
        /// 商品 ID 列表
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goods")]
        public List<SortGoodsRequestGoodsIdInfo>? Goods { get; set; }
    }

    public class SortGoodsRequestGoodsIdInfo
    {
        /// <summary>       
        /// 商品id
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }


    public class SortGoodsResponse : BaseResponse
    {


    }
}

