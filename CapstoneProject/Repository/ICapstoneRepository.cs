using CapstoneProject.Models;

namespace CapstoneProject.Repository
{
    public interface ICapstoneRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<List<TimesheetInfo>> GetTimesheets();
        Task<List<Event>> GetEvents();
        Task<List<Blog>> GetBlogs();
        Task<List<Timesheet>> UpdateTimesheets(int id, string status);
    }
}