using System.ComponentModel.DataAnnotations;

namespace MyCollage_EF_Rep_AsyncAwait.DTO
{
    public class AddCourseReq
    {
        [Required][MaxLength(250)] public string? Name {get ; set;}
        [Required] public int Vahed {get ; set;}
        
    }
}