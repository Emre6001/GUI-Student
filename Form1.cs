using FinalProje_EmreKarakaş.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProje_EmreKarakaş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindDepartment();
            
        }
        SchoolDbContext _db = new SchoolDbContext();
        public void BindCourses()
        {
            int selectTheDepartmentId = (int)lst_department.SelectedValue;
            
            lst_courses.ValueMember = "Id";
            lst_courses.DisplayMember = "CourseName";
            lst_courses.DataSource = _db.Courses.Where(d => d.DepartmentId == selectTheDepartmentId).ToList();
        }
        public void BindDepartment()
        {

            lst_department.ValueMember = "Id";
            lst_department.DisplayMember = "DepartmentName";
            lst_department.DataSource = _db.Departments.ToList();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_createDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department()
                {
                    DepartmentName = txt_addDepartment.Text,
                    Abbreviation = txt_abbreviation.Text,


                };
                _db.Departments.Add(department);
                _db.SaveChanges();
                BindDepartment();
                MessageBox.Show("Department created!");
            }
            catch(Exception ex)
            {
                lbl_departmentInfo.Text = "An error has occured. More info: " + ex.Message;
            }
            
        }

        private void btn_createCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedDepartmentId = (int)lst_department.SelectedValue;

                Course course = new Course()
                {

                    CourseName = txt_addCourses.Text,
                    CourseTitle = txt_title.Text,
                    courseCode = int.Parse(txt_courseCode.Text),
                    courseType = comboBox_CourseType.SelectedText,
                    courseCapacity = int.Parse(txt_capacity.Text),
                    DepartmentId = selectedDepartmentId,

                };
                _db.Courses.Add(course);
                _db.SaveChanges();
                BindCourses();
                MessageBox.Show("Course created!");
            }
            catch(Exception ex)
            {
                lbl_courseInfo.Text = "An error has occured. More info: " + ex.Message;
            }
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            lst_department.DataSource = _db.Departments.Where(d => d.DepartmentName.Contains(txt_search.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindCourses();
        }

        private void btn_deleteDepartment_Click(object sender, EventArgs e)
        {
            int selectedDepartment = (int)lst_department.SelectedValue;
            var deleteDepartment = _db.Departments.FirstOrDefault(d => d.Id == selectedDepartment);

            if (_db.Courses.Count(d => d.DepartmentId == selectedDepartment) == 0)
            {
                _db.Departments.Remove(deleteDepartment);
                _db.SaveChanges();
            }
            else
            {
                MessageBox.Show("You cannot delete department if there is courses!");
            }
            BindDepartment();
        }

        private void btn_deleteCourse_Click(object sender, EventArgs e)
        {
            String selectCourse = lst_courses.GetItemText(lst_courses.SelectedItem);
            var deleteCourse = _db.Courses.FirstOrDefault(c => c.CourseName == selectCourse);
            _db.Courses.Remove(deleteCourse);
            _db.SaveChanges();
            BindCourses();

        }
    }
}
