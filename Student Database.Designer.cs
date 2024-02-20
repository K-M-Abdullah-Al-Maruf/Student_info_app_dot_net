namespace Student_Info_App
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.enter_info = new System.Windows.Forms.TabPage();
            this.contact_field = new System.Windows.Forms.TextBox();
            this.student_id_text_field = new System.Windows.Forms.TextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.st_id_label = new System.Windows.Forms.Label();
            this.view_all_data = new System.Windows.Forms.TabPage();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.changeXmlPath = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.current_path_field = new System.Windows.Forms.TextBox();
            this.new_path_field = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.student_search_text_field = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.student_name_text_field = new System.Windows.Forms.TextBox();
            this.dep_name_text_field = new System.Windows.Forms.TextBox();
            this.semester_text_field = new System.Windows.Forms.TextBox();
            this.major_text_field = new System.Windows.Forms.TextBox();
            this.institution_name_text_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.enter_info.SuspendLayout();
            this.view_all_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.changeXmlPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.enter_info);
            this.tabControl1.Controls.Add(this.view_all_data);
            this.tabControl1.Controls.Add(this.changeXmlPath);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 454);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // enter_info
            // 
            this.enter_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enter_info.Controls.Add(this.label9);
            this.enter_info.Controls.Add(this.label8);
            this.enter_info.Controls.Add(this.label7);
            this.enter_info.Controls.Add(this.label6);
            this.enter_info.Controls.Add(this.label5);
            this.enter_info.Controls.Add(this.institution_name_text_field);
            this.enter_info.Controls.Add(this.major_text_field);
            this.enter_info.Controls.Add(this.semester_text_field);
            this.enter_info.Controls.Add(this.dep_name_text_field);
            this.enter_info.Controls.Add(this.student_name_text_field);
            this.enter_info.Controls.Add(this.contact_field);
            this.enter_info.Controls.Add(this.student_search_text_field);
            this.enter_info.Controls.Add(this.student_id_text_field);
            this.enter_info.Controls.Add(this.contact_label);
            this.enter_info.Controls.Add(this.submit_button);
            this.enter_info.Controls.Add(this.st_id_label);
            this.enter_info.Controls.Add(this.search_button);
            this.enter_info.Controls.Add(this.label2);
            this.enter_info.Location = new System.Drawing.Point(4, 25);
            this.enter_info.Name = "enter_info";
            this.enter_info.Padding = new System.Windows.Forms.Padding(3);
            this.enter_info.Size = new System.Drawing.Size(929, 425);
            this.enter_info.TabIndex = 0;
            this.enter_info.Text = "Enter Info";
            this.enter_info.Click += new System.EventHandler(this.enter_info_Click);
            // 
            // contact_field
            // 
            this.contact_field.Location = new System.Drawing.Point(402, 158);
            this.contact_field.Name = "contact_field";
            this.contact_field.Size = new System.Drawing.Size(136, 22);
            this.contact_field.TabIndex = 13;
            // 
            // student_id_text_field
            // 
            this.student_id_text_field.BackColor = System.Drawing.SystemColors.Window;
            this.student_id_text_field.Location = new System.Drawing.Point(402, 83);
            this.student_id_text_field.Name = "student_id_text_field";
            this.student_id_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_id_text_field.TabIndex = 11;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(339, 161);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(52, 16);
            this.contact_label.TabIndex = 14;
            this.contact_label.Text = "Contact";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contact_label.Click += new System.EventHandler(this.contact_label_Click);
            // 
            // submit_button
            // 
            this.submit_button.AutoSize = true;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_button.Location = new System.Drawing.Point(419, 368);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(91, 31);
            this.submit_button.TabIndex = 15;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // st_id_label
            // 
            this.st_id_label.AutoSize = true;
            this.st_id_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st_id_label.Location = new System.Drawing.Point(323, 89);
            this.st_id_label.Name = "st_id_label";
            this.st_id_label.Size = new System.Drawing.Size(68, 16);
            this.st_id_label.TabIndex = 12;
            this.st_id_label.Text = "Student ID";
            this.st_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.st_id_label.Click += new System.EventHandler(this.st_id_label_Click);
            // 
            // view_all_data
            // 
            this.view_all_data.BackColor = System.Drawing.Color.WhiteSmoke;
            this.view_all_data.Controls.Add(this.data_table);
            this.view_all_data.Location = new System.Drawing.Point(4, 25);
            this.view_all_data.Name = "view_all_data";
            this.view_all_data.Padding = new System.Windows.Forms.Padding(3);
            this.view_all_data.Size = new System.Drawing.Size(929, 425);
            this.view_all_data.TabIndex = 1;
            this.view_all_data.Text = "View All Data";
            // 
            // data_table
            // 
            this.data_table.AllowUserToAddRows = false;
            this.data_table.AllowUserToDeleteRows = false;
            this.data_table.AllowUserToResizeColumns = false;
            this.data_table.AllowUserToResizeRows = false;
            this.data_table.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.data_table.ColumnHeadersHeight = 29;
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_table.Location = new System.Drawing.Point(0, 0);
            this.data_table.MultiSelect = false;
            this.data_table.Name = "data_table";
            this.data_table.ReadOnly = true;
            this.data_table.RowHeadersVisible = false;
            this.data_table.RowHeadersWidth = 51;
            this.data_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_table.RowTemplate.Height = 24;
            this.data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_table.Size = new System.Drawing.Size(933, 426);
            this.data_table.TabIndex = 0;
            // 
            // changeXmlPath
            // 
            this.changeXmlPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.changeXmlPath.Controls.Add(this.Save);
            this.changeXmlPath.Controls.Add(this.new_path_field);
            this.changeXmlPath.Controls.Add(this.current_path_field);
            this.changeXmlPath.Controls.Add(this.label1);
            this.changeXmlPath.Controls.Add(this.label3);
            this.changeXmlPath.Location = new System.Drawing.Point(4, 25);
            this.changeXmlPath.Name = "changeXmlPath";
            this.changeXmlPath.Padding = new System.Windows.Forms.Padding(3);
            this.changeXmlPath.Size = new System.Drawing.Size(929, 425);
            this.changeXmlPath.TabIndex = 2;
            this.changeXmlPath.Text = "Change Xml Path";
            this.changeXmlPath.Click += new System.EventHandler(this.changeXmlPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Path";
            // 
            // current_path_field
            // 
            this.current_path_field.Location = new System.Drawing.Point(216, 135);
            this.current_path_field.Name = "current_path_field";
            this.current_path_field.Size = new System.Drawing.Size(600, 22);
            this.current_path_field.TabIndex = 15;
            this.current_path_field.TextChanged += new System.EventHandler(this.current_path_field_TextChanged);
            // 
            // new_path_field
            // 
            this.new_path_field.Location = new System.Drawing.Point(216, 192);
            this.new_path_field.Name = "new_path_field";
            this.new_path_field.Size = new System.Drawing.Size(600, 22);
            this.new_path_field.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(405, 263);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 31);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // student_search_text_field
            // 
            this.student_search_text_field.Location = new System.Drawing.Point(345, 18);
            this.student_search_text_field.Name = "student_search_text_field";
            this.student_search_text_field.Size = new System.Drawing.Size(162, 22);
            this.student_search_text_field.TabIndex = 17;
            this.student_search_text_field.Text = "Student ID";
            this.student_search_text_field.TextChanged += new System.EventHandler(this.student_search_text_field_TextChanged);
            this.student_search_text_field.Enter += new System.EventHandler(this.student_search_text_field_Enter);
            this.student_search_text_field.Leave += new System.EventHandler(this.student_search_text_field_Leave);
            // 
            // search_button
            // 
            this.search_button.AutoSize = true;
            this.search_button.Location = new System.Drawing.Point(513, 18);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(93, 26);
            this.search_button.TabIndex = 18;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // student_name_text_field
            // 
            this.student_name_text_field.Location = new System.Drawing.Point(402, 120);
            this.student_name_text_field.Name = "student_name_text_field";
            this.student_name_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_name_text_field.TabIndex = 19;
            // 
            // dep_name_text_field
            // 
            this.dep_name_text_field.Location = new System.Drawing.Point(402, 233);
            this.dep_name_text_field.Name = "dep_name_text_field";
            this.dep_name_text_field.Size = new System.Drawing.Size(136, 22);
            this.dep_name_text_field.TabIndex = 20;
            this.dep_name_text_field.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // semester_text_field
            // 
            this.semester_text_field.Location = new System.Drawing.Point(402, 272);
            this.semester_text_field.Name = "semester_text_field";
            this.semester_text_field.Size = new System.Drawing.Size(136, 22);
            this.semester_text_field.TabIndex = 21;
            // 
            // major_text_field
            // 
            this.major_text_field.Location = new System.Drawing.Point(402, 311);
            this.major_text_field.Name = "major_text_field";
            this.major_text_field.Size = new System.Drawing.Size(136, 22);
            this.major_text_field.TabIndex = 22;
            // 
            // institution_name_text_field
            // 
            this.institution_name_text_field.Location = new System.Drawing.Point(402, 197);
            this.institution_name_text_field.Name = "institution_name_text_field";
            this.institution_name_text_field.Size = new System.Drawing.Size(136, 22);
            this.institution_name_text_field.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Institution";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Department";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Semester";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Major";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.enter_info.ResumeLayout(false);
            this.enter_info.PerformLayout();
            this.view_all_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.changeXmlPath.ResumeLayout(false);
            this.changeXmlPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage enter_info;
        private System.Windows.Forms.TextBox contact_field;
        private System.Windows.Forms.TextBox student_id_text_field;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label st_id_label;
        private System.Windows.Forms.TabPage changeXmlPath;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.TabPage view_all_data;
        private System.Windows.Forms.TextBox student_search_text_field;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox new_path_field;
        private System.Windows.Forms.TextBox current_path_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox major_text_field;
        private System.Windows.Forms.TextBox semester_text_field;
        private System.Windows.Forms.TextBox dep_name_text_field;
        private System.Windows.Forms.TextBox student_name_text_field;
        private System.Windows.Forms.TextBox institution_name_text_field;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

