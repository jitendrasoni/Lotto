using System;

namespace Business.Dto
{
    public class Draw : DrawResultBase
    {
        public string DrawType { get; set; }

        public decimal Div1Amount { get; set; }

        public bool IsDiv1Estimated { get; set; }

        public bool IsDiv1Unknown { get; set; }

        public string DrawCloseDateTimeUTC { get; set; }

        public string DrawEndSellDateTimeUTC { get; set; }

        public long DrawCountDownTimerSeconds { get; set; }
    }
}