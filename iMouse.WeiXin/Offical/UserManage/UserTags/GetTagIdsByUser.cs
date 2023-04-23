using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class GetTagIdsByUserRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/getidlist";

        [JsonProperty("openid")]
        public string OpenId { get; set; } = string.Empty;
    }

    public class GetTagIdsByUserResponse : BaseResponse
    {
        [JsonProperty("tagid_list")]
        public List<int>? TagIds { get; set; }
    }
}

