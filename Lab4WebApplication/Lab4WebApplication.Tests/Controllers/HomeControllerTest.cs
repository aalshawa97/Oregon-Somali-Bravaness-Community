using IdentityServer3.Core.ViewModels;
using Lab4WebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace Lab4WebApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return ViewContext(new ErrorViewModel { RequestId = Activity.Current?.Id });

        }

        private IActionResult ViewContext(ErrorViewModel errorViewModel)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("I am a co-founder of the first Oregon Somali Bravaness Community website for all of the Pacific Northwest. Responsibilities include maintaining excellent communication with members and leaders of the organization. My responsibilities forced me to learn, and apply proper web development procedures. They also pushed me toward developing leadership skills required for organizing large teams to hold events for 10+ people. As a community run organization, a big challenge is generating our own revenues and expenses through the events we hold. It is essential that events are successful because the organization's success depend on it.", result.ViewBag.Message);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
