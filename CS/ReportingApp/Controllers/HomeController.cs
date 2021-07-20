using Microsoft.AspNetCore.Mvc;
using ReportingApp.PredefinedReports;

namespace ReportingApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
        public IActionResult Viewer(string? strParam) {
            var report = new XtraReport1();
            report.Parameters["strParam"].Value = strParam;
            report.Parameters["strParam"].Visible = false;
            return View(report);
        }
    }
}
