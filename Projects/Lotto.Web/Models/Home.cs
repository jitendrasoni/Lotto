using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lotto.Web.Models
{
    public class Home
    {
        public List<Draw> OpenDrawItems { get; set; }

        public List<OpenDrawsResult> LatestResultItems { get; set; }
    }
}