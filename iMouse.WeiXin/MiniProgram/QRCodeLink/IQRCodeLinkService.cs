using System;
using System.Threading.Tasks;

namespace iMouse.WeiXin.MiniProgram.QRCodeLink
{
    public interface IQRCodeLinkService
    {
        /// <summary>
        /// 该接口用于获取小程序码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseQRCodeResponse?> GetQRCodeAsync(GetQRCodeRequest request);

        /// <summary>
        /// 该接口用于获取小程序码，适用于需要的码数量极多的业务场景。通过该接口生成的小程序码，永久有效，数量暂无限制。 更多用法详见 获取小程序码。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseQRCodeResponse?> GetUnlimitedQRCodeAsync(GetUnlimitedQRCodeRequest request);

        /// <summary>
        /// 获取小程序二维码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制，详见获取二维码。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseQRCodeResponse?> CreateQRCodeAsync(CreateQRCodeRequest request);

        /// <summary>
        /// 该接口用于查询小程序 scheme 码，及长期有效 quota。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<QuerySchemeResponse?> QuerySchemeAsync(QuerySchemeRequest request);

        /// <summary>
        /// 该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景。
        /// 通过该接口，可以选择生成到期失效和永久有效的小程序码，有数量限制，目前仅针对国内非个人主体的小程序开放，详见获取 URL scheme。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenerateSchemeResponse?> GenerateSchemeAsync(GenerateSchemeRequest request);

        /// <summary>
        /// 该接口用于获取用于 NFC 的小程序 scheme 码，适用于 NFC 拉起小程序的业务场景。目前仅针对国内非个人主体的小程序开放，详见 NFC 标签打开小程序。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenerateNFCSchemeResponse?> GenerateNFCSchemeAsync(GenerateNFCSchemeRequest request);

        /// <summary>
        /// 获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景。通过该接口，可以选择生成到期失效和永久有效的小程序链接，有数量限制，
        /// 目前仅针对国内非个人主体的小程序开放，详见获取 URL Link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenerateUrlLinkResponse?> GetGenerateUrlLinkAsync(GenerateUrlLinkRequest request);

        /// <summary>
        /// 该接口用于查询小程序 url_link 配置，及长期有效 quota
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<QueryUrlLinkResponse?> QueryUrlLinkAsync(QueryUrlLinkRequest request);

        /// <summary>
        /// 获取小程序 Short Link，适用于微信内拉起小程序的业务场景。
        /// 目前只开放给电商类目(具体包含以下一级类目：电商平台、商家自营、跨境电商)。
        /// 通过该接口，可以选择生成到期失效和永久有效的小程序短链，详见获取 Short Link。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenerateShortLinkResponse?> GenerateShortLinkAsync(GenerateShortLinkRequest request);
    }
}

