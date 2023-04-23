using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class AddMessageTemplateRequest : BaseRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/newtmpl/addtemplate";

        /// <summary>
        /// 模板标题 id，可通过接口获取，也可登录小程序后台查看获取
        /// </summary>
        [JsonProperty("tid")]
        public string TemplateTitleId { get; set; } = string.Empty;

        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合
        /// </summary>
        [JsonProperty("kidList")]
        public List<int> KeywordIds { get; set; } = new List<int>();

        /// <summary>
        /// 服务场景描述，15个字以内
        /// </summary>
        [JsonProperty("sceneDesc")]
        public string SceneDesc { get; set; } = string.Empty;
    }


    public class AddMessageTemplateResponse : BaseResponse
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送小程序订阅消息时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PrimaryTemplateId { get; set; } = string.Empty;
    }
}

