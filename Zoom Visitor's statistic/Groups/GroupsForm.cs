using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoom_Visitor_s_statistic.JSONS;

namespace Zoom_Visitor_s_statistic.Groups
{
    public partial class GroupsForm : Form
    {
        private readonly Group group;
        private StudentsInfo studentsInfo;
        public GroupsForm()
        {
            studentsInfo = new StudentsInfo();
            group = new Group();
            InitializeComponent();
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            refreshStudents();
            refreshGroups();
        }

        private void refreshStudents()
        {
            string content = "";
            using (var request = new HttpRequest())
            {
                content = request.Get(
                    $"https://localhost:44353/get_students").ToString();
            }

            StudentsTable.Columns.Clear();
            StudentsTable.Rows.Clear();

            if (content != "{\"students\":[{]}")
            {
                StudentsTable.Columns.Add("Email", "Email");
                StudentsTable.Columns.Add("FirstName", "First name");
                StudentsTable.Columns.Add("LastName", "Last name");
                StudentsTable.Columns.Add("Group", "Group");

                studentsInfo = StudentsInfo.FromJson(content); // если 
                for (int i = 0; i < studentsInfo.Students.Count(); i++)
                {
                    if (!(groupExist(studentsInfo.Students[i].Group)))
                    {
                        StudentsTable.Rows.Add(studentsInfo.Students[i].Email,
                                                studentsInfo.Students[i].FirstName,
                                                studentsInfo.Students[i].LastName,
                                                studentsInfo.Students[i].Group);
                        StudentsTable["Group", i].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        StudentsTable.Rows.Add(studentsInfo.Students[i].Email,
                                                        studentsInfo.Students[i].FirstName,
                                                        studentsInfo.Students[i].LastName,
                                                        studentsInfo.Students[i].Group);
                    }
                }
            }
            else
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Студентов не обнаружено.";
            }
        }

        private bool groupExist(string group)
        {
            string[] groups;
            using (var request = new HttpRequest())
            {
                string contentGroups = request.Get(
                    $"https://localhost:44353/get_groups").ToString();

                groups = contentGroups.Split(':');
            }
            for (int i = 0; i < groups.Length-1; i++)
            {
                if (groups[i] == group) {
                    return true;
                }
            }
            return false;
        }

        private void refreshGroups()
        {
            GroupsBox.Items.Clear();
            string[] groups;
            using (var request = new HttpRequest())
            {
                string content = request.Get(
                    $"https://localhost:44353/get_groups").ToString();

                groups = content.Split(':');
            }
            for (int i = 0; i < groups.Length-1; i++)
            {
                GroupsBox.Items.Add(groups[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e) // add group
        {
            using (var request = new HttpRequest())
            {
                string content = request.Get(
                    $"https://localhost:44353/set_groups/{textBox6.Text}").ToString();

                if (content == "exist") { addGroupResult.Text = "Группа уже существует.";
                    addGroupResult.ForeColor = System.Drawing.Color.Red;
                } // уже существует
                else
                {
                    addGroupResult.Text = "Группа добавлена.";
                    addGroupResult.ForeColor = System.Drawing.Color.Green;
                }

            }
            refreshGroups();
            refreshStudents();
        }

        private void button1_Click(object sender, EventArgs e) // add stud
        {
            using (var request = new HttpRequest())
            {
                GroupsBox.Text = GroupsBox.Text.Trim();

                request.AddHeader("Content-Type", "application/json");

                string content = request.Post(
                    $"https://localhost:44353/set_students?Email={textBox1.Text}&First_name={textBox2.Text}&Last_name={textBox3.Text}&Groups={GroupsBox.Text}").ToString();

                if (content == "exist") 
                {
                    label9.Text = "Студент уже существует.";
                    label9.ForeColor = System.Drawing.Color.Red;
                } // уже существует
                else
                {
                    label9.Text = "Студент добавлен.";
                    label9.ForeColor = System.Drawing.Color.Green;
                    label7.Text = "";
                    refreshStudents();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // удалить группу
        {
            using (var request = new HttpRequest())
            {
                string content = request.Get(
                    $"https://localhost:44353/del_groups/{textBox6.Text}").ToString();

                if (content == "notexist")
                {
                    addGroupResult.Text = "Группа не существует.";
                    addGroupResult.ForeColor = System.Drawing.Color.Red;
                } // уже существует
                else
                {
                    addGroupResult.Text = "Группа удалена.";
                    addGroupResult.ForeColor = System.Drawing.Color.Green;
                }

            }
            refreshGroups();
            refreshStudents();
        }

        private void button4_Click(object sender, EventArgs e) // удалить студента
        {
            using (var request = new HttpRequest())
            {
                GroupsBox.Text = GroupsBox.Text.Trim();

                request.AddHeader("Content-Type", "application/json");

                string content = request.Post(
                    $"https://localhost:44353/del_students?Email={textBox1.Text}&First_name={textBox2.Text}&Last_name={textBox3.Text}&Groups={GroupsBox.Text}").ToString();

                if (content == "notexist")
                {
                    label9.Text = "Студент не существует.";
                    label9.ForeColor = System.Drawing.Color.Red;
                } // уже существует
                else
                {
                    label9.Text = "Студент удален.";
                    label9.ForeColor = System.Drawing.Color.Green;
                    label7.Text = "";
                    refreshStudents();
                }
            }
        }
    }
}
