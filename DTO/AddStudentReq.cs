using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MyCollage_EF_Rep_AsyncAwait.Validators;
namespace MyCollage_EF_Rep_AsyncAwait.DTO
{
    public class AddStudentReq
    {
        [Required] [MaxLength(250)]  
         public required string Name {get; set;}
        [Required][MaxLength(250)] 
        public required string Family {get; set;} 
        [Required]
        [RegularExpression(@"^(\+98|0)?9\d{9}$", ErrorMessage = "The MobileNumber is not Valid")]
        public required string Mobile {get; set;}
        
        [Required(ErrorMessage = "please enter your password"), MaxLength(250), MinLength(8)]
        [DataType(DataType.Password)]
        public required string Password {get ; set;}
        [DataType(DataType.Date)]
        [Required]
        public DateOnly BirthDate {get; set;}
        [Required]
        [AllowedExtnsions(new[] { ".jpg", ".jpeg",".png", ".bmp", ".gif", ".tga", ".tiff", ".jfif" })]
        [IsValidSizeFile(25600)]
        public required IFormFile Image {get; set;}
        [AllowedExtnsions(new[] { ".jpg", ".jpeg",".png", ".bmp", ".gif", ".tga", ".tiff", ".jfif" })]
        [IsValidSizeFile(307200)]
        public IFormFile? NCard {get; set;}

    }
}