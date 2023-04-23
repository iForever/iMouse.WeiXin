using System;
using iMouse.WeiXin.MiniProgram.Authorize;

namespace iMouse.WeiXin.Models
{
    public class UserSessionInfo
    {
        public string OpenId { get; set; } = string.Empty;

        public string SessionKey { get; set; } = string.Empty;

        public string UnionId { get; set; } = string.Empty;

        public static implicit operator UserSessionInfo?(AuthorizeCode2SessionResponse session)
        {
            if (session == null) return null;
            var info = new UserSessionInfo
            {
                OpenId = session.OpenId,
                SessionKey = session.SessionKey,
                UnionId = session.UnionId
            };
            return info;
        }
    }
}
