using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.User
{
    /// <summary>
    /// 获取用户encryptKey 请求模型
    /// </summary>
    public class GetUserEncryptKeyRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// Endpoint
        /// </summary>
        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/getuserencryptkey";

        /// <summary>
        /// 用户的openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 用 sessionkey 对空字符串签名得到的结果。session_key可通过code2Session接口获得。
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 签名方法，只支持 hmac_sha256
        /// </summary>
        [JsonProperty("sig_method")]
        public string SignatureMethod { get; } = "hmac_sha256";
    }

    /// <summary>
    /// 获取用户encryptKey 响应模型
    /// </summary>
    public class GetUserEncryptKeyResponse : BaseResponse
    {
        /// <summary>
        /// 用户最近三次的加密 key 列表
        /// </summary>
        [JsonProperty("key_info_list")]
        public List<UserEncryptKeyInfo>? KeyInfos { get; set; }
    }

    public class UserEncryptKeyInfo
    {
        /// <summary>
        /// 	加密key
        /// </summary>
        [JsonProperty("encrypt_key")]
        public string EncryptKey { get; set; } = string.Empty;

        /// <summary>
        /// key的版本号
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// 剩余有效时间
        /// </summary>
        [JsonProperty("expire_in")]
        public int ExpireIn { get; set; }

        /// <summary>
        /// 加密向量iv
        /// </summary>
        [JsonProperty("iv")]
        public string IV { get; set; } = string.Empty;

        /// <summary>
        /// 创建 key 的时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }
    }
}

