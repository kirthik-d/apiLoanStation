using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLoanMSAPIConnect.Models
{
    [Table("PropertyInformation")]
    public class PropertyInformation
    {
        [Key]
        public int ApplicantId { get; set; }
     
        [StringLength(20)]
        [Required]
        public string LoanType { get; set; }
        [Required]
        public string LoanPurpose { get; set; }
        [Required]
        public double RequestAmount { get; set; }
        [Required]
        public int LoanTenure { get; set; }


       
    }
}
