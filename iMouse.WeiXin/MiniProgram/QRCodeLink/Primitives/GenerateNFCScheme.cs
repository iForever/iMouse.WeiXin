using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class GenerateNFCSchemeRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonProperty]
        internal override string Endpoint => "/wxa/generatenfcscheme";

        /// <summary>
        /// 跳转到的目标小程序信息。
        /// </summary>
        [JsonProperty("jump_wxa")]
        public GenerateSchemeRequestJumpInfo? JumpInfo { get; set; }

        /// <summary>
        /// scheme对应的设备model_id
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; } = string.Empty;

        /// <summary>
        /// scheme对应的设备sn，仅一机一码时填写
        /// </summary>
        [JsonProperty("sn")]
        public string SN { get; set; } = string.Empty;
    }

    public class GenerateNFCSchemeResponse : BaseResponse
    {
        /// <summary>
        /// 生成的小程序 scheme 码
        /// </summary>
        [JsonProperty("openlink")]
        public string OpenLink { get; set; } = string.Empty;
    }
}

