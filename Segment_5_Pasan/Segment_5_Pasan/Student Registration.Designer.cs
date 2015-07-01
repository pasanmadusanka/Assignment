namespace Segment_5_Pasan
{
    partial class Student_Registration
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
            this.Lbl_SId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.TxtAvg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // Lbl_SId
            // 
            this.Lbl_SId.AutoSize = true;
            this.Lbl_SId.Location = new System.Drawing.Point(112, 18);
            this.Lbl_SId.Name = "Lbl_SId";
            this.Lbl_SId.Size = new System.Drawing.Size(35, 13);
            this.Lbl_SId.TabIndex = 1;
            this.Lbl_SId.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(115, 53);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Of Birth";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(115, 90);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(200, 20);
            this.TxtDate.TabIndex = 5;
            // 
            // TxtAvg
            // 
            this.TxtAvg.Location = new System.Drawing.Point(115, 134);
            this.TxtAvg.Name = "TxtAvg";
            this.TxtAvg.Size = new System.Drawing.Size(100, 20);
            this.TxtAvg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grade Point Avg.";
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Location = new System.Drawing.Point(115, 176);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(80, 17);
            this.checkActive.TabIndex = 8;
            this.checkActive.Text = "checkBox1";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Active";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(54, 215);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 11;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(178, 215);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 12;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Student_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.TxtAvg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_SId);
            this.Controls.Add(this.label1);
            this.Name = "Student_Registration";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_SId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TxtDate;
        private System.Windows.Forms.TextBox TxtAvg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}