using System;
namespace iMouse.WeiXin.MiniProgram.User
{
    public class GetPaidUnionIdRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/wxa/getpaidunionid";

        /// <summary>
        /// 付用户唯一标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 微信支付分配的商户号，和商户订单号配合使用
        /// </summary>
        [JsonProperty("mch_id")]
        public string MerchantchId { get; set; } = string.Empty;

        /// <summary>
        /// 微信支付商户订单号，和商户号配合使用
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; } = string.Empty;

    }

    public class GetPaidUnionIdResponse : BaseResponse
    {
        /// <summary>
        /// 用户唯一标识，调用成功后返回
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; } = string.Empty;
    }

}

