using System;
namespace iMouse.WeiXin.MiniProgram.User
{
    public class GetPhoneNumberRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/getuserphonenumber";

        /// <summary>
        /// 手机号获取凭证
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;
    }


    public class GetPhoneNumberResponse : BaseResponse
    {
        /// <summary>
        /// 用户手机号信息
        /// </summary>
        [JsonProperty("phone_info")]
        public PhoneNumberInfo? PhoneInfo { get; set; }
    }


    /// <summary>
    /// 用户手机号信息
    /// </summary>
    public class PhoneNumberInfo
    {
        /// <summary>
        /// 用户绑定的手机号（国外手机号会有区号）
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 没有区号的手机号
        /// </summary>
        [JsonProperty("purePhoneNumber")]
        public string PurePhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 区号
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; } = string.Empty;
    }

    /// <summary>
    /// 数据水印
    /// </summary>
    public class WatermarkInfo
    {
        /// <summary>
        /// 	用户获取手机号操作的时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;
    }
}

