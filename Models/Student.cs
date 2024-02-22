using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyCollage_EF_Rep_AsyncAwait.Models
{
    /*public enum TypeSex
   {
      male=0,
      female=1

   }*/
    public class Student
    {
        public int Id {get ; set;}
        [Required] [MaxLength(250)] public string? Name {get ; set;}
        [MaxLength(250)] public string? Family {get ; set;}
        //public TypeSex Sex;
        [MaxLength(250)] [DefaultValue("09")] public string? Mobile {get ; set;}
        public DateOnly BirthDate {get ; set;}
        [Required] [MaxLength(250)][MinLength(8)] public string? Password {get ; set;}
        public DateTime CreateAt {get; set;}
        [Required]
        public string? ImageProfile {get; set;}
    }
    
}