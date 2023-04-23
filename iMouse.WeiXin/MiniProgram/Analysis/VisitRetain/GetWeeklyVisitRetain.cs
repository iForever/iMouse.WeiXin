using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.VisitRetain
{
    public class GetWeeklyVisitRetainRequest : BaseVisitRetainRequest
    {

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidweeklyretaininfo";

        public GetWeeklyVisitRetainRequest()
        {
            var week = (int)DateTime.Today.DayOfWeek;
            var diff = (week == 0) ? -6 : (1 - week);

            BeginDate = DateTime.Today.AddDays(diff);
            EndDate = BeginDate.AddDays(6);
        }
    }
}

