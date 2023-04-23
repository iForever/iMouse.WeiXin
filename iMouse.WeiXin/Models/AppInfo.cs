using System;
namespace iMouse.WeiXin.Models
{
    public class AppInfo
    {
        public string Name { get; set; } = string.Empty;

        public string AppId { get; set; } = string.Empty;

        public string AppSecret { get; set; } = string.Empty;

        public AccessTokenInfo? AccessToken { get; set; }
    }
}

