using System;
namespace iMouse.WeiXin.MiniProgram.Security.Primitives
{
    public class MediaCheckAsyncRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/media_check_async";

        /// <summary>       
        /// 要检测的图片或音频的url，支持图片格式包括 jpg , jepg, png, bmp, gif（取首帧），
        /// 支持的音频格式包括mp3, aac, ac3, wma, flac, vorbis, opus, wav
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("media_url")]
        public string MediaUrl { get; set; } = string.Empty;

        /// <summary>       
        /// 1:音频;2:图片
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("media_type")]
        public int MediaType { get; set; }

        /// <summary>       
        /// 接口版本号，2.0版本为固定值2
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>       
        /// 场景枚举值（1 资料；2 评论；3 论坛；4 社交日志）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("scene")]
        public int Scene { get; set; }

        /// <summary>       
        /// 用户的openid（用户需在近两小时访问过小程序）
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;
    }

    public class MediaCheckAsyncResponse : BaseResponse
    {
        /// <summary>       
        /// 唯一请求标识，标记单次请求
        /// </summary>        
        [JsonProperty("trace_id")]
        public string TraceId { get; set; } = string.Empty;
    }
}

