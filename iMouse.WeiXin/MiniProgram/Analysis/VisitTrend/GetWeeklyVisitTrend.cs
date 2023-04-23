using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitTrend
{
    public class GetWeeklyVisitTrendRequest : BaseVisitTrendRequest
    {
        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidweeklyvisittrend";

        public GetWeeklyVisitTrendRequest()
        {
            var week = (int)DateTime.Today.DayOfWeek;
            var diff = (week == 0) ? -6 : (1 - week);

            BeginDate = DateTime.Today.AddDays(diff);
            EndDate = BeginDate.AddDays(6);
        }
    }
}

