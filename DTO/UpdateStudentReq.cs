using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using dotnetdf_MyCollage.Models;
namespace  MyCollage_EF_Rep_AsyncAwait.DTO
{
    public class UpdateStudentReq
    {
        [Required] [MaxLength(250)] public required string Name {get; set;}
        [MaxLength(250)] public string? Family {get; set;}
        //[MaxLength(250)] public TypeSex Sex {get; set;}
        [DefaultValue("09")] [MaxLength(20)] public  string? Mobile {get; set;}
        [Required] [MaxLength(250)][MinLength(8)]  public required string Password {get ; set;}
    }
}