using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Offical.JSInterop.Primitives
{
    public class JsConfigParameters
    {
        public string NonceString { get; set; } = string.Empty;

        public long Timestamp { get; set; }

        public string Signature { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public JsConfigParameters()
        {
            Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            NonceString = StringHelper.GenerateNonceString();
        }

        public JsConfigParameters(string url) : this()
        {
            if (string.IsNullOrWhiteSpace(url)) return;

            var sharpIndex = url.LastIndexOf("#");
            var trimLength = sharpIndex > -1 ? sharpIndex : url.Length;
            Url = url.Substring(0, trimLength);
        }

        public SortedSet<string> GetSortedKeyValues()
        {
            return new SortedSet<string>
            {
                $"noncestr={NonceString}",
                $"timestamp={Timestamp}",
                $"url={Url}"
            };
        }
    }
}

