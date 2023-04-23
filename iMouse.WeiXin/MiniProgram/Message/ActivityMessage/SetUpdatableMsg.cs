using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Message.ActivityMessage
{
    /// <summary>
    /// 修改动态消息
    /// <para>
    /// 具体说明请查看: <see cref="https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-message-management/updatable-message/setUpdatableMsg.html"/>
    /// </para>
    /// </summary>
    public class SetUpdatableMessageRequest : BaseRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/message/wxopen/updatablemsg/send";

        /// <summary>
        /// target_state
        /// <para>
        /// 0 - 未开始
        /// 1 - 已开始
        /// </para>
        /// </summary>
        [JsonProperty("target_state")]
        public int TargetState { get; set; }

        [JsonProperty("template_info")]
        public TemplateInfo? TemplateInfo { get; set; }
    }


    public class TemplateInfo
    {
        [JsonProperty("parameter_list")]
        public List<ParameterInfo>? Parameters { get; set; }
    }

    public class ParameterInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }

    public class SetUpdatableMessageResponse : BaseResponse
    {

    }
}

