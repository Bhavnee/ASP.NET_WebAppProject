using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharakAyurvedicHospital.Controller;
using Microsoft.AspNetCore.Mvc;

namespace CharakAyurvedicHospitalTest
{
    [TestClass]
    public class AppointmentsControllerTest
    {
        private AppointmentsController _controller;

        [TestInitialize]
        public void Init()
        {
            // Arrage - setting up the data to be tested
            _controller = new AppointmentsController();
        }
        
        [TestMethod]
        public void IndexReturnsIndexView()
        {

            
             var result = (ViewResult)_controller.Create();

             Assert.AreEqual("Create", result.ViewName);
        }
    }
}