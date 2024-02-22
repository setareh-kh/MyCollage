using System.ComponentModel.DataAnnotations;
namespace MyCollage_EF_Rep_AsyncAwait.Validators
{
    public class IsValidSizeFile : ValidationAttribute
    {
        private readonly int _maxSize;
        public IsValidSizeFile(int maxSize)
        {
            _maxSize = maxSize;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;
            else
            {
                var file = value as IFormFile;
                var length = file!.Length;
                return length <= _maxSize ? ValidationResult.Success : new ValidationResult($"Size of file must be downer {_maxSize / 1024} KB");

            }

        }
    }
}