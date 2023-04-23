using System;
namespace iMouse.WeiXin.Models
{
    /// <summary>
    /// 接口调用凭据
    /// </summary>
    public class AccessTokenInfo
    {
        /// <summary>
        /// 凭据
        /// </summary>
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 存活时长
        /// </summary>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTimeOffset ExpiresAt { get; set; }


        public static implicit operator AccessTokenInfo?(GetAccessTokenResponse response)
        {
            if (response == null) return null;
            var info = new AccessTokenInfo
            {
                ExpiresIn = response.ExpiresIn,
                AccessToken = response.AccessToken,
                ExpiresAt = DateTimeOffset.Now.AddSeconds(response.ExpiresIn)
            };
            return info;
        }
    }
}
