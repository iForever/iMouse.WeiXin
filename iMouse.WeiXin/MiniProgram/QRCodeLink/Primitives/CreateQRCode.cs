using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class CreateQRCodeRequest : BaseQRCodeRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// Endpoint
        /// </summary>
        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/wxaapp/createwxaqrcode";

        /// <summary>
        /// 扫码进入的小程序页面路径，最大长度 128 字节，不能为空；对于小游戏，可以只传入 query 部分，来实现传参效果，
        /// 如：传入 "?foo=bar"，即可在 wx.getLaunchOptionsSync 接口中的 query 参数获取到 {foo:"bar"}。
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// 二维码的宽度，单位 px。默认值为430，最小 280px，最大 1280px
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; } = 430;
    }
}

