using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShowDetailReportInPopup.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult ShowDetailReport(int categoryID, string categoryName) {
            XtraReport report = new Reports.DetailReport();
            report.Parameters["CategoryID"].Value = categoryID;
            report.Parameters["CategoryName"].Value = categoryName;
            return PartialView("ShowDetailReport", report);
        }
    }
}
