using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CoreApp.Web.Controllers;
namespace CoreApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();
            Assert.IsType<ViewResult>(controller.Index());
        }
    }
}
