using CharakAyurvedicHospital.Controllers;
using CharakAyurvedicHospital.Data;
using CharakAyurvedicHospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharakAyurvedicTest
{
    [TestClass]
    public class AppointmentsControllerTest
    {
        private ApplicationDbContext _context;
        private AppointmentsController _controller;
        
        private List<Appointment> _appointments = new List<Appointment>();

        
        [TestInitialize]
        public void Init()
        {
            // Mock db
            var dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(dbOptions);

            _appointments.Add(new Appointment
            {
                Id = 1,
                PatientName = "Bhavneet",
                Gender = "Female",
                PatienteMail = "bhav123@gmail.com",

            });
            _appointments.Add(new Appointment
            {
                Id = 2,
                PatientName = "Ansh",
                Gender = "Male",
                PatienteMail = "ansh321@gmail.com",

            });

            foreach (var appointment in _appointments)
            {
                _context.Appointments.Add(appointment);
            }

            _context.SaveChanges();

            _controller = new AppointmentsController(_context);
        }


        [TestMethod]
        public void EditIsNotNull()
        {

            var result = _controller.Edit(null);
            Assert.IsNotNull(result);
        }



        [TestMethod]
        public async Task EditReturnsListOfAppointmnets()
        {
            var result = (ViewResult)await _controller.Edit(null);

            var actual = (List<Appointment>)result.Model;

            CollectionAssert.AreEqual(_appointments.OrderBy(p => p.Id).ToList(),
                actual
            );
        }


        [TestMethod]
        public void EditMessage()
        {
            var result = (ViewResult)_controller.Edit();

            Assert.AreEqual("HI!!!!!!", result.ViewData["Message"]);
        }


    }
}