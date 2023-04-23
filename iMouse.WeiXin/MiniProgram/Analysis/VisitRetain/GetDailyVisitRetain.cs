using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitRetain
{
    public class GetDailyVisitRetainRequest : BaseVisitRetainRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappiddailyretaininfo";

        public GetDailyVisitRetainRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }
}

