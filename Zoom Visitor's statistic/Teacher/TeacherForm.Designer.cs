namespace Zoom_Visitor_s_statistic.Teacher
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CreateConf = new System.Windows.Forms.Button();
            this.ShowStat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проходит авторизация...";
            // 
            // CreateConf
            // 
            this.CreateConf.Location = new System.Drawing.Point(151, 241);
            this.CreateConf.Name = "CreateConf";
            this.CreateConf.Size = new System.Drawing.Size(114, 100);
            this.CreateConf.TabIndex = 1;
            this.CreateConf.Text = "Создать конференцию";
            this.CreateConf.UseVisualStyleBackColor = true;
            this.CreateConf.Click += new System.EventHandler(this.CreateConf_Click);
            // 
            // ShowStat
            // 
            this.ShowStat.Location = new System.Drawing.Point(461, 241);
            this.ShowStat.Name = "ShowStat";
            this.ShowStat.Size = new System.Drawing.Size(121, 100);
            this.ShowStat.TabIndex = 2;
            this.ShowStat.Text = "Просмотреть статистику посещений";
            this.ShowStat.UseVisualStyleBackColor = true;
            this.ShowStat.Click += new System.EventHandler(this.ShowStat_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowStat);
            this.Controls.Add(this.CreateConf);
            this.Controls.Add(this.label1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateConf;
        private System.Windows.Forms.Button ShowStat;
    }
}