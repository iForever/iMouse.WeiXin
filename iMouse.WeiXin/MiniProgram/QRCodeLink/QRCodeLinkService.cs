using System;
using System.Threading.Tasks;

namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public class QRCodeLinkService : IQRCodeLinkService
    {

        private async Task<BaseQRCodeResponse?> Request(BaseQRCodeRequest request)
        {
            var result = await ServiceInvoker.RequestStream<BaseQRCodeResponse>(request);
            if (result != null)
            {
                if (result is byte[] fBytes)
                {
                    return new BaseQRCodeResponse
                    {
                        QRCodeData = fBytes,
                        ErrCode = 0,
                        ErrMsg = String.Empty
                    };
                }
                else if (result is BaseQRCodeResponse response)
                {
                    return response;
                }
            }
            return default;
        }


        /// <summary>
        /// 该接口用于获取小程序码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BaseQRCodeResponse?> GetQRCodeAsync(GetQRCodeRequest request)
        {
            return await Request(request);
        }

        /// <summary>
        /// 该接口用于获取小程序码，适用于需要的码数量极多的业务场景。通过该接口生成的小程序码，永久有效，数量暂无限制。 更多用法详见 获取小程序码。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BaseQRCodeResponse?> GetUnlimitedQRCodeAsync(GetUnlimitedQRCodeRequest request)
        {
            return await Request(request);
        }


        /// <summary>
        /// 获取小程序二维码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制，详见获取二维码。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BaseQRCodeResponse?> CreateQRCodeAsync(CreateQRCodeRequest request)
        {
            return await Request(request);
        }

        /// <summary>
        /// 该接口用于查询小程序 scheme 码，及长期有效 quota。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<QuerySchemeResponse?> QuerySchemeAsync(QuerySchemeRequest request)
        {
            return await ServiceInvoker.Request<QuerySchemeResponse>(request);
        }

        /// <summary>
        /// 该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景。
        /// 通过该接口，可以选择生成到期失效和永久有效的小程序码，有数量限制，目前仅针对国内非个人主体的小程序开放，详见获取 URL scheme。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenerateSchemeResponse?> GenerateSchemeAsync(GenerateSchemeRequest request)
        {
            return await ServiceInvoker.Request<GenerateSchemeResponse>(request);
        }

        /// <summary>
        /// 该接口用于获取用于 NFC 的小程序 scheme 码，适用于 NFC 拉起小程序的业务场景。目前仅针对国内非个人主体的小程序开放，详见 NFC 标签打开小程序。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenerateNFCSchemeResponse?> GenerateNFCSchemeAsync(GenerateNFCSchemeRequest request)
        {
            return await ServiceInvoker.Request<GenerateNFCSchemeResponse>(request);
        }

        /// <summary>
        /// 获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景。通过该接口，可以选择生成到期失效和永久有效的小程序链接，有数量限制，
        /// 目前仅针对国内非个人主体的小程序开放，详见获取 URL Link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenerateUrlLinkResponse?> GetGenerateUrlLinkAsync(GenerateUrlLinkRequest request)
        {
            return await ServiceInvoker.Request<GenerateUrlLinkResponse>(request);
        }

        /// <summary>
        /// 该接口用于查询小程序 url_link 配置，及长期有效 quota
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<QueryUrlLinkResponse?> QueryUrlLinkAsync(QueryUrlLinkRequest request)
        {
            return await ServiceInvoker.Request<QueryUrlLinkResponse>(request);
        }

        /// <summary>
        /// 获取小程序 Short Link，适用于微信内拉起小程序的业务场景。
        /// 目前只开放给电商类目(具体包含以下一级类目：电商平台、商家自营、跨境电商)。
        /// 通过该接口，可以选择生成到期失效和永久有效的小程序短链，详见获取 Short Link。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenerateShortLinkResponse?> GenerateShortLinkAsync(GenerateShortLinkRequest request)
        {
            return await ServiceInvoker.Request<GenerateShortLinkResponse>(request);
        }
    }
}

