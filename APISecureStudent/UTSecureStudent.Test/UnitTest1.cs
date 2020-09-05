using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using APISecureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTSecureStudent.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();
            //Act
            var ListStudent = studentsController.GetStudents();
            //Assert
            Assert.IsNotNull(ListStudent);
        }
    }
}
