using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.UserManage.UserInfo
{
    public class GetUserListRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/cgi-bin/user/get";

        /// <summary>
        /// 第一个拉取的OPENID，不填默认从头开始拉取
        /// </summary>
        [QueryParamater("next_openid")]
        public string NextOpenId { get; set; } = string.Empty;


    }

    public class GetUserListResponse : BaseResponse
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
        public GetUserListResponseDataInfo? Data { get; set; }
    }

    public class GetUserListResponseDataInfo
    {
        /// <summary>
        /// openid 列表
        /// </summary>
        [JsonProperty("openid")]
        public List<string>? OpenIds { get; set; }
    }
}

