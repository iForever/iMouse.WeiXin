using System;
namespace iMouse.WeiXin.MiniProgram.Live.Goods
{
    public class ResetAuditRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/resetaudit";

        /// <summary>       
        /// 商品ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }

        /// <summary>       
        /// 审核单ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("auditId")]
        public int AuditId { get; set; }
    }

    public class ResetAuditResponse : BaseResponse
    {


    }
}

