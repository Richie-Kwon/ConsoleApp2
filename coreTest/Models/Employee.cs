using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace coreTest.Models
{
    
    [Table("Employee")] /*namespace of table at DB */ 
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime DOB { get; set; }
        
        public decimal Salary { get; set; }
        
    }
}