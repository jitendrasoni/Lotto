using Business.Dto.Interfaces;
using System.Collections.Generic;

namespace Business.Dto
{
    public class LatestResultsApiResponse : IDrawApiResponse
    {
        public List<OpenDrawsResult> DrawResults { get; set; }

        public string ErrorInfo { get; set; }

        public bool Success { get; set; }
    }
}
