using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithSqlServer;

namespace Test.WithSqlServer
{
    [TestClass]
    public class EmployeeRepoTest
    {
        [TestMethod]
        public void GetEmployeeTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            var employee = employeeRepo.GetFirstEmployee();

            Assert.IsNotNull(employee , "Emplyee cannot be null");

            Assert.IsNotNull(employee.FirstName, "Employee should have first name");


        }

    }
}
