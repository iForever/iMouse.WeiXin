using System;
namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class UpdateTagRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/update";


        [JsonProperty("tag")]
        public UpdateTagRequestTagInfo? Tag { get; set; }
    }


    public class UpdateTagRequestTagInfo
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

    public class UpdateTagResponse : BaseResponse
    {

    }
}

