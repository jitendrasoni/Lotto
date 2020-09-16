using Lotto.Feature.Lottery.Dto.Interfaces;
using System;

namespace Business.Dto
{
    public abstract class DrawResultBase
    {
        public string ProductId { get; set; }

        public int DrawNumber { get; set; }

        public string DrawDisplayName { get; set; }

        public DateTime DrawDate { get; set; }

        public string DrawLogoUrl { get; set; }
    }
}
