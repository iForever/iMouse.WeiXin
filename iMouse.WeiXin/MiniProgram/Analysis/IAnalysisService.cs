using System;
using iMouse.WeiXin.MiniProgram.Analysis.Others;
using iMouse.WeiXin.MiniProgram.Analysis.VisitRetain;
using iMouse.WeiXin.MiniProgram.Analysis.VisitTrend;

namespace iMouse.WeiXin.MiniProgram.Analysis
{
    public interface IAnalysisService
    {
        /// <summary>
        /// 获取用户访问小程序日留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitRetainResponse?> GetDailyVisitRetainAsync(GetDailyVisitRetainRequest request);

        /// <summary>
        /// 获取用户访问小程序周留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitRetainResponse?> GetWeeklyVisitRetainAsync(GetWeeklyVisitRetainRequest request);

        /// <summary>
        /// 获取用户访问小程序月留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitRetainResponse?> GetMonthlyVisitRetainAsync(GetMonthlyVisitRetainRequest request);

        /// <summary>
        /// 获取用户访问小程序数据日趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitTrendResponse?> GetDailyVisitTrendAsync(GetDailyVisitTrendRequest request);

        /// <summary>
        /// 获取用户访问小程序数据周趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitTrendResponse?> GetWeeklyVisitTrendAsync(GetWeeklyVisitTrendRequest request);

        /// <summary>
        /// 获取用户访问小程序数据月趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseVisitTrendResponse?> GetMonthlyVisitTrendAsync(GetMonthlyVisitTrendRequest request);

        /// <summary>
        /// 获取用户访问小程序数据概况
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetDailySummaryResponse?> GetDailySummaryAsync(GetDailySummaryRequest request);

        /// <summary>
        /// 获取访问页面数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetVisitPageResponse?> GetVisitPageAsync(GetVisitPageRequest request);

        /// <summary>
        /// 获取小程序用户画像分布
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetUserPortraitResponse?> GetUserPortraitAsync(GetUserPortraitRequest request);

        /// <summary>
        /// 获取小程序性能数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetPerformanceDataResponse?> GetPerformanceDataAsync(GetPerformanceDataRequest request);

        /// <summary>
        /// 获取用户小程序访问分布数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetVisitDistributionResponse?> GetVisitDistributionAsync(GetVisitDistributionRequest request);
    }
}

