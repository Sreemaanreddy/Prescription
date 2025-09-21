using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prescription.Models;

namespace Prescription.Controllers
{
    public class HomeController : Controller
    {
        private PrescriptionContext context { get; set; }

        public HomeController(PrescriptionContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var prescriptions = context.PrescriptionModel.OrderBy(m => m.MedicationName).ToList();
            return View(prescriptions);
        }
    }
}
