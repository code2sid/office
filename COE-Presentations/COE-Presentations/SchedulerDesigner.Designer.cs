namespace COE_Presentations
{
    partial class SchedulerDesigner
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.chkdays = new System.Windows.Forms.CheckedListBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExpire = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtTemplateFile = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(114, 9);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(101, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(221, 9);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(125, 21);
            this.ddlCategory.TabIndex = 3;
            this.ddlCategory.Text = "--Select Category--";
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCategory_SelectedIndexChanged);
            // 
            // chkdays
            // 
            this.chkdays.CheckOnClick = true;
            this.chkdays.FormattingEnabled = true;
            this.chkdays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.chkdays.Location = new System.Drawing.Point(222, 51);
            this.chkdays.Name = "chkdays";
            this.chkdays.Size = new System.Drawing.Size(210, 109);
            this.chkdays.TabIndex = 4;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(115, 51);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(101, 20);
            this.dtStart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expire";
            // 
            // dtExpire
            // 
            this.dtExpire.CustomFormat = "";
            this.dtExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpire.Location = new System.Drawing.Point(115, 140);
            this.dtExpire.Name = "dtExpire";
            this.dtExpire.Size = new System.Drawing.Size(101, 20);
            this.dtExpire.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(313, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Schedule";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "End Time";
            // 
            // timeStart
            // 
            this.timeStart.CustomFormat = "hh:mm:ss tt";
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(114, 77);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(101, 20);
            this.timeStart.TabIndex = 13;
            this.timeStart.Value = new System.DateTime(2017, 3, 27, 11, 39, 0, 0);
            // 
            // timeEnd
            // 
            this.timeEnd.CustomFormat = "hh:mm:ss tt";
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(114, 103);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(101, 20);
            this.timeEnd.TabIndex = 14;
            this.timeEnd.Value = new System.DateTime(2017, 3, 27, 11, 39, 0, 0);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(5, 172);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse Template";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtTemplateFile
            // 
            this.txtTemplateFile.Location = new System.Drawing.Point(114, 174);
            this.txtTemplateFile.Name = "txtTemplateFile";
            this.txtTemplateFile.Size = new System.Drawing.Size(318, 20);
            this.txtTemplateFile.TabIndex = 16;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // SchedulerDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 388);
            this.Controls.Add(this.txtTemplateFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtExpire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.chkdays);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "SchedulerDesigner";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.SchedulerDesigner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.CheckedListBox chkdays;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtExpire;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTemplateFile;
        private System.Windows.Forms.OpenFileDialog openFile;

    }
}

