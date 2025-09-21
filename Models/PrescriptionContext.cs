using Microsoft.EntityFrameworkCore;

namespace Prescription.Models
{
    public class PrescriptionContext : DbContext
    {
        public PrescriptionContext(DbContextOptions<PrescriptionContext> options)
        : base(options) { }

        public DbSet<PrescriptionModel> PrescriptionModel { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionModel>().HasData(
                new PrescriptionModel
                {
                   PrescriptionModelId = 1,
                   MedicationName = "Amoxicillin",
                   FillStatus = "Pending",
                   Cost = 12.50,
                   RequestTime = DateTime.Parse("2025-09-20")
                },
                new PrescriptionModel
                {
                    PrescriptionModelId = 2,
                    MedicationName = "Ibuprofen",
                    FillStatus = "Filled",
                    Cost = 8.75,
                    RequestTime = DateTime.Parse("2025-09-19")
                },
                new PrescriptionModel
                {
                    PrescriptionModelId = 3,
                    MedicationName = "Metformin",
                    FillStatus = "Denied",
                    Cost = 20.00,
                    RequestTime = DateTime.Parse("2025-09-18")
                }
            );
        }
    }
}
