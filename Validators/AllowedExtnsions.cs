using System.ComponentModel.DataAnnotations;

namespace MyCollage_EF_Rep_AsyncAwait.Validators
{
    public class AllowedExtnsions : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtnsions(string[] extensions)
        {
            _extensions = extensions;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value==null) return ValidationResult.Success;
            else
            {
                var file = value as IFormFile;
                var ext = Path.GetExtension(file!.FileName).ToLower();
                if (_extensions.Contains(ext))
                {
                    return ValidationResult.Success;
                }
                else return new ValidationResult(":(((((((((file format is not valid ");
            }

        }



    }
}