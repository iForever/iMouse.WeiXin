using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Models
{
    public class TemplateMessageInfo
    {
        [JsonIgnore]
        public List<string> Users { get; set; } = new List<string>();

        [JsonProperty(PropertyName = "touser")]
        public string ToUser { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "template_id")]
        public string TemplateId { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "topcolor")]
        public string TopColor { get; set; } = "#ff0000";

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, TemplateMessageDataItem> Data { get; set; } = new Dictionary<string, TemplateMessageDataItem>();
    }

    public class TemplateMessageDataItem
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// 模板内容字体颜色，不填默认为黑色
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string? Color { get; set; }
    }
}

