using CapstoneProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CapstoneProject.Repository
{
    public class CapstoneRepository : ICapstoneRepository
    {
        private CapstoneDbContext _capstoneDbContext;
        public CapstoneRepository(CapstoneDbContext capstoneDbContext)
        {
            _capstoneDbContext = capstoneDbContext;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _capstoneDbContext.Employees.ToListAsync();
        }

        public async Task<List<TimesheetInfo>> GetTimesheets()
        {
            var timeSheetList = (from timesheets in _capstoneDbContext.Timesheets
                                 join employees in _capstoneDbContext.Employees on timesheets.EmployeeId equals employees.EmployeeId
                                 join projects in _capstoneDbContext.Projects on timesheets.ProjectId equals projects.ProjectId
                                 select new TimesheetInfo
                                 {
                                     Tid = timesheets.Tid,
                                     TimesheetId = timesheets.TimesheetId,
                                     StartDate = timesheets.StartDate,
                                     EndDate = timesheets.EndDate,
                                     EmployeeName = employees.EmployeeName,
                                     ProjectName = projects.ProjectName,
                                     Status = timesheets.Status
                                 }).ToListAsync();

            return await timeSheetList;
        }

        public async Task<List<Event>> GetEvents()
        {
            return await _capstoneDbContext.Events.ToListAsync();
        }

        public async Task<List<Blog>> GetBlogs()
        {
            return await _capstoneDbContext.Blogs.ToListAsync();
        }

        public async Task<List<Timesheet>> UpdateTimesheets(int id, string status)
        {
            var timesheetToUpdate = await _capstoneDbContext.Timesheets.SingleOrDefaultAsync(tmsh => tmsh.Tid == id);
            if (timesheetToUpdate != null)
            {
                if (status == "Approved")
                {
                    timesheetToUpdate.Status = "Approved";
                    await _capstoneDbContext.SaveChangesAsync();

                }
                else if (status == "Rejected")
                {
                    timesheetToUpdate.Status = "Rejected";
                    await _capstoneDbContext.SaveChangesAsync();
                }
            }

            return await _capstoneDbContext.Timesheets.ToListAsync();

        }
    }
}
