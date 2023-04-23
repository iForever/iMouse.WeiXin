using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class GenerateShortLinkRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonProperty]
        internal override string Endpoint => "/wxa/genwxashortlink";

        /// <summary>
        /// 通过 Short Link 进入的小程序页面路径，必须是已经发布的小程序存在的页面，可携带 query，最大1024个字符
        /// </summary>
        [JsonProperty("page_url")]
        public string PageURL { get; set; } = string.Empty;

        /// <summary>
        /// 页面标题，不能包含违法信息，超过20字符会用... 截断代替
        /// </summary>
        [JsonProperty("page_title")]
        public string PageTitle { get; set; } = string.Empty;

        /// <summary>
        /// 默认值false。生成的 Short Link 类型，短期有效：false，永久有效：true
        /// </summary>
        [JsonProperty("is_permanent")]
        public bool IsPermanent { get; set; }
    }

    public class GenerateShortLinkResponse : BaseResponse
    {
        /// <summary>
        /// 生成的小程序 Short Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; } = string.Empty;
    }
}

