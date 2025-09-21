using Microsoft.AspNetCore.Mvc;
using Prescription.Models;

namespace Prescription.Controllers
{
    public class PrescriptionsController : Controller
    {
        private PrescriptionContext context { get; set; }

        public PrescriptionsController(PrescriptionContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new PrescriptionModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var prescriptionModel = context.PrescriptionModel.Find(id);
            return View(prescriptionModel);
        }

        [HttpPost]
        public IActionResult Edit(PrescriptionModel prescriptionModel)
        {
            if (ModelState.IsValid)
            {
                if (prescriptionModel.PrescriptionModelId == 0)
                    context.PrescriptionModel.Add(prescriptionModel);
                else
                    context.PrescriptionModel.Update(prescriptionModel);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (prescriptionModel.PrescriptionModelId == 0) ? "Add" : "Edit";
                return View(prescriptionModel);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var prescriptionModel = context.PrescriptionModel.Find(id);
            return View(prescriptionModel);
        }

        [HttpPost]
        public IActionResult Delete(PrescriptionModel prescriptionModel)
        {
            context.PrescriptionModel.Remove(prescriptionModel);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
