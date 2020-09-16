using Business.Dto.Interfaces;
using System.Collections.Generic;

namespace Business.Dto
{
    public class OpenDrawsApiResponse : IDrawApiResponse
    {
        public List<Draw> Draws { get; set; }

        public string ErrorInfo { get; set; }

        public bool Success { get; set; }
    }
}