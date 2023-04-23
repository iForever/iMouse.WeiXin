using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    /// <summary>
    /// 查询 scheme 码 
    /// </summary>
    public class QuerySchemeRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/queryscheme";

        /// <summary>
        /// 小程序 scheme 码
        /// </summary>
        [JsonProperty("scheme")]
        public string Scheme { get; set; } = string.Empty;

    }

    public class QuerySchemeResponse : BaseResponse
    {
        /// <summary>
        /// scheme 配置
        /// </summary>
        [JsonProperty("scheme_info")]
        public SchemeInfo? SchemeInfo { get; set; }

        /// <summary>
        /// quota 配置
        /// </summary>
        [JsonProperty("scheme_quota")]
        public SchemeQuota? SchemeQuota { get; set; }
    }

    public class SchemeInfo
    {
        /// <summary>
        /// 小程序 appid
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 小程序页面路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// 小程序页面query
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; } = string.Empty;

        /// <summary>
        /// 创建时间，为 Unix 时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 到期失效时间，为 Unix 时间戳，0 表示永久生效
        /// </summary>
        [JsonProperty("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 要打开的小程序版本。正式版为"release"，体验版为"trial"，开发版为"develop"
        /// </summary>
        [JsonProperty("env_version")]
        public string EnvVersion { get; set; } = "release";
    }

    /// <summary>
    /// quota 配置
    /// </summary>
    public class SchemeQuota
    {
        /// <summary>
        /// 长期有效 scheme 已生成次数
        /// </summary>
        [JsonProperty("long_time_used")]
        public int LongTimeUsed { get; set; }

        /// <summary>
        /// 长期有效 scheme 生成次数上限
        /// </summary>
        [JsonProperty("long_time_limit")]
        public int LongTimeLimit { get; set; }
    }
}

