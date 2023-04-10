using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharakAyurvedicHospital.Controller;
using Microsoft.AspNetCore.Mvc;

namespace CharakTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        private AppointmentsController _controller;

        [TestInitialize]
        public void Init()
        {
            // Arrage - setting up the data to be tested
            _controller = new AppointmentsController();
        }
    }
}