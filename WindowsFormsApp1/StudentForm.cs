using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TDD
{
    public partial class StudentForm : Form
    {
        public List<Student> studentList = new List<Student>();
        Random rand = new Random();
   

        public StudentForm()
        {
            InitializeComponent();
        }       
        private void StudentForm_Load(object sender, EventArgs e)
        {


        }
        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            string ID = tb_id.Text;
            string FirstName = tb_firstname.Text;
            string LastName = tb_lastname.Text;
            string Email = tb_email.Text;
            string PhoneNumber = tb_phone.Text;
            int grade1, grade2, grade3, grade4, grade5;
            int.TryParse(tb_grade1.Text, out grade1);
            int.TryParse(tb_grade2.Text, out grade2);
            int.TryParse(tb_grade3.Text, out grade3);
            int.TryParse(tb_grade4.Text, out grade4);
            int.TryParse(tb_grade5.Text, out grade5);


            if (ID.Length == 9 && ID.All(char.IsDigit) && Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") && Regex.IsMatch(LastName, @"^[a-zA-Z]+$") && Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && PhoneNumber.Length == 10 && PhoneNumber.All(char.IsDigit) &&
                tb_grade1.Text != "" && tb_grade2.Text != "" && tb_grade3.Text != "" && tb_grade4.Text != "" && tb_grade5.Text != "")
            {
                if ((grade1 >= 0 && grade1 <= 100 || grade1 == 777) && (grade2 >= 0 && grade2 <= 100 || grade2 == 777) && (grade3 >= 0 && grade3 <= 100 || grade3 == 777) && (grade4 >= 0 && grade4 <= 100 || grade4 == 777) && (grade5 >= 0 && grade5 <= 100 || grade5 == 777))
                {
                    if (grade1 == 777)
                    {
                        grade1 = 777;
                    }
                    if (grade2 == 777)
                    {
                        grade2 = 777;
                    }
                    if (grade3 == 777)
                    {
                        grade3 = 777;
                    }
                    if (grade4 == 777)
                    {
                        grade4 = 777;
                    }
                    if (grade5 == 777)
                    {
                        grade5 = 777;
                    }
                    Student new_student = new Student(ID, FirstName, LastName, Email, PhoneNumber, grade1, grade2, grade3, grade4, grade5);
                    studentList.Add(new_student);

                    // clear text box fields after pressing add student
                    tb_id.Text = "";
                    tb_firstname.Text = "";
                    tb_lastname.Text = "";
                    tb_email.Text = "";
                    tb_phone.Text = "";
                    tb_grade1.Text = "";
                    tb_grade2.Text = "";
                    tb_grade3.Text = "";
                    tb_grade4.Text = "";
                    tb_grade5.Text = "";

                }


            }
            else 
            {
                MessageBox.Show("one or more of the above details is incorrect","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btn_add10k_Click(object sender, EventArgs e)
        {

            string[] FirstNameList = {"Robert", "Victor", "Amit", "David", "Tom", "Andrew", "Gabriel", "Liron", "Natalia", "Vica", "Marina", "Jeniffer", "Rebbeca"};
            string[] LastNameList = {"Hanks", "Pass", "Shitrit", "Fidelis", "Netanyehu", "Lawrence", "Cruise", "Beckham", "Brodkin", "James", "Jordan","Ronald", "Chapmen","Muller"} ;
            for (int i = 0; i < 10000; i++)
            {
                string randFirstName = FirstNameList[rand.Next(FirstNameList.Length)];
                string randomLastName = LastNameList[rand.Next(LastNameList.Length)];

                double randGrade1 = rand.Next(0, 101);
                double randGrade2 = rand.Next(0, 101);
                double randGrade3 = rand.Next(0, 101);
                double randGrade4 = rand.Next(0, 101);
                double randGrade5 = rand.Next(0, 101);

                int randomID = rand.Next(100000000, 1000000000);
                int randphone = rand.Next(500000000, 599999999);
                string randomphone = "0" + randphone.ToString();

               
                string randEmail = randFirstName + "@mail.com";
                string firstName = randFirstName;
                string lastName = randomLastName;
                string Id = randomID.ToString();
                string Email = randEmail;
                string phoneNumber = randomphone;
                int notGradeOne = rand.Next(1, 2);
                int noGradeTwo = rand.Next(0, 2);
                int noGradeThree = rand.Next(0, 2);
                int noGradeFour = rand.Next(0, 2);
                int noGradeFive = rand.Next(0, 2);
                int grade1 = (int)(notGradeOne == 0 ? randGrade1 : 777);
                int grade2 = (int)(noGradeTwo == 0 ? randGrade2 : 777);
                int grade3 = (int)(noGradeThree == 0 ? randGrade3 : 777);
                int grade4 = (int)(noGradeFour == 0 ? randGrade4 : 777);
                int grade5 = (int)(noGradeFive == 0 ? randGrade5 : 777);

                Student random_student = new Student(Id, firstName, lastName, Email, phoneNumber, grade1, grade2, grade3, grade4, grade5);
                studentList.Add(random_student);
             
            }

        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            // sort with bubble sort, high top to low
            //List<Student> BubbleSort(List<Student> studentList)
            //{
            //    int n = studentList.Count();
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (studentList[j].Average < studentList[j + 1].Average)
            //            {
            //                double temp = studentList[j].Average;
            //                studentList[j].Average = studentList[j + 1].Average;
            //                studentList[j + 1].Average = (float)temp;
            //            }
            //        }
            //    }
            //    return studentList;
            //}
            //BubbleSort(studentList);


            void Merge(List<Student> studentList, int left, int middle, int right)
            {
                int leftArrayLength = middle - left + 1;
                int rightArrayLength = right - middle;

                // Create temporary arrays to hold the left and right halves
                double[] leftArray = new double[leftArrayLength];
                double[] rightArray = new double[rightArrayLength];

                // Copy the left half of the array to the left temporary array
                for (int i = 0; i < leftArrayLength; i++)
                {
                    leftArray[i] = studentList[left + i].Average;
                }

                // Copy the right half of the array to the right temporary array
                for (int i = 0; i < rightArrayLength; i++)
                {
                    rightArray[i] = studentList[middle + 1 + i].Average;
                }

                // Merge the two temporary arrays into the original array
                int j = 0;
                int k = 0;
                int l = left;

                while (j < leftArrayLength && k < rightArrayLength)
                {
                    if (leftArray[j] >= rightArray[k]) // Change the comparison from <= to >=
                    {
                        studentList[l].Average = (float)leftArray[j];
                        j++;
                    }
                    else
                    {
                        studentList[l].Average = (float)rightArray[k];
                        k++;
                    }
                    l++;
                }

                // Copy the remaining elements of the left temporary array to the original array
                while (j < leftArrayLength)
                {
                    studentList[l].Average = (float)leftArray[j];
                    j++;
                    l++;
                }

                // Copy the remaining elements of the right temporary array to the original array
                while (k < rightArrayLength)
                {
                    studentList[l].Average = (float)rightArray[k];
                    k++;
                    l++;
                }
            }


            List<Student> MergeSort(List<Student> studentList, int left, int right)
            {
                if (left < right)
                {
                    // Calculate the middle index
                    int middle = (left + right) / 2;

                    // Sort the left half of the array
                    MergeSort(studentList, left, middle);

                    // Sort the right half of the array
                    MergeSort(studentList, middle + 1, right);

                    // Merge the two halves
                    Merge(studentList, left, middle, right);
                }
                return studentList;
            }


            // Student form will open report form when clicked 
            ReportForm rp = new ReportForm();
           

            DataTable dt = new DataTable();
            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name",typeof(string));
            dt.Columns.Add("GPA",typeof(float));

            MergeSort(studentList, 0, studentList.Count - 1);

            for (int i = 0; i < studentList.Count; i++) {
                dt.Rows.Add(studentList[i].ID, studentList[i].FirstName, studentList[i].LastName, studentList[i].Average);
            }

            rp.dataGridView1.DataSource = dt;
            rp.ShowDialog();



        }
    }
}
