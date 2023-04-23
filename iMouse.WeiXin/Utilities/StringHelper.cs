using System;
using System.Text;

namespace iMouse.WeiXin.Utilities
{
    public static class StringHelper
    {
        public static string GenerateNonceString(int len = 16)
        {
            var chars = "0123456789ABCDEFGHIJKMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
            var sb = new StringBuilder(len);
            Random rd = new Random();
            for (int i = 0; i < len; i++)
            {
                sb.Append(chars[rd.Next(chars.Length)]);
            }
            return sb.ToString();
        }
    }
}

