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
            this.ShowStat = new System.Windows.Forms.Button();
            this.showGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(144, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проходит авторизация...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowStat
            // 
            this.ShowStat.Location = new System.Drawing.Point(360, 221);
            this.ShowStat.Name = "ShowStat";
            this.ShowStat.Size = new System.Drawing.Size(274, 96);
            this.ShowStat.TabIndex = 2;
            this.ShowStat.Text = "Просмотреть статистику посещений";
            this.ShowStat.UseVisualStyleBackColor = true;
            this.ShowStat.Click += new System.EventHandler(this.ShowStat_Click);
            // 
            // showGroup
            // 
            this.showGroup.Location = new System.Drawing.Point(28, 221);
            this.showGroup.Name = "showGroup";
            this.showGroup.Size = new System.Drawing.Size(274, 96);
            this.showGroup.TabIndex = 3;
            this.showGroup.Text = "Работа с группами студентов";
            this.showGroup.UseVisualStyleBackColor = true;
            this.showGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 353);
            this.Controls.Add(this.showGroup);
            this.Controls.Add(this.ShowStat);
            this.Controls.Add(this.label1);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowStat;
        private System.Windows.Forms.Button showGroup;
    }
}