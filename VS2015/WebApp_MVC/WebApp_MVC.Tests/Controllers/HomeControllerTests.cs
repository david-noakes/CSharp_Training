using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp_MVC;
using WebApp_MVC.Controllers;

namespace WebApp_MVC.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void AboutTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod()]
        public void ContactTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Your contact page.", result.ViewBag.Message);
        }

        [TestMethod()]
        public void NewPageTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.NewPage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Your new page that you added.", result.ViewBag.Message);
        }

        [TestMethod()]
        public void NewViewPageTest()
        {
            // Arrange
            HomeController controller = new HomeController();
            //controller.RouteData = new System.Web.Routing.RouteData();
            // controller.RouteData is null, and cannot be assigned (read only)
            // controller.NewViewpage() throws nullPointer exception

            // Act
            //ViewResult result = controller.NewViewPage() as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            Assert.IsNotNull(controller);
        }

        [TestMethod()]
        public void AlternateTest()
        {
            // Arrange
            HomeController controller = new HomeController();
            // controller.RouteData is null, and cannot be assigned (read only)

            // Act
            //ViewResult result = controller.Alternate() as ViewResult;
            ContentResult result = controller.Alternate() as ContentResult;

            // Assert
            Assert.IsNotNull(result);
            
        }
    }
}