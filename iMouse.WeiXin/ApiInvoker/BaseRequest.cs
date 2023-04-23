using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace iMouse.WeiXin.ApiInvoker
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class BaseRequest
    {
        [JsonIgnore]
        internal virtual string ApiHost => "https://api.weixin.qq.com";

        /// <summary>
        /// URL hash
        /// </summary>
        [JsonIgnore]
        internal virtual string Fragment => "";

        [JsonIgnore]
        internal abstract string Endpoint { get; }

        [JsonIgnore]
        internal virtual HttpMethod RequestMethod { get; } = HttpMethod.Get;

        [JsonIgnore]
        internal virtual HttpContent RequestContent
        {
            get
            {

                var szJson = JsonConvert.SerializeObject(this);
                Console.WriteLine(szJson);

                var content = new StringContent(szJson, Encoding.UTF8, "application/json");
                return content;
            }
        }

        [JsonIgnore]
        internal virtual string ApiURL
        {
            get
            {
                StringBuilder sb = new StringBuilder(ApiHost).Append(Endpoint);
                var properties = this.GetType().GetProperties();

                if (properties != null && properties.Length > 0)
                {
                    var querys = new List<string>();
                    foreach (var item in properties)
                    {
                        var attr = item.GetCustomAttribute<QueryParamaterAttribute>(true);
                        if (attr != null && attr.TryQueryParamterValue(item, this, out string? value))
                        {
                            querys.Add($"{attr.ParamaterName}={value}");
                        }
                    }
                    _ = sb.Append('?').Append(string.Join('&', querys));
                }

                if (!string.IsNullOrWhiteSpace(Fragment))
                {
                    _ = sb.Append("#").Append(Fragment.TrimStart('#'));
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// AppName - 定义在WeiXinOptions中的 App名称
        /// </summary>
        [JsonIgnore]
        public string AppName { get; set; } = string.Empty;

    }


}
