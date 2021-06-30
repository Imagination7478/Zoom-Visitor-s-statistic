using Leaf.xNet;
using System;

using System.Windows.Forms;
using Zoom_Visitor_s_statistic.Groups;
using Zoom_Visitor_s_statistic.JSONS;
using Zoom_Visitor_s_statistic.Statistic;

namespace Zoom_Visitor_s_statistic.Teacher
{
    public partial class TeacherForm : Form
    {
        Teacher _Teacher = new Teacher();
        UserData userdata;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            string result = _Teacher.autorize("https://localhost:44353/set_access_token/0");
            if (result == "1")
            {
                showGroup.Hide();
                ShowStat.Hide();
                label1.Text = "Ваш аккаунт не был найден в базе данных.\nОбратитесь к системному администратору.";
            }
            else { 
                userdata = UserData.FromJson(result);
                label1.Text = $"Вы успешно авторизовались!\nДобро пожаловать {userdata.FirstName} {userdata.LastName}.";
            }
        }

        private void CreateConf_Click(object sender, EventArgs e)
        {
            using (var request = new HttpRequest())
            {
                var reqParams = new RequestParams();

                string content = request.Post(
                    $"https://api.zoom.us/v2/users/{userdata.Id}/meetings", reqParams).ToString();

                //return Ok(content);
            }
        }

        private void ShowStat_Click(object sender, EventArgs e)
        {
            StatForm stat = new StatForm(userdata);
            stat.Show();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupsForm group = new GroupsForm();
            group.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
