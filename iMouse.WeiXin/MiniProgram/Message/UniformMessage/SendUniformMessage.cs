using System;
namespace iMouse.WeiXin.MiniProgram.Message.UniformMessage
{
    public class SendUniformMessageRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/message/wxopen/template/uniform_send";

        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// 用户openid，可以是小程序的openid，也可以是mp_template_msg.appid对应的公众号的openid
        /// </summary>
        [JsonProperty(PropertyName = "touser")]
        public string ToUser { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板消息相关的信息，可以参考公众号模板消息接口
        /// </summary>
        [JsonProperty("mp_template_msg")]
        public MPTemplateMsg? MPTemplateMsg { get; set; }

    }

    public class MPTemplateMsg
    {
        /// <summary>
        /// 公众号appid，要求与小程序有绑定且同主体
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板消息所要跳转的url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板消息所要跳转的小程序，小程序的必须与公众号具有绑定关系
        /// </summary>
        [JsonProperty("miniprogram")]
        public string MiniProgram { get; set; } = string.Empty;


        /// <summary>
        /// 公众号模板消息的数据
        /// </summary>
        [JsonProperty("data")]
        public string Data
        {
            get
            {
                if (TemplateMessage == null)
                    return string.Empty;

                return JsonConvert.SerializeObject(TemplateMessage);
            }
        }

        /// <summary>
        /// 公众号模板消息
        /// </summary>
        [JsonIgnore]
        public TemplateMessageInfo? TemplateMessage { get; set; }
    }


    public class SendUniformMessageResponse : BaseResponse
    {

    }
}

