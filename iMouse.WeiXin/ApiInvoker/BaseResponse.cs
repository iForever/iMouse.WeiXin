using System;
using Newtonsoft.Json;

namespace iMouse.WeiXin.ApiInvoker
{
    public abstract class BaseResponse
    {
        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string ErrMsg { get; set; } = string.Empty;
    }
}
