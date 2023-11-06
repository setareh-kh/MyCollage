using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using dotnetdf_MyCollage.Models;
namespace MyCollage_EF_Rep_AsyncAwait.DTO
{
    public class AddStudentReq
    {
        [Required] [MaxLength(250)]  required public string Name {get; set;}
        [MaxLength(250)] public string? Family {get; set;}
        //[MaxLength(250)] public TypeSex Sex {get; set;}
        [DefaultValue("09")] [MaxLength(20)] required public string Mobile {get; set;}
        [Required] [MaxLength(250)][MinLength(8)] required public string Password {get ; set;}
        public DateOnly BirthDate {get; set;}
    }
}