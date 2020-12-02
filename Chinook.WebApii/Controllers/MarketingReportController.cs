using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chinook.Logic;
using Chinook.Contracts.Report;

namespace Chinook.WebApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingReportController : ControllerBase
    {
        private MarketingReport marketingReport = new MarketingReport();

        [HttpGet("/api/[controller]/GetTrackStatistic")]
        public ITrackStatistic GetTrackStatistic()
        {
            return marketingReport.GetTrackStatistic();
        }
    }
}
