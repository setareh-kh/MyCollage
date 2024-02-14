using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace  MyCollage_EF_Rep_AsyncAwait.DTO.Requsts
{
    public class LoginDto
    {
        [MaxLength(250)]  
        public  required string Mobile {get ; set;}

        [Required] [MaxLength(250)][MinLength(8)]  
        public required string Password {get ; set;}
    }
}