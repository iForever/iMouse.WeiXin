using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Security.Primitives
{
    public class MsgSecCheckRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/msg_sec_check";

        /// <summary>       
        /// 需检测的文本内容，文本字数的上限为2500字，需使用UTF-8编码
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;

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

        /// <summary>       
        /// 文本标题，需使用UTF-8编码
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>       
        /// 用户昵称，需使用UTF-8编码
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("nickname")]
        public string NickName { get; set; } = string.Empty;

        /// <summary>       
        /// 个性签名，该参数仅在资料类场景有效(scene=1)，需使用UTF-8编码
        /// 是否必须 - 否
        /// </summary>        
        [JsonProperty("signature")]
        public string Signature { get; set; } = string.Empty;
    }

    public class MsgSecCheckResponse : BaseResponse
    {
        /// <summary>
        /// 详细检测结果
        /// </summary>
        [JsonProperty("detail")]
        public MsgSecCheckResponseDetailInfo? Detail { get; set; }

        /// <summary>       
        /// 唯一请求标识，标记单次请求
        /// </summary>        
        [JsonProperty("trace_id")]
        public string TraceId { get; set; } = string.Empty;

        /// <summary>       
        /// 综合结果
        /// </summary>        
        [JsonProperty("result")]
        public MsgSecCheckResponseResultInfo? Result { get; set; }
    }

    public class MsgSecCheckResponseDetailInfo
    {
        /// <summary>       
        /// 策略类型
        /// </summary>        
        [JsonProperty("strategy")]
        public string Strategy { get; set; } = string.Empty;

        /// <summary>       
        /// 错误码，仅当该值为0时，该项结果有效
        /// </summary>        
        [JsonProperty("errcode")]
        public int Errcode { get; set; }

        /// <summary>       
        /// 建议，有risky、pass、review三种值
        /// </summary>        
        [JsonProperty("suggest")]
        public string Suggest { get; set; } = string.Empty;

        /// <summary>       
        /// 命中标签枚举值，100 正常；10001 广告；20001 时政；20002 色情；20003 辱骂；20006 违法犯罪；20008 欺诈；20012 低俗；20013 版权；21000 其他
        /// </summary>        
        [JsonProperty("label")]
        public int Label { get; set; }

        /// <summary>       
        /// 命中的自定义关键词
        /// </summary>        
        [JsonProperty("keyword")]
        public string Keyword { get; set; } = string.Empty;

        /// <summary>       
        /// 0-100，代表置信度，越高代表越有可能属于当前返回的标签（label）
        /// </summary>        
        [JsonProperty("prob")]
        public int Prob { get; set; }
    }

    public class MsgSecCheckResponseResultInfo
    {
        /// <summary>       
        /// 建议，有risky、pass、review三种值
        /// </summary>        
        [JsonProperty("suggest")]
        public string Suggest { get; set; } = string.Empty;

        /// <summary>       
        /// 命中标签枚举值，100 正常；10001 广告；20001 时政；20002 色情；20003 辱骂；20006 违法犯罪；20008 欺诈；20012 低俗；20013 版权；21000 其他
        /// </summary>        
        [JsonProperty("label")]
        public int Label { get; set; }
    }
}

