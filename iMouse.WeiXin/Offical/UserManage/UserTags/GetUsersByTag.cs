using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class GetUsersByTagRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/user/tag/get";

        [JsonProperty("tagid")]
        public int TagId { get; set; }

        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; } = string.Empty;
    }

    public class GetUsersByTagResponse : BaseResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; } = string.Empty;

        [JsonProperty("data")]
        public GetUsersByTagResponseDataInfo? Data { get; set; }
    }

    public class GetUsersByTagResponseDataInfo
    {
        [JsonProperty("openid")]
        public List<string>? OpenIds { get; set; }
    }
}

