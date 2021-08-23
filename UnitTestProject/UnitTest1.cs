using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCProject.Models;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        ISqlRepository sqlRepository;
        [TestMethod]
        public void TestMethod1()
        {
            sqlRepository = new SqlRepository();
            User user = new User()
            {
                UserName = "Dhoni123",
                PassWord = "Dhoni@123",
                RoleName = "patient"



            };

            bool result = sqlRepository.AddUser(user);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            sqlRepository = new SqlRepository();
            User user = new User()
            {
                UserName = "superadmin21",
                PassWord = "superadmin@21",
                RoleName = "admin"



            };

            bool result = sqlRepository.UserExsist(user);
            Assert.AreEqual(true, result);


        }

    }
}
