using System.ComponentModel.DataAnnotations;

namespace Prescription.Models
{
    public class PrescriptionModel
    {
        public int PrescriptionModelId { get; set; }

        [Required(ErrorMessage = "Please enter a MedicationName.")]
        public string MedicationName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a FillStatus.")]
        public string FillStatus { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter a Cost.")]
        public double? Cost { get; set; } 
        
        [Required(ErrorMessage = "Please enter a RequestTime.")]
        [DataType(DataType.Date)]
        public DateTime? RequestTime { get; set; } 
    }
}
