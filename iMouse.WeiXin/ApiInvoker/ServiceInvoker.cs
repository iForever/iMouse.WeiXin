using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace iMouse.WeiXin.ApiInvoker
{
    internal class ServiceInvoker
    {
        private static int MaxAllowRetryTimes { get; set; }

        private static int RequestTimeout { get; set; }

        static ServiceInvoker()
        {
            var options = ServiceProvider.GetOptions<WeiXinOptions>();
            MaxAllowRetryTimes = options?.MaxRetryTimes ?? 1;
            RequestTimeout = options?.RequestTimeout ?? 60;
        }

        private static async Task<string> GetRequestAccessToken(string appName, bool isForce = false)
        {
            var credentialService = ServiceProvider.GetService<ICredentialService>();
            GetAccessTokenResponse? response = null;
            if (credentialService != null)
            {
                response = await credentialService.GetAccessTokenAsync(appName, isForce);
            }
            return response?.AccessToken ?? string.Empty;
        }


        public static async Task<T?> Request<T>(BaseRequest request, ResponseContentType contentType = ResponseContentType.Json) where T : BaseResponse
        {
            return await Request<T>(request, 0, contentType);
        }

        private static async Task<T?> Request<T>(BaseRequest request, int retryTimes, ResponseContentType contentType = ResponseContentType.Json, T? latestResponse = null) where T : BaseResponse
        {
            if (retryTimes > (MaxAllowRetryTimes - 1))
            {
                return latestResponse;
            }

            if (request is BaseTokenRequest baseTokenRequest)
            {
                baseTokenRequest.AccessToken = await GetRequestAccessToken(request.AppName);
            }

            var url = request.ApiURL;
            Console.WriteLine($"Begin {request.RequestMethod}: {url}");

            HttpResponseMessage? response = null;
            using var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(RequestTimeout);
            try
            {
                if (request.RequestMethod == HttpMethod.Get)
                {
                    response = await httpClient.GetAsync(url);
                }
                else
                {
                    response = await httpClient.PostAsync(url, request.RequestContent);
                }
            }
            catch { }

            if (response == null || (int)response.StatusCode >= 500)
            {
                return await Request<T>(request, retryTimes + 1, contentType);
            }

            if (response == null)
            {
                throw new Exception("网络或服务器异常");
            }

            var apiResult = await response.Content.ReadAsStringAsync();
            Console.WriteLine("ApiResult:");
            Console.WriteLine(apiResult);

            var result = default(T);
            switch (contentType)
            {
                case ResponseContentType.Xml:
                    using (StringReader reader = new(apiResult))
                    {
                        var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute("xml"));
                        result = serializer.Deserialize(reader) as T;
                    }
                    break;
                case ResponseContentType.Json:
                    result = JsonConvert.DeserializeObject<T>(apiResult);
                    break;
                default:
                    result = JsonConvert.DeserializeObject<T>(apiResult);
                    break;
            }

            if (result == null)
            {
                throw new Exception("服务器返回结果异常");
            }

            if ((result.ErrCode == 40014 || result.ErrCode == 40001) && request is BaseTokenRequest tokenRequest)
            {
                // Access Token 无效, 强制重新获取
                tokenRequest.AccessToken = await GetRequestAccessToken(request.AppName, true);
                return await Request<T>(tokenRequest, retryTimes + 1, contentType, result);
            }

            Console.WriteLine($"Finish {request.RequestMethod}: {url} response:[{result?.ErrCode}] {result?.ErrMsg}");
            return result;
        }

        public static async Task<object?> RequestStream<T>(BaseRequest request) where T : BaseResponse
        {
            return await RequestStream<T>(request, 0);
        }
        private static async Task<object?> RequestStream<T>(BaseRequest request, int retryTimes, T? latestResponse = null) where T : BaseResponse
        {
            if (retryTimes > (MaxAllowRetryTimes - 1))
            {
                return latestResponse;
            }

            if (request is BaseTokenRequest baseTokenRequest)
            {
                baseTokenRequest.AccessToken = await GetRequestAccessToken(request.AppName);
            }

            var url = request.ApiURL;

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(RequestTimeout);

            HttpResponseMessage? response = null;
            try
            {
                if (request.RequestMethod == HttpMethod.Get)
                {
                    response = await httpClient.GetAsync(url);
                }
                else
                {
                    response = await httpClient.PostAsync(url, request.RequestContent);
                }
            }
            catch { }

            if (response == null || (int)response.StatusCode >= 500)
            {
                return await RequestStream<T>(request, retryTimes + 1, latestResponse);
            }

            if (response == null)
            {
                throw new Exception("网络或服务器异常");
            }

            var bytes = await response.Content.ReadAsByteArrayAsync();
            if (bytes != null && bytes[0] == (byte)'{')
            {
                var szResponse = Encoding.UTF8.GetString(bytes);
                var result = JsonConvert.DeserializeObject<T>(szResponse);

                if (result == null)
                {
                    throw new Exception("网络或服务器异常");
                }

                if (result is BaseResponse resultResponse && resultResponse.ErrCode == 40014 && request is BaseTokenRequest tokenRequest)
                {
                    // Access Token 无效, 强制重新获取
                    tokenRequest.AccessToken = await GetRequestAccessToken(request.AppName, true);
                    return await RequestStream<T>(tokenRequest, retryTimes + 1, result);
                }

                return result;
            }

            return bytes;
        }
    }
}
