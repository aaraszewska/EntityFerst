using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFirst.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstNmae { get; set; }
        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last  Name is required")]
        public string LastMane { get; set; }
        [Display(Name = "Email Address:")]
        [Required(ErrorMessage = "Email address is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Display(Name = "Phone Number:")]
        [Required(ErrorMessage = "Phone Number  is required")]
        public string PhoneNumber { get; set; }
        [Display(Name = " Address:")]
        [Required(ErrorMessage = "address is required")]
        public string Address { get; set; }
        public Nullable<int> Age { get; set; }
        [Display(Name = "Salary:")]
        [Required(ErrorMessage = "Salary is required")]
        public Nullable<decimal> Salary { get; set; }
        public string Worktype { get; set; }
        public bool UseCarPark { get; set; }
    }
}