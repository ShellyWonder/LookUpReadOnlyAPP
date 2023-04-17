
using System.ComponentModel.DataAnnotations;

namespace LookUpReadOnlyAPI.Data
{
    public record AERecordModel
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][0-9][A-Z][0-9][a-z][0-9]$", 
         ErrorMessage = "The value must follow the pattern 'M3M2b4' (e.g., A1B2c3).")]
        public string? AEId { get; set; }

        [Display(Name = "Employee ID")]
        public string? EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        
        [Display(Name = "Job Title")]

        public string? JobTitle { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        [Display(Name = "Corporate Address")]
        public string? CorporateAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EmploymentDate { get; set; } = DateTime.UtcNow;
    }

    

    
}
