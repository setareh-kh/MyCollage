namespace MyCollage_EF_Rep_AsyncAwait.DTO.Responses
{
    public class CourseResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Vahed { get; set; }

        public DateTime CreateAt { get; set; }
    }
}