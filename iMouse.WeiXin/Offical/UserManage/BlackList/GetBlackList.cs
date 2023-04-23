using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.BlackList
{
    public class GetBlackListRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/members/getblacklist";

        /// <summary>
        /// 当 begin_openid 为空时，默认从开头拉取。
        /// </summary>
        [JsonProperty("begin_openid")]
        public string BeginOpenId { get; set; } = string.Empty;
    }


    public class GetBlackListResponse : BaseResponse
    {
        /// <summary>
        /// 关注该公众账号的总用户数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 拉取的 OPENID 个数，最大值为10000
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 拉取列表的最后一个用户的OPENID
        /// </summary>
        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 列表数据，OPENID的列表
        /// </summary>
        [JsonProperty("data")]
        public GetBlackListResponseDataInfo? Data { get; set; }
    }

    public class GetBlackListResponseDataInfo
    {
        /// <summary>
        /// openid 列表
        /// </summary>
        [JsonProperty("openid")]
        public List<string>? OpenIds { get; set; }
    }
}

