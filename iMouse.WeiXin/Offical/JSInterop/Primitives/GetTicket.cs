using System;
namespace iMouse.WeiXin.Offical.JSInterop.Primitives
{
    public class GetTicketRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/cgi-bin/ticket/getticket";

        [QueryParamater("type")]
        internal string RequestType => "jsapi";
    }


    public class GetTicketResponse : BaseResponse
    {
        [JsonProperty("tickert")]
        public string Ticket { get; set; } = string.Empty;

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime CreateAt { get; } = DateTime.Now;

        [JsonIgnore]
        public bool IsExpired => (CreateAt.AddSeconds(ExpiresIn) > DateTime.Now);
    }
}

