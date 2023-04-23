using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class ImportGoodsRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/addgoods";

        /// <summary>       
        /// 数组列表，可传入多个，里面填写 商品 ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("ids")]
        public List<int>? Ids { get; set; }

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("roomId")]
        public int RoomId { get; set; }
    }

    public class ImportGoodsResponse : BaseResponse
    {


    }
}

