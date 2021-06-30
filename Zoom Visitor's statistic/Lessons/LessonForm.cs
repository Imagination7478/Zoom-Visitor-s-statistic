using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_Visitor_s_statistic.Lessons
{
    public partial class LessonForm : Form
    {
        private readonly Lesson lesson;


        public LessonForm()
        {
            lesson = new Lesson();
            InitializeComponent();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
