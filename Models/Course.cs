using System.ComponentModel.DataAnnotations;
namespace MyCollage_EF_Rep_AsyncAwait.Models
{
   /* public enum CourseType
    {
        Omomi=1,
        Takhasosi=2,
        Amali=3

    }*/
    public class Course
    {
        public int Id {get ; set;}
        [MaxLength(250)] public string? Name {get ; set;}
        public int Vahed {get ; set;}
        //public CourseType Type;
        public DateTime CreateAt {get; set;}

        
    }
    
}