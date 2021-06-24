using System;
using System.Windows.Forms;

namespace Zoom_Visitor_s_statistic.Student
{ 
    public partial class StudentForm : Form
    {
        Student _Student = new Student();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            label1.Text = _Student.autorize("https://zoomvisitorsstat.azurewebsites.net/set_access_token/1");
        }
    }
}
