using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class SendMessageRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/message/subscribe/send";

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
        /// 跳转小程序类型：developer为开发版；trial为体验版；formal为正式版；
        /// 默认为正式版
        /// </summary>
        [JsonProperty("miniprogram_state")]
        public string MiniprogramState { get; set; } = "formal";

        /// <summary>
        /// ”进入小程序查看”的语言类型，支持zh_CN(简体中文)、en_US(英文)、zh_HK(繁体中文)、zh_TW(繁体中文)，默认为zh_CN
        /// </summary>
        [JsonProperty("lang")]
        public string Lang { get; set; } = "zh_CN";


        /// <summary>
        /// 模板内容，格式形如 { "key1": { "value": any }, "key2": { "value": any } }的object
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, TemplateMessageDataItem> Data { get; set; } = new Dictionary<string, TemplateMessageDataItem>();
    }

    public class SendMessageResponse : BaseResponse
    {

    }


}

