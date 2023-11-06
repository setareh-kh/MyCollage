using Microsoft.AspNetCore.Mvc;
using MyCollage_EF_Rep_AsyncAwait.Repositories;
using MyCollage_EF_Rep_AsyncAwait.DTO;
using MyCollage_EF_Rep_AsyncAwait.Models;



namespace Dotnetdf_MyCollage_Repository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController:ControllerBase
    {
        private readonly ICourseRepository _courserepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courserepository = courseRepository;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddCourseAsync(AddCourseReq addCourseReq)
        {
            Course c = await _courserepository.StoreAsync(addCourseReq);
            return Ok(c);

        }
        [HttpGet]
        [Route("Get/{id}")]
        public async Task<IActionResult> GetCourseAsync(int id)
        {
            Course? course =await _courserepository.GetAsync(id);
            return Ok(course==null ? "Id Not found!!!" : course);
        }
        [HttpGet]
        [Route("ReadAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var courses =await _courserepository.GetAllAsync();
            return Ok(courses==null ? "No Any course exsist" : courses);
        }
        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateCourseAsync(int id, UpdateCourseReq updateCourseReq)
        {
            Course? course=await _courserepository.UpdateAsync(id,updateCourseReq);
            return Ok(course==null ? "course is not Found!!!!" : course);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteCourseAsync(int id)
        {
            Course? course=await _courserepository.DeleteAsync(id);
            return Ok(course==null ? "course is not Found!!!!" : course);
        }

    }
}