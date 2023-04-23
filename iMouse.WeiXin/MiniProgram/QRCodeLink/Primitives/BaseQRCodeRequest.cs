using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public abstract class BaseQRCodeRequest : BaseTokenRequest
    {
    }


    public class QRCodeRequestLineColor
    {
        /// <summary>
        /// 默认值{"r":0,"g":0,"b":0} ；auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("r")]
        public byte Red { get; set; } = 0;

        /// <summary>
        /// 默认值{"r":0,"g":0,"b":0} ；auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("g")]
        public byte Green { get; set; } = 0;

        /// <summary>
        /// 默认值{"r":0,"g":0,"b":0} ；auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("b")]
        public byte Blue { get; set; } = 0;
    }
}

