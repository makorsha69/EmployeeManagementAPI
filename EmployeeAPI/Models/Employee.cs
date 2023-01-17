using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID will be automatically generated")]
        public int EmpID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The train name cannot be empty.")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The email cannot be empty.")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string Address { get; set; }


        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string Mobile { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        [Required(ErrorMessage = "Salary is Compulsory.")]
        public int Salary { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Department { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "MM/DD/YYYY Format")]
        public DateTime DOJ { get; set; }

        public bool isActive { get; set; }

    }
}
