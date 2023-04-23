using System;
namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class BaseQRCodeResponse : BaseResponse
    {
        /// <summary>
        /// 成功时返回的图片字节
        /// </summary>
        [JsonIgnore]
        public byte[]? QRCodeData { get; set; }
    }
}

