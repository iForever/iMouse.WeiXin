using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class GetTemplateListRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/wxaapi/newtmpl/gettemplate";
    }

    public class GetTemplateListResponse : BaseResponse
    {
        /// <summary>
        /// 模板列表
        /// </summary>
        [JsonProperty("data")]
        public List<TemplateInfo>? Templates { get; set; }
    }


    public class TemplateInfo
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送小程序订阅消息时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PrimaryTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 模版内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 模板内容示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; } = string.Empty;

        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty("type")]
        public int TemplateType { get; set; }

        /// <summary>
        /// 枚举参数值范围
        /// </summary>
        public List<KeywordEnumValueInfo>? KeywordEnumValues { get; set; }
    }


    public class KeywordEnumValueInfo
    {
        /// <summary>
        /// 枚举参数的 key
        /// </summary>
        [JsonProperty("keywordCode")]
        public string KeywordCode { get; set; } = string.Empty;

        /// <summary>
        /// 枚举参数值范围列表
        /// </summary>
        [JsonProperty("enumValueList")]
        public List<string>? EnumValues { get; set; }
    }
}

