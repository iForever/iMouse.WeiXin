using System;
using Newtonsoft.Json;

namespace iMouse.WeiXin.Models
{
    public class UserSummaryInfo
    {
        public string OpenId { get; set; } = string.Empty;

        public string UnionId { get; set; } = string.Empty;

        public string NickName { get; set; } = string.Empty;

        [JsonProperty("avatarUrl")]
        public string Avatar { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public Gender Gender { get; set; } = Gender.Unknown;

        public string Language { get; set; } = string.Empty;

        public string Province { get; set; } = string.Empty;
    }
}
