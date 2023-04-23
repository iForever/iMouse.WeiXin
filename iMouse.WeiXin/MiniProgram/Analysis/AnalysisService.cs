using System;
using iMouse.WeiXin.MiniProgram.Analysis.Others;
using iMouse.WeiXin.MiniProgram.Analysis.VisitRetain;
using iMouse.WeiXin.MiniProgram.Analysis.VisitTrend;

namespace iMouse.WeiXin.MiniProgram.Analysis
{
    public class AnalysisService : IAnalysisService
    {
        /// <summary>
        /// 获取用户访问小程序日留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitRetainResponse?> GetDailyVisitRetainAsync(GetDailyVisitRetainRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitRetainResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序周留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitRetainResponse?> GetWeeklyVisitRetainAsync(GetWeeklyVisitRetainRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitRetainResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序月留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitRetainResponse?> GetMonthlyVisitRetainAsync(GetMonthlyVisitRetainRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitRetainResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序数据日趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitTrendResponse?> GetDailyVisitTrendAsync(GetDailyVisitTrendRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitTrendResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序数据周趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitTrendResponse?> GetWeeklyVisitTrendAsync(GetWeeklyVisitTrendRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitTrendResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序数据月趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseVisitTrendResponse?> GetMonthlyVisitTrendAsync(GetMonthlyVisitTrendRequest request)
        {
            return await ServiceInvoker.Request<BaseVisitTrendResponse>(request);
        }

        /// <summary>
        /// 获取用户访问小程序数据概况
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetDailySummaryResponse?> GetDailySummaryAsync(GetDailySummaryRequest request)
        {
            return await ServiceInvoker.Request<GetDailySummaryResponse>(request);
        }

        /// <summary>
        /// 获取访问页面数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetVisitPageResponse?> GetVisitPageAsync(GetVisitPageRequest request)
        {
            return await ServiceInvoker.Request<GetVisitPageResponse>(request);
        }

        /// <summary>
        /// 获取小程序用户画像分布
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUserPortraitResponse?> GetUserPortraitAsync(GetUserPortraitRequest request)
        {
            return await ServiceInvoker.Request<GetUserPortraitResponse>(request);
        }

        /// <summary>
        /// 获取小程序性能数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPerformanceDataResponse?> GetPerformanceDataAsync(GetPerformanceDataRequest request)
        {
            return await ServiceInvoker.Request<GetPerformanceDataResponse>(request);
        }

        /// <summary>
        /// 获取用户小程序访问分布数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetVisitDistributionResponse?> GetVisitDistributionAsync(GetVisitDistributionRequest request)
        {
            return await ServiceInvoker.Request<GetVisitDistributionResponse>(request);
        }
    }
}

