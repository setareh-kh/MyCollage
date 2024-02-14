using AutoMapper;
using MyCollage_EF_Rep_AsyncAwait.DTO.Requsts;
using MyCollage_EF_Rep_AsyncAwait.DTO.Responses;
using MyCollage_EF_Rep_AsyncAwait.Models;

namespace MyCollage_EF_Rep_AsyncAwait
{
    public class MycollageMapperProfile:Profile
    {
        public MycollageMapperProfile()
        {
            //mapping requsts
            CreateMap<AddStudentReq,Student>();
            CreateMap<AddCourseReq,Course>();
            CreateMap<UpdateStudentReq, Student>();
            CreateMap<UpdateCourseReq,Course>();
            //mapping responses
            CreateMap<Student,StudentResponseDto>().ForMember(sResponse => sResponse.FullName, student =>student.MapFrom(student =>String.Concat(student.Name," ", student.Family)));
            CreateMap<Course,CourseResponseDto>();

        }
        

    }
}