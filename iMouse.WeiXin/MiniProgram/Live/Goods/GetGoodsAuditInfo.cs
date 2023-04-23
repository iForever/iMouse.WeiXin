using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Goods
{
    public class GetGoodsAuditInfoRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/getgoodswarehouse";

        /// <summary>       
        /// 商品ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("goods_ids")]
        public List<int>? GoodsIds { get; set; }
    }

    public class GetGoodsAuditInfoResponse : BaseResponse
    {
        /// <summary>       
        /// 商品ID
        /// </summary>        
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>       
        /// 商品名称
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 商品图片url
        /// </summary>        
        [JsonProperty("cover_img_url")]
        public string CoverImgUrl { get; set; } = string.Empty;

        /// <summary>       
        /// 商品详情页的小程序路径
        /// </summary>        
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>       
        /// 1:一口价，此时读 price 字段; 2:价格区间，此时 price 字段为左边界，price2字段为右边界; 3:折扣价，此时 price 字段为原价，price2字段为现价；
        /// </summary>        
        [JsonProperty("priceType")]
        public int PriceType { get; set; }

        /// <summary>       
        /// 价格左区间，单位“元”
        /// </summary>        
        [JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>       
        /// 价格右区间，单位“元”
        /// </summary>        
        [JsonProperty("price2")]
        public float Price2 { get; set; }

        /// <summary>       
        /// 0：未审核，1：审核中，2:审核通过，3审核失败
        /// </summary>        
        [JsonProperty("audit_status")]
        public int AuditStatus { get; set; }

        /// <summary>       
        /// 1、2：表示是为 API 添加商品，否则是直播控制台添加的商品
        /// </summary>        
        [JsonProperty("third_party_tag")]
        public int ThirdPartyTag { get; set; }

        /// <summary>       
        /// 当商品为第三方小程序的商品则为对应第三方小程序的appid，自身小程序商品则为''
        /// </summary>        
        [JsonProperty("thirdPartyAppid")]
        public string ThirdPartyAppid { get; set; } = string.Empty;

        /// <summary>       
        /// 商品个数
        /// </summary>        
        [JsonProperty("total")]
        public int Total { get; set; }

    }
}

