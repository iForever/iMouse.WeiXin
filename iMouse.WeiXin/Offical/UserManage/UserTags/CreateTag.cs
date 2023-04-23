using System;
namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class CreateTagRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/create";

        [JsonProperty("tag")]
        public CreateTagRequestTagInfo? Tag { get; set; }
    }

    public class CreateTagRequestTagInfo
    {
        /// <summary>
        /// 标签名（30个字符以内）
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }


    public class CreateTagResponse : BaseResponse
    {
        [JsonProperty("tag")]
        public CreateTagResponseTagInfo? Tag { get; set; }
    }

    public class CreateTagResponseTagInfo
    {
        /// <summary>
        /// 标签id，由微信分配
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 标签名，UTF8编码
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}

