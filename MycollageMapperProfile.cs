using AutoMapper;
using MyCollage_EF_Rep_AsyncAwait.DTO;
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
        }
        

    }
}