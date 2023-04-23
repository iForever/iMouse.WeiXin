using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class GetQRCodeRequest : BaseQRCodeRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// Endpoint
        /// </summary>
        [JsonIgnore]
        internal override string Endpoint => "/wxa/getwxacode";

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

        /// <summary>
        /// 默认值false；自动配置线条颜色，如果颜色依然是黑色，则说明不建议配置主色调
        /// </summary>
        [JsonProperty("auto_color")]
        public bool AutoColor { get; set; } = false;

        /// <summary>
        /// 默认值false；是否需要透明底色，为 true 时，生成透明底色的小程序码
        /// </summary>
        [JsonProperty("is_hyaline")]
        public bool IsHyaline { get; set; } = false;

        /// <summary>
        /// 默认值{"r":0,"g":0,"b":0} ；auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("line_color")]
        public QRCodeRequestLineColor? LineColor { get; set; }
    }

}

