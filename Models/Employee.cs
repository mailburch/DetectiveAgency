using System.ComponentModel.DataAnnotations;

namespace DetectiveAgency.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Hourly Rate is required.")]
        [Range(1, 1000, ErrorMessage = "Enter 1 to 1000.")]
        public decimal Rate { get; set; } = 0;

        [Required(ErrorMessage = "Hours is required.")]
        [Range(1, 100, ErrorMessage = "Enter 1 to 100.")]
        public decimal Hours { get; set; } = 0;

        public decimal CalcSalary() => decimal.Round(Rate * Hours, 2);
    }
}
