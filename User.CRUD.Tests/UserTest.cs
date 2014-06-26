using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using User.CRUD.Controllers;
using Model = User.CRUD.Models;
using User.CRUD.Repositories;

namespace User.CRUD.Tests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void Index_Contains_All_Products()
        {
            var mock = new Mock<IRepository<Model.User>>();
            mock.Setup(m => m.All()).Returns(new Model.User[] {
                new Model.User {Id = 1, Name = "Tim"},
                new Model.User {Id = 2, Name = "Bob"},
            }.AsQueryable());

            var target = new HomeController(mock.Object);
            target.Index();

            var result = ((IEnumerable<Model.User>)target.ViewData.Model).ToArray();

            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual("Tim", result[0].Name);
            Assert.AreEqual("Bob", result[1].Name);
        }
    }
}
