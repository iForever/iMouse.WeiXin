using System;
namespace iMouse.WeiXin.MiniProgram.Live.Goods
{
    public class ResubmitAuditRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/audit";

        /// <summary>       
        /// 商品ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }

    public class ResubmitAuditResponse : BaseResponse
    {
        /// <summary>       
        /// 审核单ID
        /// </summary>        
        [JsonProperty("auditId")]
        public int AuditId { get; set; }

    }
}

