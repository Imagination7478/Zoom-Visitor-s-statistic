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
            _Student.autorize(textBox1.Text, "https://webhook.site/78dabefc-7e71-46fd-944e-8c7cc5e610c8");
        }
    }
}
