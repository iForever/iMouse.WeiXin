using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class QueryUrlLinkRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonProperty]
        internal override string Endpoint => "/wxa/query_urllink";

        /// <summary>
        /// 小程序 url_link
        /// </summary>
        [JsonProperty("url_link")]
        public string URLLink { get; set; } = string.Empty;

    }

    public class QueryUrlLinkResponse : BaseResponse
    {
        /// <summary>
        /// 官方文档暂无描述
        /// </summary>
        [JsonProperty("visit_openid")]
        public string VisitOpenId { get; set; } = string.Empty;

        /// <summary>
        /// url_link 配置
        /// </summary>
        [JsonProperty("url_link_info")]
        public QueryUrlLinkResponseUrlLinkInfo? URLLinkInfo { get; set; }

        /// <summary>
        /// quota 配置
        /// </summary>
        [JsonProperty("url_link_quota")]
        public QueryUrlLinkResponseUrlQuotaInfo? URLQuotaInfo { get; set; }
    }

    public class QueryUrlLinkResponseUrlLinkInfo
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
        /// 要打开的小程序版本。
        /// 正式版为"release"，体验版为"trial"，开发版为"develop"。
        /// </summary>
        [JsonProperty("env_version")]
        public string Environment { get; set; } = "release";
    }

    public class QueryUrlLinkResponseUrlQuotaInfo
    {
        /// <summary>
        /// 长期有效 url_link 已生成次数
        /// </summary>
        [JsonProperty("long_time_used")]
        public int LongTimeUsed { get; set; }

        /// <summary>
        /// 长期有效 url_link 生成次数上限
        /// </summary>
        [JsonProperty("long_time_limit")]
        public int LongTimeLimit { get; set; }
    }
}

