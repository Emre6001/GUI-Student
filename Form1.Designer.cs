namespace FinalProje_EmreKarakaş
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_department = new System.Windows.Forms.ListBox();
            this.lst_courses = new System.Windows.Forms.ListBox();
            this.btn_deleteCourse = new System.Windows.Forms.Button();
            this.btn_deleteDepartment = new System.Windows.Forms.Button();
            this.txt_addDepartment = new System.Windows.Forms.TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_addCourse = new System.Windows.Forms.Label();
            this.txt_addCourses = new System.Windows.Forms.TextBox();
            this.lbl_abbreviation = new System.Windows.Forms.Label();
            this.lbl_courseCode = new System.Windows.Forms.Label();
            this.txt_abbreviation = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_courseCode = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.comboBox_CourseType = new System.Windows.Forms.ComboBox();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.btn_createDepartment = new System.Windows.Forms.Button();
            this.btn_createCourse = new System.Windows.Forms.Button();
            this.lbl_departmentInfo = new System.Windows.Forms.Label();
            this.lbl_courseInfo = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.lbl_searchOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_department
            // 
            this.lst_department.FormattingEnabled = true;
            this.lst_department.ItemHeight = 25;
            this.lst_department.Location = new System.Drawing.Point(110, 450);
            this.lst_department.Name = "lst_department";
            this.lst_department.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_department.Size = new System.Drawing.Size(214, 179);
            this.lst_department.TabIndex = 0;
            this.lst_department.SelectedIndexChanged += new System.EventHandler(this.lst_department_SelectedIndexChanged);
            // 
            // lst_courses
            // 
            this.lst_courses.FormattingEnabled = true;
            this.lst_courses.ItemHeight = 25;
            this.lst_courses.Location = new System.Drawing.Point(471, 450);
            this.lst_courses.Name = "lst_courses";
            this.lst_courses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_courses.Size = new System.Drawing.Size(221, 179);
            this.lst_courses.TabIndex = 1;
            // 
            // btn_deleteCourse
            // 
            this.btn_deleteCourse.Location = new System.Drawing.Point(538, 656);
            this.btn_deleteCourse.Name = "btn_deleteCourse";
            this.btn_deleteCourse.Size = new System.Drawing.Size(112, 34);
            this.btn_deleteCourse.TabIndex = 2;
            this.btn_deleteCourse.Text = "Delete";
            this.btn_deleteCourse.UseVisualStyleBackColor = true;
            this.btn_deleteCourse.Click += new System.EventHandler(this.btn_deleteCourse_Click);
            // 
            // btn_deleteDepartment
            // 
            this.btn_deleteDepartment.Location = new System.Drawing.Point(204, 656);
            this.btn_deleteDepartment.Name = "btn_deleteDepartment";
            this.btn_deleteDepartment.Size = new System.Drawing.Size(112, 34);
            this.btn_deleteDepartment.TabIndex = 3;
            this.btn_deleteDepartment.Text = "Delete";
            this.btn_deleteDepartment.UseVisualStyleBackColor = true;
            this.btn_deleteDepartment.Click += new System.EventHandler(this.btn_deleteDepartment_Click);
            // 
            // txt_addDepartment
            // 
            this.txt_addDepartment.Location = new System.Drawing.Point(204, 180);
            this.txt_addDepartment.Name = "txt_addDepartment";
            this.txt_addDepartment.Size = new System.Drawing.Size(144, 31);
            this.txt_addDepartment.TabIndex = 4;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(26, 183);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(167, 25);
            this.lbl_department.TabIndex = 5;
            this.lbl_department.Text = " Depatment Name :";
            // 
            // lbl_addCourse
            // 
            this.lbl_addCourse.AutoSize = true;
            this.lbl_addCourse.Location = new System.Drawing.Point(440, 137);
            this.lbl_addCourse.Name = "lbl_addCourse";
            this.lbl_addCourse.Size = new System.Drawing.Size(128, 25);
            this.lbl_addCourse.TabIndex = 6;
            this.lbl_addCourse.Text = "Course Name :";
            // 
            // txt_addCourses
            // 
            this.txt_addCourses.Location = new System.Drawing.Point(629, 134);
            this.txt_addCourses.Name = "txt_addCourses";
            this.txt_addCourses.Size = new System.Drawing.Size(125, 31);
            this.txt_addCourses.TabIndex = 7;
            // 
            // lbl_abbreviation
            // 
            this.lbl_abbreviation.AutoSize = true;
            this.lbl_abbreviation.Location = new System.Drawing.Point(39, 241);
            this.lbl_abbreviation.Name = "lbl_abbreviation";
            this.lbl_abbreviation.Size = new System.Drawing.Size(123, 25);
            this.lbl_abbreviation.TabIndex = 9;
            this.lbl_abbreviation.Text = "Abbreviation :";
            // 
            // lbl_courseCode
            // 
            this.lbl_courseCode.AutoSize = true;
            this.lbl_courseCode.Location = new System.Drawing.Point(440, 227);
            this.lbl_courseCode.Name = "lbl_courseCode";
            this.lbl_courseCode.Size = new System.Drawing.Size(123, 25);
            this.lbl_courseCode.TabIndex = 10;
            this.lbl_courseCode.Text = "Course Code :";
            // 
            // txt_abbreviation
            // 
            this.txt_abbreviation.Location = new System.Drawing.Point(204, 235);
            this.txt_abbreviation.Name = "txt_abbreviation";
            this.txt_abbreviation.Size = new System.Drawing.Size(144, 31);
            this.txt_abbreviation.TabIndex = 11;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(440, 183);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(53, 25);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Title :";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(629, 178);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(125, 31);
            this.txt_title.TabIndex = 13;
            // 
            // txt_courseCode
            // 
            this.txt_courseCode.Location = new System.Drawing.Point(630, 227);
            this.txt_courseCode.Name = "txt_courseCode";
            this.txt_courseCode.Size = new System.Drawing.Size(125, 31);
            this.txt_courseCode.TabIndex = 14;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(440, 281);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(118, 25);
            this.lbl_type.TabIndex = 15;
            this.lbl_type.Text = "Course Type :";
            // 
            // comboBox_CourseType
            // 
            this.comboBox_CourseType.FormattingEnabled = true;
            this.comboBox_CourseType.Items.AddRange(new object[] {
            "Elective",
            "Mandatory"});
            this.comboBox_CourseType.Location = new System.Drawing.Point(630, 281);
            this.comboBox_CourseType.Name = "comboBox_CourseType";
            this.comboBox_CourseType.Size = new System.Drawing.Size(126, 33);
            this.comboBox_CourseType.TabIndex = 16;
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(440, 339);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(88, 25);
            this.lbl_capacity.TabIndex = 17;
            this.lbl_capacity.Text = "Capacity :";
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(630, 333);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(124, 31);
            this.txt_capacity.TabIndex = 18;
            this.txt_capacity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_createDepartment
            // 
            this.btn_createDepartment.Location = new System.Drawing.Point(236, 299);
            this.btn_createDepartment.Name = "btn_createDepartment";
            this.btn_createDepartment.Size = new System.Drawing.Size(112, 34);
            this.btn_createDepartment.TabIndex = 19;
            this.btn_createDepartment.Text = "Create";
            this.btn_createDepartment.UseVisualStyleBackColor = true;
            this.btn_createDepartment.Click += new System.EventHandler(this.btn_createDepartment_Click);
            // 
            // btn_createCourse
            // 
            this.btn_createCourse.Location = new System.Drawing.Point(642, 393);
            this.btn_createCourse.Name = "btn_createCourse";
            this.btn_createCourse.Size = new System.Drawing.Size(112, 34);
            this.btn_createCourse.TabIndex = 20;
            this.btn_createCourse.Text = "Create";
            this.btn_createCourse.UseVisualStyleBackColor = true;
            this.btn_createCourse.Click += new System.EventHandler(this.btn_createCourse_Click);
            // 
            // lbl_departmentInfo
            // 
            this.lbl_departmentInfo.AutoSize = true;
            this.lbl_departmentInfo.Location = new System.Drawing.Point(39, 370);
            this.lbl_departmentInfo.Name = "lbl_departmentInfo";
            this.lbl_departmentInfo.Size = new System.Drawing.Size(0, 25);
            this.lbl_departmentInfo.TabIndex = 21;
            // 
            // lbl_courseInfo
            // 
            this.lbl_courseInfo.AutoSize = true;
            this.lbl_courseInfo.Location = new System.Drawing.Point(738, 438);
            this.lbl_courseInfo.Name = "lbl_courseInfo";
            this.lbl_courseInfo.Size = new System.Drawing.Size(0, 25);
            this.lbl_courseInfo.TabIndex = 22;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(101, 117);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(279, 31);
            this.txt_search.TabIndex = 23;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(330, 516);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(124, 34);
            this.btn_show.TabIndex = 24;
            this.btn_show.Text = "Show ";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_searchOption
            // 
            this.lbl_searchOption.AutoSize = true;
            this.lbl_searchOption.Location = new System.Drawing.Point(101, 71);
            this.lbl_searchOption.Name = "lbl_searchOption";
            this.lbl_searchOption.Size = new System.Drawing.Size(134, 25);
            this.lbl_searchOption.TabIndex = 25;
            this.lbl_searchOption.Text = "Search Option :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 772);
            this.Controls.Add(this.lbl_searchOption);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_courseInfo);
            this.Controls.Add(this.lbl_departmentInfo);
            this.Controls.Add(this.btn_createCourse);
            this.Controls.Add(this.btn_createDepartment);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.comboBox_CourseType);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.txt_courseCode);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_abbreviation);
            this.Controls.Add(this.lbl_courseCode);
            this.Controls.Add(this.lbl_abbreviation);
            this.Controls.Add(this.txt_addCourses);
            this.Controls.Add(this.lbl_addCourse);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.txt_addDepartment);
            this.Controls.Add(this.btn_deleteDepartment);
            this.Controls.Add(this.btn_deleteCourse);
            this.Controls.Add(this.lst_courses);
            this.Controls.Add(this.lst_department);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_department;
        private System.Windows.Forms.ListBox lst_courses;
        private System.Windows.Forms.Button btn_deleteCourse;
        private System.Windows.Forms.Button btn_deleteDepartment;
        private System.Windows.Forms.TextBox txt_addDepartment;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_addCourse;
        private System.Windows.Forms.TextBox txt_addCourses;
        private System.Windows.Forms.Label lbl_abbreviation;
        private System.Windows.Forms.Label lbl_courseCode;
        private System.Windows.Forms.TextBox txt_abbreviation;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_courseCode;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox comboBox_CourseType;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Button btn_createDepartment;
        private System.Windows.Forms.Button btn_createCourse;
        private System.Windows.Forms.Label lbl_departmentInfo;
        private System.Windows.Forms.Label lbl_courseInfo;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox_selectDepartment;
        private System.Windows.Forms.Label lbl_selectDepartment;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label lbl_searchOption;
    }
}
