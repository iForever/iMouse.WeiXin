using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitTrend
{
    public class GetDailyVisitTrendRequest : BaseVisitTrendRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappiddailyvisittrend";

        public GetDailyVisitTrendRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }
}

