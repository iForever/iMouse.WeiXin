using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitTrend
{
    public class GetMonthlyVisitTrendRequest : BaseVisitTrendRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidmonthlyvisittrend";

        public GetMonthlyVisitTrendRequest()
        {
            var BeginDate = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            var EndDate = BeginDate.AddMonths(1).AddDays(-1);
        }
    }
}

