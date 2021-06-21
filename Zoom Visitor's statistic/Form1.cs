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
            Teacher.TeacherForm Teacher = new Teacher.TeacherForm();
            Hide();
            System.Diagnostics.Process.Start("https://zoom.us/oauth/authorize?response_type=code&client_id=kqTAQFgVQhuZTLrRlE6J4A&code_challenge=1111&redirect_uri=https%3A%2F%2Fwebhook.site%2F78dabefc-7e71-46fd-944e-8c7cc5e610c8");
            /// todo: make app.config, that will count client_id and secret
            Teacher.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
