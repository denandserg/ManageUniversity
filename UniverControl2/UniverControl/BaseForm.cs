using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UniverControl
{
    public partial class University : Form
    {
        public University()
        {
            InitializeComponent();
            dataGridViewBase.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewBase_EditingControlShowing);

        }

        private string indexSelected = null;
        private string indexSelected2 = null;
        Teacher userTeacher;
        Student userStudent;
        Student currentStudent;
        private int indicate = 3;
        private string adminLogin = "admin";
        private string adminPassword = "123";
        string ContextStr = null;
        private string[] empty = null;


        public enum Entities
        {
            Admin = 0,
            Teacher = 1,
            Student = 2
        }

        public enum Mode
        {
            Normal = 0,
            EditDB = 1

        }

        public enum TableAdmin
        {

            Students,
            Audiences,
            AudLect,
            Departments,
            Groups,
            Lections,
            Marks,
            Phones,
            Speciality,
            Subjects,
            Teachers,
            TeachSubj
        }

        public enum TableTeacher
        {
            Departments,
            Groups,
            Lections,
            Marks,
            Speciality,
            Students,
            Subjects,
            Teachers
        }

        public enum TableStudent
        {
            Audiences,
            Groups,
            Lections,
            Marks,
            Phones,
            Students,
            Subjects
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (buttonLogin.Text == "Login")
            {
                if (Login())
                {
                    if (textBoxLogin.Text == "Enter you login!")
                        textBoxLogin.BackColor = Color.White;
                    if (textBoxPassword.Text == "Enter you password!")
                        textBoxPassword.BackColor = Color.White;
                    buttonLogin.Text = "Logout";
                    labelLogin.Visible = false;
                    labelPassword.Visible = false;
                    textBoxPassword.Visible = false;
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    textBoxLogin.Visible = false;
                    panelView.Visible = true;
                    buttonChangeItem.Visible = true;
                    labelHelloName.Visible = true;
                    buttonSaveMarks.Visible = true;
                    InfoShow();

                }
                else
                {
                    if (textBoxLogin.Text == "Enter you login!" || indicate > 2)
                        textBoxLogin.BackColor = Color.Red;
                    if (textBoxPassword.Text == "Enter you password!" || indicate > 2)
                        textBoxPassword.BackColor = Color.Red;
                    labelWrong.Visible = true;
                    labelHelloName.Visible = false;
                }

            }
            else
            {
                Logout();
                buttonLogin.Text = "Login";
                labelLogin.Visible = true;
                textBoxLogin.Visible = true;
                panelView.Visible = false;
                buttonChangeItem.Visible = false;
                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                labelHelloName.Visible = false;
                buttonSaveMarks.Visible = false;
            }

        }


        private void InfoShow()
        {

            int x = indicate;

            if (indicate < 3)
            {
                switch (x)
                {
                    case 0:
                        {
                            FillAdminData();
                            break;
                        }

                    case 1:
                        {
                            FillTeacherData();
                            break;
                        }

                    case 2:
                        {
                            FillStudentData();
                            break;
                        }

                }

            }

        }

        private void FillStudentData()
        {
            ClearDataGridView();
            DataGridViewComboBoxCell cell_CB = new DataGridViewComboBoxCell();
            cell_CB.Items.AddRange(new string[] { "Расписание", "Группа", "Оценки" });
            dataGridViewBase.Rows.Add();
            dataGridViewBase.Rows[0].Cells[0] = cell_CB;
            comboBoxMode.DataSource = Enum.GetValues(typeof(Mode));
            comboBoxTable.DataSource = Enum.GetValues(typeof(TableAdmin));
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonChangeItem.Enabled = false;
            comboBoxTable.Enabled = false;
            comboBoxMode.Enabled = false;
            buttonSaveMarks.Enabled = false;
        }

        private void ClearDataGridView()
        {
            for (int i = 0; i < dataGridViewBase.Columns.Count;)
                dataGridViewBase.Columns.Remove(dataGridViewBase.Columns[i]);
            for (int i = 0; i < dataGridViewBase.Rows.Count;)
                dataGridViewBase.Rows.Remove(dataGridViewBase.Rows[i]);
            dataGridViewBase.Columns.Add("ControlCol", "Control");
        }

        private void FillTeacherData()
        {
            ClearDataGridView();
            
            DataGridViewComboBoxCell cell_CB = new DataGridViewComboBoxCell();
            cell_CB.Items.AddRange(new string[] { "Расписание", "Оценки" });
            dataGridViewBase.Rows.Add();
            dataGridViewBase.Rows[0].Cells[0] = cell_CB;
            comboBoxMode.DataSource = Enum.GetValues(typeof(Mode));
            comboBoxTable.DataSource = Enum.GetValues(typeof(TableAdmin));
            comboBoxTable.Enabled = false;
            comboBoxMode.Enabled = false;
            buttonSaveMarks.Enabled = true;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonChangeItem.Enabled = false;
            buttonSaveMarks.Enabled = false;
        }

        private void FillAdminData()
        {   
            ClearDataGridView();
            DataGridViewComboBoxCell cell_CB = new DataGridViewComboBoxCell();
            cell_CB.Items.AddRange(new string[] { "tb_Marks" });
            dataGridViewBase.Rows.Add();
            dataGridViewBase.Rows[0].Cells[0] = cell_CB;
            comboBoxMode.DataSource = Enum.GetValues(typeof(Mode));
            comboBoxTable.DataSource = Enum.GetValues(typeof(TableAdmin));
            dataGridViewBase.AllowUserToAddRows = true;
            comboBoxTable.Enabled = false;
            comboBoxMode.Enabled = true;
            buttonSaveMarks.Enabled = true;
            buttonDelete.Enabled = false;
            buttonAdd.Enabled = false;
            buttonChangeItem.Enabled = false;

        }

        private void Logout()
        {
            dataGridViewBase.DataSource = null;
            dataGridViewBase.AllowUserToAddRows = false;
            indexSelected = null;
            userTeacher = null;
            userStudent = null;
            indicate = 3;
            for (int i = 0; i < dataGridViewBase.Columns.Count;)
                dataGridViewBase.Columns.Remove(dataGridViewBase.Columns[i]);
            for (int i = 0; i < dataGridViewBase.Rows.Count;)
                dataGridViewBase.Rows.Remove(dataGridViewBase.Rows[i]);
            dataGridViewBase.Columns.Add("ControlCol", "Control");
        }

        private bool Login()
        {
            var students = Unit.StudentsRepository.AllItems;
            var teachers = Unit.TeachersRepository.AllItems;
            var audlect = Unit.AudLectRepository.AllItems;
            var departments = Unit.DepartmentsRepository.AllItems;

            foreach (var teacher in teachers)
            {
                if (textBoxLogin.Text == teacher.FirstName && textBoxPassword.Text == teacher.LastName)
                {
                    indicate = (int)Entities.Teacher;
                    this.userTeacher = teacher;
                    labelHelloName.Text = $"Hello, {teacher.FirstName}  {teacher.LastName}";
                    return true;
                }

            }

            foreach (var student in students)
            {
                if (textBoxLogin.Text == student.FirstName && textBoxPassword.Text == student.LastName)
                {
                    indicate = (int)Entities.Student;
                    this.userStudent = student;
                    labelHelloName.Text = $"Hello, {student.FirstName}  {student.LastName}";
                    return true;
                }

            }

            if (textBoxLogin.Text == adminLogin && textBoxPassword.Text == adminPassword)
            {
                indicate = (int)Entities.Admin;
                labelHelloName.Text = "Hello, Admin!";
                return true;
            }
            else if (textBoxLogin.Text == null & textBoxPassword.Text == null)

            {
                return false;
            }
            else
            {
                return false;
            }

        }

        private void textBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.Text = textBoxPassword.Text == "Enter you password!" ? "" : textBoxPassword.Text;
        }

        private void textBoxLogin_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLogin.Text = textBoxLogin.Text == "Enter you login!" ? "" : textBoxLogin.Text;
        }

        private void timerBase_Tick(object sender, EventArgs e)
        {
            if (!textBoxPassword.Focused)
            {
                textBoxPassword.Text = textBoxPassword.Text == "" ? "Enter you password!" : textBoxPassword.Text;
            }

            if (!textBoxLogin.Focused)
            {
                textBoxLogin.Text = textBoxLogin.Text == "" ? "Enter you login!" : textBoxLogin.Text;
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxPassword.Text.Equals("Enter you password!"))
            {
                textBoxPassword.PasswordChar = '$';
                textBoxPassword.BackColor = Color.White;
                labelWrong.Visible = false;
            }

            else
            {
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void button_ChangeItemClick(object sender, EventArgs e)
        {
            foreach (var item in Unit.StudentsRepository.AllItems)
            {
                if (dataGridViewBase.CurrentRow.Cells[1].Value.ToString() == item.FirstName)
                    currentStudent = item;
            }

            Unit.StudentsRepository.ChangeItem(currentStudent);
            dataGridViewBase.DataSource = Unit.StudentsRepository.AllItems.ToList();

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                buttonLogin.PerformClick();
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxLogin.BackColor = Color.White;
            labelWrong.Visible = false;
        }
        void dataGridViewBase_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {   
            
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(combobox_SelectedIndexChanged);
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(combobox_SelectedIndexChanged);
            }

        }
        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem.ToString() == "Расписание" && indicate == 2)
            {
                FillStudentData();
                StudentFillShedule();

            }

            if ((sender as ComboBox).SelectedItem.ToString() == "Группа" && indicate == 2)
            {
                FillStudentData();
                GroupFillShedule();

            }


            if ((sender as ComboBox).SelectedItem.ToString() == "Оценки" && indicate == 2)
            {
                FillStudentData();
                MarksFill();

            }

            if ((sender as ComboBox).SelectedItem.ToString() == "Расписание" && indicate == 1)
            {
                FillTeacherData();
                TeacherFillShedule();

            }

            if ((sender as ComboBox).SelectedItem.ToString() == "Оценки" && indicate==1)
            {
                FillTeacherData();
                TeacherMarksFill();
                buttonSaveMarks.Enabled = true;

            }

            if ((sender as ComboBox).SelectedItem.ToString() == "tb_Marks" && indicate==0)
            {
                AdminMarksFill();
            }

        }

        private void TeacherMarksFill()
        {
            int id = userTeacher.Id;

            dataGridViewBase.Columns.Add("Subj", "Subj");
            dataGridViewBase.Columns.Add("Group", "Group");
            dataGridViewBase.Columns.Add("Student", "Student");
            dataGridViewBase.Columns.Add("Mark", "Mark");

            var stud = (from m in Unit.MarksRepository.AllItems
                        join s in Unit.StudentsRepository.AllItems
                        on m.Student.Id equals s.Id
                        join ts in Unit.TeachSubjRepository.AllItems
                        on m.TeachSubj.Id equals ts.Id
                        join teachers in Unit.TeachersRepository.AllItems
                        on ts.TeacherId equals teachers.Id
                        join ss in Unit.SubjectsRepository.AllItems
                        on ts.SubjId equals ss.Id
                        select new
                        {
                            teachers.Id,
                            m.StudentsMark,
                            Group = s.Group.Name,
                            GroupId = s.Group.Id,
                            s.LastName,
                            ss.Name
                        }).ToList();

            DataGridViewComboBoxCell cellSubjects_CB;
            bool flag = true;
            string str = null;
            try
            {
                cellSubjects_CB = dataGridViewBase.Rows[1].Cells[0] as DataGridViewComboBoxCell;
                str = cellSubjects_CB.EditedFormattedValue.ToString();
            }
            catch
            {
                flag = false;
                cellSubjects_CB = new DataGridViewComboBoxCell();
            }
            List<string> groups = new List<string>();

            foreach (var mark in stud)
                if (mark.Id == id)
                {
                    if (flag)
                    {
                        if (str == mark.Group)
                            dataGridViewBase.Rows.Add("", mark.Name,
                                mark.Group, mark.LastName, mark.StudentsMark);
                        else if (str == "All")
                            dataGridViewBase.Rows.Add("", mark.Name,
                                mark.Group, mark.LastName, mark.StudentsMark);
                    }
                    else
                        dataGridViewBase.Rows.Add("", mark.Name,
                            mark.Group, mark.LastName, mark.StudentsMark);
                    if (!groups.Contains(mark.Group))
                        groups.Add(mark.Group);
                }

            if (!flag)
            {
                groups.Add("All");
                cellSubjects_CB.Items.AddRange(groups.ToArray());
                if (dataGridViewBase.Rows.Count == 1)
                    dataGridViewBase.Rows.Add();
                dataGridViewBase.Rows[1].Cells[0] = cellSubjects_CB;
            }
        }

        private void TeacherFillShedule()
        {
            var stud =
                (from l in Unit.AudLectRepository.AllItems
                    join g in Unit.GroupsRepository.AllItems
                        on l.Group.Id equals g.Id
                    join ts in Unit.LectionsRepository.AllItems
                        on l.LectId equals ts.Id
                    join a in Unit.AudiencesRepository.AllItems
                        on l.AudId equals a.Id
                    join teas in Unit.TeachSubjRepository.AllItems
                        on l.TeachSubj.Id equals teas.Id
                    join teachers in Unit.TeachersRepository.AllItems
                        on teas.TeacherId equals teachers.Id
                    join ss in Unit.SubjectsRepository.AllItems
                        on teas.SubjId equals ss.Id
                    select new
                    {
                        l.GroupId,
                        teachers.Id,
                        Group = g.Name,
                        ts.Day,
                        ts.Start,
                        ts.Finish,
                        Audience = a.Name,
                        Teacher = teachers.LastName + " " + teachers.FirstName,
                        Subject = ss.Name

                    }).ToList();

            var _id = userTeacher.Id;
            GridAdd(1, "group");
            GridAdd(2, "day");
            GridAdd(2, "start");
            GridAdd(2, "end");
            GridAdd(2, "Auditory");
            GridAdd(2, "Teacher");
            GridAdd(2, "Subject");

            foreach (var lect in stud)
            {
                if (lect.Id == _id)
                    dataGridViewBase.Rows.Add("", lect.Group, lect.Day,
                        $"{lect.Start.Hour}:{lect.Start.Minute}",
                        $"{lect.Finish.Hour}:{lect.Finish.Minute}",
                        lect.Audience, lect.Teacher, lect.Subject);
            }
        }

        private void AdminMarksFill()
        {
            dataGridViewBase.Columns.Add("MarkId", "MarkId");
            dataGridViewBase.Columns[1].Width = 50;
            dataGridViewBase.Columns.Add("Student", "Student");
            dataGridViewBase.Columns.Add("Value", "Value");
            dataGridViewBase.Columns[3].Width = 50;
            dataGridViewBase.Columns.Add("Subject", "Subject");
            dataGridViewBase.Columns.Add("Teacher", "Teacher");
            var stud = (from m in Unit.MarksRepository.AllItems
                join s in Unit.StudentsRepository.AllItems
                    on m.Student.Id equals s.Id
                join ts in Unit.TeachSubjRepository.AllItems
                    on m.TeachSubj.Id equals ts.Id
                join teachers in Unit.TeachersRepository.AllItems
                    on ts.TeacherId equals teachers.Id
                join ss in Unit.SubjectsRepository.AllItems
                    on ts.SubjId equals ss.Id
                select new
                {
                    m.Id,
                    s.LastName,
                    m.StudentsMark,
                    Teacher = teachers.LastName,
                    ss.Name
                }).ToList();

            foreach (var mark in stud)
                dataGridViewBase.Rows.Add("", mark.Id, mark.LastName,
                    mark.StudentsMark, mark.Name, mark.Teacher);
        }
        
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Students.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.StudentsRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.AudLect.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.AudLectRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Audiences.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.AudiencesRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Departments.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.DepartmentsRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Groups.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.GroupsRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Lections.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.LectionsRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Marks.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.MarksRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Phones.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.PhonesRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Speciality.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.SpecialitiesRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Subjects.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.SubjectsRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.TeachSubj.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.TeachSubjRepository.AllItems.ToList();
            }

            if ((sender as ComboBox).SelectedItem.ToString() == TableAdmin.Teachers.ToString() && indicate == 0 && comboBoxMode.SelectedItem.ToString() == "EditDB")
            {
                dataGridViewBase.Enabled = true;
                dataGridViewBase.DataSource = Unit.TeachersRepository.AllItems.ToList();
            }
        }

        private void MarksFill()
        {
            int id = userStudent.Id;
            dataGridViewBase.Columns.Add("Mark", "Mark");
            dataGridViewBase.Columns.Add("Subj", "Subj");
            dataGridViewBase.Columns.Add("Teacher", "Teacher");

            var stud = (from m in Unit.MarksRepository.AllItems
                        join s in Unit.StudentsRepository.AllItems
                            on m.Student.Id equals s.Id
                        join ts in Unit.TeachSubjRepository.AllItems
                            on m.TeachSubj.Id equals ts.Id
                        join teachers in Unit.TeachersRepository.AllItems
                            on ts.TeacherId equals teachers.Id
                        join ss in Unit.SubjectsRepository.AllItems
                            on ts.SubjId equals ss.Id
                        select new
                        {
                            s.Id,
                            m.StudentsMark,
                            teachers.LastName,
                            ss.Name
                        }).ToList();

            foreach (var mark in stud)
                if (mark.Id == id)
                    dataGridViewBase.Rows.Add("", mark.StudentsMark, mark.Name, mark.LastName);
           
        }

        private void GroupFillShedule()
        {
            dataGridViewBase.Columns.Add("FirstName", "FirstName");
            dataGridViewBase.Columns.Add("LastName", "LastName");
            dataGridViewBase.Columns.Add("Birthday", "Birthday");
            dataGridViewBase.Columns.Add("LogBook", "LogBook");
            dataGridViewBase.Columns.Add("Email", "Email");
            dataGridViewBase.Columns.Add("Address", "Address");
            dataGridViewBase.Columns.Add("Phone", "Phone");
            int id = userStudent.Id;
            string groupId = null;

            var stud = (from p in Unit.PhonesRepository.AllItems
                        join s in Unit.StudentsRepository.AllItems
                            on p.Student.Id equals s.Id
                        join g in Unit.GroupsRepository.AllItems
                            on s.Group.Id equals g.Id
                        select new
                        {
                            s.Id,
                            s.FirstName,
                            s.LastName,
                            Logbook = s.LogbookNumber,
                            Number = p.StudentsPhone,
                            s.Birthday,
                            s.Email,
                            s.Address,
                            Group = g.Name
                        }).ToList();

            foreach (var st in stud)
                if (st.Id == id)
                    groupId = st.Group;

            foreach (var st in stud)
                if (st.Group == groupId)
                    dataGridViewBase.Rows.Add("", st.FirstName, st.LastName,
                        st.Birthday.ToString("dd/MM/yyyy"),
                        st.Logbook, st.Email, st.Address, st.Number);

        }

        private void StudentFillShedule()
        {

            var stud =
                            (from l in Unit.AudLectRepository.AllItems
                             join g in Unit.GroupsRepository.AllItems
                                 on l.Group.Id equals g.Id
                             join ts in Unit.LectionsRepository.AllItems
                                 on l.LectId equals ts.Id
                             join a in Unit.AudiencesRepository.AllItems
                                 on l.AudId equals a.Id
                             join teas in Unit.TeachSubjRepository.AllItems
                                 on l.TeachSubj.Id equals teas.Id
                             join teachers in Unit.TeachersRepository.AllItems
                                 on teas.TeacherId equals teachers.Id
                             join ss in Unit.SubjectsRepository.AllItems
                                 on teas.SubjId equals ss.Id
                             select new
                             {
                                 l.GroupId,
                                 Group = g.Name,
                                 ts.Day,
                                 ts.Start,
                                 ts.Finish,
                                 Audience = a.Name,
                                 Teacher = teachers.LastName + " " + teachers.FirstName,
                                 Subject = ss.Name

                             }).ToList();

            var _group = userStudent.Group.Id;
            GridAdd(1, "group");
            GridAdd(2, "day");
            GridAdd(2, "start");
            GridAdd(2, "end");
            GridAdd(2, "Auditory");
            GridAdd(2, "Teacher");
            GridAdd(2, "Subject");

            foreach (var lect in stud)
            {
                if (lect.GroupId == _group)
                    dataGridViewBase.Rows.Add("", lect.Group, lect.Day,
                        $"{lect.Start.Hour}:{lect.Start.Minute}",
                        $"{lect.Finish.Hour}:{lect.Finish.Minute}",
                        lect.Audience, lect.Teacher, lect.Subject);
            }
           
        }
        private void GridAdd(int t, string name)
        {
            dataGridViewBase.Columns.Add(name, name);
            dataGridViewBase.Columns[t].Width = 50;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Unit.StudentsRepository.AddItem(new Student
            {
                FirstName = "VASA",
                MiddleName = "Libb",
                LastName = "Mute",
                Address = "Toronto",
                Birthday = new DateTime(1993, 10, 10),
                Email = "g@gmail.com",
                LogbookNumber = 00012,
                Group = null
            });

            dataGridViewBase.DataSource = Unit.StudentsRepository.AllItems.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var x = dataGridViewBase.CurrentRow.Cells[9].Value;
            Unit.StudentsRepository.DeleteItem((int)dataGridViewBase.CurrentRow.Cells[9].Value);
            dataGridViewBase.DataSource = Unit.StudentsRepository.AllItems.ToList();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem.ToString() == "Normal" && indicate == 0)
            {
                dataGridViewBase.DataSource = null;
                FillAdminData();
                comboBoxTable.Enabled = false;
                buttonDelete.Enabled = false;
                buttonAdd.Enabled = false;
                buttonChangeItem.Enabled = false;
            }

            if (comboBoxMode.SelectedItem.ToString() == "EditDB" && indicate == 0)
            {
                ClearDataGridView();
                dataGridViewBase.Enabled = true;
                comboBoxTable.Enabled = true;
                dataGridViewBase.Enabled = false;
                buttonDelete.Enabled = true;
                buttonAdd.Enabled = true;
                buttonChangeItem.Enabled = true;
            }
        }

        private void buttonSaveMarks_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cell_CB = dataGridViewBase.Rows[0].Cells[0] as DataGridViewComboBoxCell;
            if (cell_CB.EditedFormattedValue.ToString().Equals("tb_Marks"))
            {
                dataGridViewBase.Columns.Add("MarkId", "MarkId");
                dataGridViewBase.Columns[1].Width = 50;
                dataGridViewBase.Columns.Add("Student", "Student");
                dataGridViewBase.Columns.Add("Value", "Value");
                dataGridViewBase.Columns[3].Width = 50;
                dataGridViewBase.Columns.Add("Subject", "Subject");
                dataGridViewBase.Columns.Add("Teacher", "Teacher");
                var stud = (from m in Unit.MarksRepository.AllItems
                            join s in Unit.StudentsRepository.AllItems
                            on m.Student.Id equals s.Id
                            join ts in Unit.TeachSubjRepository.AllItems
                            on m.TeachSubj.Id equals ts.Id
                            join teachers in Unit.TeachersRepository.AllItems
                            on ts.TeacherId equals teachers.Id
                            join ss in Unit.SubjectsRepository.AllItems
                            on ts.SubjId equals ss.Id
                            select new
                            {
                                m.Id,
                                sId = s.Id,
                                s.LastName,
                                m.StudentsMark,
                                Teacher = teachers.LastName,
                                ss.Name
                            }).ToList();
                int i = 1;
                foreach (var mark in stud)
                {
                    DataGridViewRow row = dataGridViewBase.Rows[i];
                    if (row.Cells[1].Value.ToString() == mark.Id.ToString())
                    {
                        bool flagUpdate = false;
                        if (row.Cells[2].Value.ToString() != mark.LastName)
                            flagUpdate = true;
                        if (row.Cells[3].Value.ToString() != mark.StudentsMark.ToString())
                            flagUpdate = true;
                        if (row.Cells[4].Value.ToString() != mark.Name)
                            flagUpdate = true;
                        if (row.Cells[5].Value.ToString() != mark.Teacher)
                            flagUpdate = true;
                        if (flagUpdate)
                            SaveMarks(mark.Id, new int[] {
                                Int32.Parse(row.Cells[3].Value.ToString()) });
                    }
                    else
                        i--;
                    i++;
                }
            }
        }

        private void SaveMarks(int id, int[] args)
        {
            if (true)
            {
                Mark newitem = Unit.MarksRepository.GetItem(id);
                newitem.StudentsMark = args[0];
                Unit.MarksRepository.ChangeItem(newitem);
            }
        }
    }
}
