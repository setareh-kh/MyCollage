using System.ComponentModel.DataAnnotations;

namespace MyCollage_EF_Rep_AsyncAwait.DTO.Requsts
{
    public class UpdateCourseReq
    {
        [Required][MaxLength(250)] public string? Name {get ; set;}
        [Required] public int Vahed {get ; set;}
        
    }
}