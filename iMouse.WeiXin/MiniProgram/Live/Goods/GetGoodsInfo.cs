using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Live.Goods
{
    public class GetGoodsInfoRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/goods/getapproved";

        /// <summary>       
        /// 分页条数起点
        /// 是否必须 - 是
        /// </summary>        
        [QueryParamater("offset")]
        public int Offset { get; set; }

        /// <summary>       
        /// 分页大小，默认30，不超过100
        /// 是否必须 - 否
        /// </summary>        
        [QueryParamater("limit")]
        public int Limit { get; set; } = 30;

        /// <summary>       
        /// 商品状态，0：未审核。1：审核中，2：审核通过，3：审核驳回
        /// 是否必须 - 是
        /// </summary>        
        [QueryParamater("status")]
        public int Status { get; set; }
    }

    public class GetGoodsInfoResponse : BaseResponse
    {
        /// <summary>       
        /// 商品数量
        /// </summary>        
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("goods")]
        public List<GetGoodsInfoResponseGoodInfo>? Goods { get; set; }

    }

    public class GetGoodsInfoResponseGoodInfo
    {
        /// <summary>       
        /// 填入mediaID（mediaID获取后，三天内有效）；图片 mediaID 的获取，
        /// 请参考以下文档New_temporary_materials；
        /// 图片规则：图片尺寸最大300像素*300像素；
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("coverImgUrl")]
        public string CoverImgUrl { get; set; } = string.Empty;

        /// <summary>       
        /// 商品名称，最长14个汉字，1个汉字相当于2个字符
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 价格类型，1：一口价（只需要传入price，price2不传）
        /// 2：价格区间（price字段为左边界，price2字段为右边界，price和price2必传）
        /// 3：显示折扣价（price字段为原价，price2字段为现价， price和price2必传）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("priceType")]
        public int PriceType { get; set; }

        /// <summary>       
        /// 数字，最多保留两位小数，单位元
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>       
        /// 数字，最多保留两位小数，单位元
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("price2")]
        public float Price2 { get; set; }

        /// <summary>       
        /// 商品详情页的小程序路径，路径参数存在 url 的，该参数的值需要进行 encode 处理再填入
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>       
        /// 当商品为第三方小程序的商品则填写为对应第三方小程序的appid，自身小程序商品则为''
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("thirdPartyAppid")]
        public string ThirdPartyAppid { get; set; } = string.Empty;
    }
}

