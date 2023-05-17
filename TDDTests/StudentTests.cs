using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TDD.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void setAverageTest()
        {
            // Arrange
            List<int> grades = new List<int> { 100, 100, 100, 100, 100 };
            Student student = new Student("322149345", "victor", "socolovschi", "victor@gmail.com", "0547649355", grades);

            float average = student.Average;

            // Assert
            Assert.AreEqual(average, 100);
        }

        [TestMethod()]
        public void merge_test() {
            List<float> grades1 = new List<float> { -100, -100, -70, -100, -100 };
            List<float> grades2 = new List<float> { 34, -76, 90, 89, 100 };
            List<float> grades3 = new List<float> { 100, 100, 70, 100, 100 };
            List<Student> students = new List<Student>
            {
                new Student("322149233", "victor", "socolovschi", "victor@gmail.com", "0547649355", grades1),
                new Student("322149345", "David", "magen", "david@gmail.com", "0547678987", grades2),
                new Student("322149345", "yossi", "Aitan", "yossi@gmail.com", "0547634544", grades3),
             };

             List<float> mergedGrades = StudentForm.Merge(students);
             List<float> expectedMergedGrades = new List<float> { -100, -100, -70, -100, -100, 34, -76, 90, 89, 100, 100, 70, 100, 100 };
             CollectionAssert.AreEqual(expectedMergedGrades, mergedGrades);
        }
    }
}
