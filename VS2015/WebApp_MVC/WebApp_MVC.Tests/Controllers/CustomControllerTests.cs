using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using WebApp_MVC;
using WebApp_MVC.Controllers;


namespace WebApp_MVC.Tests.Controllers
{
    [TestClass]
    public class CustomControllerTests
    {
        [TestMethod]
        public void PagesTest()
        {
            // Arrange
            CustomController controller = new CustomController();

            // Act
            RedirectToRouteResult result = controller.Index() as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Alternate", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);
        }

        [TestMethod]
        public void GuideTest()
        {
            // Arrange
            CustomController controller = new CustomController();

            // Act
            var result = controller.Guide();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse((result as ViewResult).ViewBag.testFlag);
        }
    }
}
