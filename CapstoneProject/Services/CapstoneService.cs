using AutoMapper;
using CapstoneProject.DTO;
using CapstoneProject.Repository;

namespace CapstoneProject.Services
{
    public class CapstoneService : ICapstoneService
    {
        private IMapper _mapper;
        private ICapstoneRepository _capstoneRepository;
        public CapstoneService(IMapper mapper, ICapstoneRepository capstoneRepository)
        {
            _mapper = mapper;
            _capstoneRepository = capstoneRepository;
        }

        public async Task<List<GetEmployeeDTO>> GetEmployees()
        {
            var employees = await _capstoneRepository.GetEmployees();
            var mapEmployees = _mapper.Map<List<GetEmployeeDTO>>(employees);

            return mapEmployees;
        }

        public async Task<List<GetTimesheetInfoDTO>> GetTimesheets()
        {
            var timesheets = await _capstoneRepository.GetTimesheets();
            var mapTimesheets = _mapper.Map<List<GetTimesheetInfoDTO>>(timesheets);

            return mapTimesheets;
        }

        public async Task<List<GetEventDTO>> GetEvents()
        {
            var events = await _capstoneRepository.GetEvents();
            var mapEvents = _mapper.Map<List<GetEventDTO>>(events);

            return mapEvents;
        }

        public async Task<List<GetBlogDTO>> GetBlogs()
        {
            var blogs = await _capstoneRepository.GetBlogs();
            var mapBlogs = _mapper.Map<List<GetBlogDTO>>(blogs);

            return mapBlogs;
        }

        public async Task<List<UpdateTimesheetDTO>> UpdateTimesheets(int id, string status)
        {
            
            var updatedTimesheets = await _capstoneRepository.UpdateTimesheets(id, status);
            var mapUptTimesheets = _mapper.Map<List<UpdateTimesheetDTO>>(updatedTimesheets);

            return mapUptTimesheets;
                
            
        }
    }
}
