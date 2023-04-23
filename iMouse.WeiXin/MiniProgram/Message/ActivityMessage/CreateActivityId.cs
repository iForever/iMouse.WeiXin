using System;
namespace iMouse.WeiXin.MiniProgram.Message.ActivityMessage
{
    public class CreateActivityIdRequest : BaseRequest
    {
        internal override string Endpoint => "/cgi-bin/message/wxopen/activityid/create";

        /// <summary>
        /// <para>
        /// 为私密消息创建activity_id时，指定分享者为 unionid 用户。
        /// 其余用户不能用此activity_id分享私密消息。
        /// openid与 unionid 填一个即可。
        /// </para>
        /// </summary>
        [QueryParamater("unionid")]
        public string UnionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>
        /// 为私密消息创建activity_id时，指定分享者为 openid 用户。
        /// 其余用户不能用此activity_id分享私密消息。
        /// openid与 unionid 填一个即可。
        /// </para>
        /// </summary>
        [QueryParamater("openid")]
        public string OpenId { get; set; } = string.Empty;
    }

    public class CreateActivityIdResponse : BaseResponse
    {
        /// <summary>
        /// 动态消息的 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// activity_id 的过期时间戳。默认24小时后过期。
        /// </summary>
        [JsonProperty("expiration_time")]
        public long ExpirationTime { get; set; }
    }
}

