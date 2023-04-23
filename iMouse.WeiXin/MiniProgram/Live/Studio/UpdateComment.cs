using System;
namespace iMouse.WeiXin.MiniProgram.Live.Studio
{
    public class UpdateCommentRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxaapi/broadcast/room/updatecomment";

        /// <summary>       
        /// 房间ID
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>       
        /// 1-禁言，0-取消禁言
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("banComment")]
        public int BanComment { get; set; }
    }

    public class UpdateCommentResponse : BaseResponse
    {


    }
}

