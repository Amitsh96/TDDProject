using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Student
    {
        private int ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private int PhoneNumber { get; set; }
        public float Average { get; set;}
        public Student(int ID, string firstName, string lastName, string email, int phoneNumber, int grade1, int grade2, int grade3, int grade4, int grade5)
        {
            this.ID = ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            int gradesSum = 0;
            int legalGrades = 0;
            int[] grades = { grade1, grade2, grade3, grade4, grade5 };
            for(int i = 0; i<5; i++)
            {
                if (gradeIsLegal(grades[i]))
                {
                    gradesSum += grades[i];
                    legalGrades++;
                }
            }
            this.Average = gradesSum/legalGrades;
        }
        public Boolean gradeIsLegal(int grade)
        {
            return grade != 777;
        }
    }
}
