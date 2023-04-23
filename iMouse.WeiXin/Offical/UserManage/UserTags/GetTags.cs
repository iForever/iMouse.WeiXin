using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class GetTagsRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/cgi-bin/tags/get";
    }

    public class GetTagsResponse : BaseResponse
    {
        [JsonProperty("tags")]
        public List<TagInfo>? Tags { get; set; }
    }

    public class TagInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

