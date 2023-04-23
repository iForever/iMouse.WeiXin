using System;
namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class DeleteMessageTemplateRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/newtmpl/deltemplate";

        /// <summary>
        /// 要删除的模板id
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PrimaryTemplateId { get; set; } = string.Empty;
    }

    public class DeleteMessageTemplateResponse : BaseResponse { }
}

