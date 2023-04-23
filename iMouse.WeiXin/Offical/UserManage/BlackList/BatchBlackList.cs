using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.BlackList
{
    public class BatchBlackListRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/members/batchblacklist";

        /// <summary>
        /// 需要拉入黑名单的用户的openid，一次拉黑最多允许20个
        /// </summary>
        [JsonProperty("openid_list")]
        public List<string>? OpenIds { get; set; }
    }

    public class BatchBlackListResponse : BaseResponse
    {

    }
}

