using System;
using System.Windows.Forms;


namespace Zoom_Visitor_s_statistic.Teacher
{
    public partial class TeacherForm : Form
    {
        Teacher _Teacher = new Teacher();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Teacher.autorize(textBox1.Text, "https://webhook.site/78dabefc-7e71-46fd-944e-8c7cc5e610c8");
            
        }
    }
}
