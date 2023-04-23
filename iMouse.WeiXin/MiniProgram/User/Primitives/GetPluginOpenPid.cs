using System;
using System.Net.Http;
using iMouse.WeiXin.ApiInvoker;
using Newtonsoft.Json;

namespace iMouse.WeiXin.MiniProgram.User
{
    public class GetPluginOpenPidRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        /// <summary>
        /// Endpoint
        /// </summary>
        [JsonIgnore]
        internal override string Endpoint => "/wxa/getpluginopenpid";

        /// <summary>
        /// 通过 wx.pluginLogin 获得的插件用户标志凭证 code，有效时间为5分钟，一个 code 只能获取一次 openpid。
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;


    }

    public class GetPluginOpenPidResponse : BaseResponse
    {
        [JsonProperty("openpid")]
        public string OpenId { get; set; } = string.Empty;
    }
}

