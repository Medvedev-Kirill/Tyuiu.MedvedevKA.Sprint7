using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevKA.Sprint7.Project.V6.Lib;
using System.IO;

namespace Tyuiu.MedvedevKA.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFilePatient()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Patients.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
        [TestMethod]
        public void CheckFileDoctors()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Doctors.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
