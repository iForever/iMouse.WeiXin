using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class GetPubTemplateKeyWordsByIdRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/wxaapi/newtmpl/getpubtemplatekeywords";

        /// <summary>
        /// 模板标题 id，可通过接口获取
        /// </summary>
        [QueryParamater("tid")]
        public string TemplateId { get; set; } = string.Empty;
    }

    public class GetPubTemplateKeyWordsByIdResponse : BaseResponse
    {
        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonProperty("data")]
        public List<TemplateKeywordInfo>? TemplateKeywords { get; set; }
    }

    public class TemplateKeywordInfo
    {
        /// <summary>
        /// 关键词 id，选用模板时需要
        /// </summary>
        [JsonProperty("kid")]
        public int KeyId { get; set; }

        /// <summary>
        /// 关键词内容
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; } = string.Empty;

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; } = string.Empty;
    }
}

