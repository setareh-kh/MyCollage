namespace MyCollage_EF_Rep_AsyncAwait.DTO.Responses
{
    public class StudentResponseDto
    {
        public int Id {get ; set;}
        public string? FullName { get; set; }
        public IFormFile? Image { get; set; }
    }
}