using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class BizSendMessageRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/message/subscribe/bizsend";

        /// <summary>
        /// 所需下发的订阅模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// <para>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。<br />
        /// 支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转
        /// </para>
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; } = string.Empty;

        /// <summary>
        /// 接收者（用户）的 openid
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; set; } = string.Empty;

        /// <summary>
        /// 跳转小程序时填写，格式如{ "appid": "pagepath": { "value": any } }
        /// </summary>
        [JsonProperty("miniprogram")]
        public BizSendMessageRequestMiniprogram? Miniprogram { get; set; }


        /// <summary>
        /// 模板内容，格式形如 { "key1": { "value": any }, "key2": { "value": any } }的object
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, TemplateMessageDataItem> Data { get; set; } = new Dictionary<string, TemplateMessageDataItem>();
    }

    public class BizSendMessageRequestMiniprogram
    {
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        [JsonProperty("pagepath")]
        public string PagePath { get; set; } = string.Empty;
    }

    public class BizSendMessageResponse : BaseResponse
    {

    }
}

