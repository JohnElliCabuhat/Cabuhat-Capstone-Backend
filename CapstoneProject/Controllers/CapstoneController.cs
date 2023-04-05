using CapstoneProject.DTO;
using CapstoneProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.Controllers
{
    [Route("api/capstone")]
    [ApiController]
    public class CapstoneController : ControllerBase
    {
        private ICapstoneService _capstoneService;
        public CapstoneController(ICapstoneService capstoneService)
        {
            _capstoneService = capstoneService;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public async Task<ActionResult<List<GetEmployeeDTO>>> GetEmployees()
        {
            var employees = await _capstoneService.GetEmployees();
            if (employees == null)
                return NotFound();

            return Ok(employees);
        }

        [HttpGet]
        [Route("GetTimesheets")]
        public async Task<ActionResult<List<GetTimesheetInfoDTO>>> GetTimesheets()
        {
            var timesheets = await _capstoneService.GetTimesheets();
            if (timesheets == null)
                return NotFound();

            return Ok(timesheets);
        }

        [HttpGet]
        [Route("GetEvents")]
        public async Task<ActionResult<List<GetEventDTO>>> GetEvents()
        {
            var events = await _capstoneService.GetEvents();
            if (events == null)
                return NotFound();

            return Ok(events);
        }

        [HttpGet]
        [Route("GetBlogs")]
        public async Task<ActionResult<List<GetBlogDTO>>> GetBlogs()
        {
            var events = await _capstoneService.GetBlogs();
            if (events == null)
                return NotFound();

            return Ok(events);
        }

        [HttpPut]
        [Route("UpdateTimesheets")]
        public async Task<ActionResult<List<UpdateTimesheetDTO>>> UpdateTimesheets(int id, string status)
        {
            var updateTimesheet = await _capstoneService.UpdateTimesheets(id, status);
            if (updateTimesheet == null)
                return NotFound();

            return Ok(updateTimesheet);
        }

    }
}
