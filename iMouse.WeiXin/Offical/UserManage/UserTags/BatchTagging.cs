using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class BatchTaggingRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/members/batchtagging";

        [JsonProperty("openid_list")]
        public List<string>? OpenIdList { get; set; }

        [JsonProperty("tagid")]
        public int TagId { get; set; }
    }

    public class BatchTaggingResponse : BaseResponse
    {

    }
}

