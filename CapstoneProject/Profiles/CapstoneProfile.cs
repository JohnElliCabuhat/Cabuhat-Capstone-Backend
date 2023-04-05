using AutoMapper;
using CapstoneProject.DTO;
using CapstoneProject.Models;

namespace CapstoneProject.Profiles
{
    public class CapstoneProfile :Profile
    {
        public CapstoneProfile()
        {
            CreateMap<Employee, GetEmployeeDTO>();
            CreateMap<GetEmployeeDTO, Employee>();
            CreateMap<TimesheetInfo, GetTimesheetInfoDTO>();
            CreateMap<GetTimesheetInfoDTO, TimesheetInfo>();
            CreateMap<Event, GetEventDTO>();
            CreateMap<GetEventDTO, Event>();
            CreateMap<Blog, GetBlogDTO>();
            CreateMap<GetBlogDTO, Blog>();
            CreateMap<Timesheet, UpdateTimesheetDTO>();
            CreateMap<UpdateTimesheetDTO, Timesheet>();
        }
    }
}
