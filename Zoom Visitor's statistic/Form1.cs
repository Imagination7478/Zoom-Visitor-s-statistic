using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using Zoom_Visitor_s_statistic.Teacher;

namespace Zoom_Visitor_s_statistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Проходит авторизация. Подождите...";
            TeacherForm Teacher = new TeacherForm();
            System.Diagnostics.Process.Start("https://zoom.us/oauth/authorize?response_type=code&client_id=kqTAQFgVQhuZTLrRlE6J4A&code_challenge=1111&redirect_uri=https://zoomvisitorsstat.azurewebsites.net/set_access_token/0");
            /// todo: make app.config, that will count client_id and secret
            Hide();
            Teacher.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
