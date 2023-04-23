using System;
namespace iMouse.WeiXin.MiniProgram.Security.Primitives
{
    public class GetUserRiskRankRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/getuserriskrank";

        /// <summary>       
        /// 小程序appid
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>       
        /// 用户的openid
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>       
        /// 场景值，0:注册，1:营销作弊
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("scene")]
        public int Scene { get; set; }

        /// <summary>       
        /// 用户手机号
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("mobile_no")]
        public string MobileNo { get; set; } = string.Empty;

        /// <summary>       
        /// 用户访问源ip
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("client_ip")]
        public string ClientIp { get; set; } = string.Empty;

        /// <summary>       
        /// 用户邮箱地址
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>       
        /// 额外补充信息
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("extended_info")]
        public string ExtendedInfo { get; set; } = string.Empty;

        /// <summary>       
        /// 默认值false。false：正式调用，true：测试调用
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("is_test")]
        public bool IsTest { get; set; }
    }

    public class GetUserRiskRankResponse : BaseResponse
    {
        /// <summary>       
        /// 用户风险等级，合法值为0,1,2,3,4，数字越大风险越高。
        /// </summary>        
        [JsonProperty("risk_rank")]
        public int RiskRank { get; set; }

        /// <summary>       
        /// 唯一请求标识，标记单次请求
        /// </summary>        
        [JsonProperty("unoin_id")]
        public int UnoinId { get; set; }
    }
}

