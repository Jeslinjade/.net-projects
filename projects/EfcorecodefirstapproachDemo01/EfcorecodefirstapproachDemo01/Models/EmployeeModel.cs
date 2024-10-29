using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EfcorecodefirstapproachDemo01.Models
{
    [Table("tblEmployees")]
    public class EmployeeModel
    {
        
        [Key]
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }

}
