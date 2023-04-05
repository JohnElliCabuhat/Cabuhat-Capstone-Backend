using CapstoneProject.DTO;

namespace CapstoneProject.Services
{
    public interface ICapstoneService
    {
        Task<List<GetEmployeeDTO>> GetEmployees();
        Task<List<GetTimesheetInfoDTO>> GetTimesheets();
        Task<List<GetEventDTO>> GetEvents();
        Task<List<GetBlogDTO>> GetBlogs();
        Task<List<UpdateTimesheetDTO>> UpdateTimesheets(int id, string status);
    }
}