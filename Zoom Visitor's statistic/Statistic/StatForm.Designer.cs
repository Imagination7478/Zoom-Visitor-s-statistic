namespace Zoom_Visitor_s_statistic.Statistic
{
    partial class StatForm
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
            this.MeetingsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitorsTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MeetingsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MeetingsTable
            // 
            this.MeetingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeetingsTable.Location = new System.Drawing.Point(12, 48);
            this.MeetingsTable.Name = "MeetingsTable";
            this.MeetingsTable.RowHeadersWidth = 51;
            this.MeetingsTable.RowTemplate.Height = 24;
            this.MeetingsTable.Size = new System.Drawing.Size(372, 143);
            this.MeetingsTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список ваших конференций:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VisitorsTable
            // 
            this.VisitorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsTable.Location = new System.Drawing.Point(12, 236);
            this.VisitorsTable.Name = "VisitorsTable";
            this.VisitorsTable.RowHeadersWidth = 51;
            this.VisitorsTable.RowTemplate.Height = 24;
            this.VisitorsTable.Size = new System.Drawing.Size(776, 318);
            this.VisitorsTable.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите id конференции для доп. информации";
            // 
            // meetingid
            // 
            this.meetingid.Location = new System.Drawing.Point(426, 80);
            this.meetingid.Name = "meetingid";
            this.meetingid.Size = new System.Drawing.Size(317, 22);
            this.meetingid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Получить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(423, 174);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 6;
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meetingid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VisitorsTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeetingsTable);
            this.Name = "StatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatForm";
            this.Load += new System.EventHandler(this.StatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeetingsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MeetingsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VisitorsTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meetingid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}