using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class GetPubTemplateTitleListRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/wxaapi/newtmpl/getpubtemplatetitles";

        /// <summary>
        /// 类目 id，多个用逗号隔开
        /// </summary>
        [QueryParamater("ids", isRequired: true)]
        public string Ids { get; set; } = string.Empty;

        /// <summary>
        /// 用于分页，表示从 start 开始。从 0 开始计数
        /// </summary>
        [QueryParamater("start", isRequired: true)]
        public string Start { get; set; } = string.Empty;

        /// <summary>
        /// 用于分页，表示拉取 limit 条记录。最大为 30
        /// </summary>
        [QueryParamater("limit", isRequired: true)]
        public int Limit { get; set; }
    }


    public class GetPubTemplateTitleListResponse : BaseResponse
    {
        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 模板标题列表
        /// </summary>
        [JsonProperty("data")]
        public List<TemplateTitleInfo>? TemplateTitles { get; set; }
    }

    public class TemplateTitleInfo
    {
        /// <summary>
        /// 模版标题 id
        /// </summary>
        [JsonProperty("tid")]
        public int TemplateId { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty("type")]
        public int TemplateType { get; set; }

        /// <summary>
        /// 模版所属类目 id
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }

}

