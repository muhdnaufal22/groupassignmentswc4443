using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagementAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustName { get; set; }

        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
