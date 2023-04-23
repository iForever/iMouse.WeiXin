using System;
namespace iMouse.WeiXin.Offical.UserManage.UserTags
{
    public class DeleteTagRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/cgi-bin/tags/delete";

        [JsonProperty("tag")]
        public DeleteTagRequestTagInfo? Tag { get; set; }
    }

    public class DeleteTagRequestTagInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DeleteTagResponse : BaseResponse
    { }
}

