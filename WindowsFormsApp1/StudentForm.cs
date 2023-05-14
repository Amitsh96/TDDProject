using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TDD
{
    public partial class StudentForm : Form
    {
        public List<Student> studentList = new List<Student>();


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
        private void btn_add10k_Click(object sender, EventArgs e)
        {

        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            // Student form will open report form when clicked
            ReportForm rp = new ReportForm();
           

            DataTable dt = new DataTable();
            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name",typeof(string));
            dt.Columns.Add("GPA",typeof(float));

            for (int i = 0; i < studentList.Count; i++) {
                dt.Rows.Add(studentList[i].ID, studentList[i].FirstName, studentList[i].LastName, studentList[i].Average);
            }

            rp.dataGridView1.DataSource = dt;
            rp.ShowDialog();

          

        }
    }
}
