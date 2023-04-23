using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class GenerateSchemeRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonProperty]
        internal override string Endpoint => "/wxa/generatescheme";

        /// <summary>
        /// 跳转到的目标小程序信息。
        /// </summary>
        [JsonProperty("jump_wxa")]
        public GenerateSchemeRequestJumpInfo? JumpInfo { get; set; }

        /// <summary>
        /// 默认值false。生成的 scheme 码类型，到期失效：true，永久有效：false。
        /// 注意，永久有效 scheme 和有效时间超过180天的到期失效 scheme 的总数上限为10万个，
        /// 详见获取 URL scheme，生成 scheme 码前请仔细确认。
        /// </summary>
        [JsonProperty("is_expire")]
        public bool IsExpire { get; set; } = false;

        /// <summary>
        /// 到期失效的 scheme 码的失效时间，为 Unix 时间戳。生成的到期失效 scheme 码在该时间前有效。
        /// 最长有效期为1年。is_expire 为 true 且 expire_type 为 0 时必填
        /// </summary>
        [JsonProperty("expire_type")]
        public int ExpireType { get; set; }

        /// <summary>
        /// 到期失效的 scheme 码的失效间隔天数。
        /// 生成的到期失效 scheme 码在该间隔时间到达前有效。最长间隔天数为365天。
        /// is_expire 为 true 且 expire_type 为 1 时必填
        /// </summary>
        [JsonProperty("expire_interval")]
        public int ExpireInterval { get; set; }

        /// <summary>
        /// 到期失效的 scheme 码的失效时间，为 Unix 时间戳。
        /// 生成的到期失效 scheme 码在该时间前有效。最长有效期为1年。
        /// is_expire 为 true 且 expire_type 为 0 时必填
        /// </summary>
        [JsonProperty("expire_time")]
        public long ExpireTime { get; set; }

    }

    public class GenerateSchemeRequestJumpInfo
    {
        /// <summary>
        /// 通过 scheme 码进入的小程序页面路径，必须是已经发布的小程序存在的页面，不可携带 query。path 为空时会跳转小程序主页。
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// 通过 scheme 码进入小程序时的 query，最大1024个字符，只支持数字，大小写英文以及部分特殊字符：`!#$&'()*+,/:;=?@-._~%``
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; } = string.Empty;

        /// <summary>
        /// 默认值"release"。要打开的小程序版本。正式版为"release"，体验版为"trial"，开发版为"develop"，仅在微信外打开时生效。
        /// </summary>
        [JsonProperty("env_version")]
        public string Environment { get; set; } = "release";
    }

    public class GenerateSchemeResponse : BaseResponse
    {
        /// <summary>
        /// 生成的小程序 scheme 码
        /// </summary>
        [JsonProperty("openlink")]
        public string OpenLink { get; set; } = string.Empty;

    }
}

