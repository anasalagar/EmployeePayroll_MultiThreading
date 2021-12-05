using EmployeePayrollMultithreading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "AAAAA", PhoneNumber: 123456789, Address: "Sangli", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 2, EmployeeName: "BBBBB", PhoneNumber: 123456789, Address: "Satara", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 3, EmployeeName: "CCCCC", PhoneNumber: 123456789, Address: "Kolhapur", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 4, EmployeeName: "DDDDD", PhoneNumber: 123456789, Address: "Pune", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 5, EmployeeName: "EEEEE", PhoneNumber: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;

            EmployeePayrollUsingThreads employeePayrollUsingThreads = new EmployeePayrollUsingThreads();
            DateTime startDateTime = DateTime.Now;
            employeePayrollUsingThreads.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));


        }


    }
}