using System;


namespace iMouse.WeiXin.MiniProgram.User
{
    public class CheckEncryptedDataRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// Endpoint
        /// </summary>
        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/checkencryptedmsg";

        /// <summary>
        /// 加密数据的sha256，通过Hex（Base16）编码后的字符串
        /// </summary>
        [JsonProperty("encrypted_msg_hash")]
        public string EncryptedMsgHash { get; set; } = string.Empty;
    }

    public class CheckEncryptedDataResponse : BaseResponse
    {
        /// <summary>
        /// 是否是合法的数据
        /// </summary>
        [JsonProperty("vaild")]
        public bool Vaild { get; set; }

        /// <summary>
        /// 加密数据生成的时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }
    }
}

