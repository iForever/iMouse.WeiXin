using System;
using System.Collections.Generic;
using System.Text;

namespace iMouse.WeiXin.Utilities
{
    public class WeiXinHelper
    {
        /// <summary>
        /// 微信签名 - 主要用户微信支付
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dicts"></param>
        /// <returns></returns>
        public static string Md5Hash(string key, SortedSet<string> keyValues)
        {
            var szText = String.Join('&', keyValues.ToArray());
            return SecurityHelper.MD5Hash(szText).ToUpperInvariant();
        }

        /// <summary>
        /// 微信签名 - 主要用户公众号JS-SDK签名
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public static string Sha1Hash(SortedSet<string> keyValues)
        {
            var szText = String.Join('&', keyValues.ToArray());
            return SecurityHelper.SHA1Hash(szText);
        }
    }
}

