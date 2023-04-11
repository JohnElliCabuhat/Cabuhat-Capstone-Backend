using System.Runtime.CompilerServices;
using Moq;
using CapstoneProject.Services;
using CapstoneProject.DTO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.AspNetCore.Mvc;
using CapstoneProject.Models;

namespace CapstoneTestProject
{
    public class UnitTest1
    {
        private Mock<ICapstoneService> capstoneService;
        public UnitTest1()
        {
            capstoneService = new Mock<ICapstoneService>();
        }

        [Fact]
        public void GetEmployees_Success_ReturnIsType()
        {
            var employees = new List<GetEmployeeDTO>()
            {
                new GetEmployeeDTO()
                {
                    Eid = 1,
                    EmployeeId = "TestEmp01",
                    EmployeeName = "Test",
                    ContactNumber= 9662961543,
                    Email="test@gmail.com",
                    Department="testdept",
                    ProjectId="TestPrj01"
                }
            };
            capstoneService.Setup(x => x.GetEmployees()).Returns(Task.Run(() => employees));
            var CapstoneController = new CapstoneProject.Controllers.CapstoneController(capstoneService.Object);

            var okObjectResult = CapstoneController.GetEmployees().Result.Result as OkObjectResult;
            var infoListResult = okObjectResult.Value as List<GetEmployeeDTO>;

            Assert.IsType<List<GetEmployeeDTO>>(infoListResult);

        }

        [Fact]
        public void GetBlogs_Success_ReturnIsType()
        {
            var blogs = new List<GetBlogDTO>()
            {
                new GetBlogDTO()
                {
                    Bid = 1,
                    BlogTitle = "Test",
                    BlogDescription = "Test",
                    BlogImage = "Test",
                    BlogLink = "Test",
                }
            };

            capstoneService.Setup(x => x.GetBlogs()).Returns(Task.Run(() => blogs));
            var CapstoneController = new CapstoneProject.Controllers.CapstoneController(capstoneService.Object);

            var okObjectResult = CapstoneController.GetBlogs().Result.Result as OkObjectResult;
            var infoListResult = okObjectResult.Value as List<GetBlogDTO>;

            Assert.IsType<List<GetBlogDTO>>(infoListResult);

        }

        [Fact]
        public void GetEvents_Success_ReturnIsType()
        {
            DateTime testDate = DateTime.Now;
            var events = new List<GetEventDTO>()
            {

                new GetEventDTO()
                {
                    Evid = 1,
                    EventName = "Test",
                    EventDescription = "Test",
                    EventImage = "Test",
                    EventLink = "Test",
                    EventDate = testDate
                }
            };

            capstoneService.Setup(x => x.GetEvents()).Returns(Task.Run(() => events));
            var CapstoneController = new CapstoneProject.Controllers.CapstoneController(capstoneService.Object);

            var okObjectResult = CapstoneController.GetEvents().Result.Result as OkObjectResult;
            var infoListResult = okObjectResult.Value as List<GetEventDTO>;

            Assert.IsType<List<GetEventDTO>>(infoListResult);

        }

        [Fact]
        public void GetTimesheets_Success_ReturnIsType()
        {
            DateTime testDate = DateTime.Now;
            var timesheets = new List<GetTimesheetInfoDTO>()
            {

                new GetTimesheetInfoDTO()
                {
                    Tid = 1,
                    TimesheetId = "Test",
                    StartDate = testDate,
                    EndDate = testDate,
                    EmployeeName = "Test",
                    ProjectName = "Test",
                    Status = "Test",
                }
            };

            capstoneService.Setup(x => x.GetTimesheets()).Returns(Task.Run(() => timesheets));
            var CapstoneController = new CapstoneProject.Controllers.CapstoneController(capstoneService.Object);

            var okObjectResult = CapstoneController.GetTimesheets().Result.Result as OkObjectResult;
            var infoListResult = okObjectResult.Value as List<GetTimesheetInfoDTO>;

            Assert.IsType<List<GetTimesheetInfoDTO>>(infoListResult);

        }
    }
}