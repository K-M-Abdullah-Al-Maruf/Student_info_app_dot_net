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
            this.search_button = new System.Windows.Forms.Button();
            this.student_search_text_field = new System.Windows.Forms.TextBox();
            this.student_id_text_field = new System.Windows.Forms.TextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.st_id_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_all_data = new System.Windows.Forms.TabPage();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.changeXmlPath = new System.Windows.Forms.TabPage();
            this.Save = new System.Windows.Forms.Button();
            this.new_path_field = new System.Windows.Forms.TextBox();
            this.current_path_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 454);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // enter_info
            // 
            this.enter_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enter_info.Controls.Add(this.contact_field);
            this.enter_info.Controls.Add(this.search_button);
            this.enter_info.Controls.Add(this.student_search_text_field);
            this.enter_info.Controls.Add(this.student_id_text_field);
            this.enter_info.Controls.Add(this.contact_label);
            this.enter_info.Controls.Add(this.submit_button);
            this.enter_info.Controls.Add(this.st_id_label);
            this.enter_info.Controls.Add(this.label2);
            this.enter_info.Location = new System.Drawing.Point(4, 25);
            this.enter_info.Name = "enter_info";
            this.enter_info.Padding = new System.Windows.Forms.Padding(3);
            this.enter_info.Size = new System.Drawing.Size(792, 425);
            this.enter_info.TabIndex = 0;
            this.enter_info.Text = "Enter Info";
            // 
            // contact_field
            // 
            this.contact_field.Location = new System.Drawing.Point(332, 127);
            this.contact_field.Name = "contact_field";
            this.contact_field.Size = new System.Drawing.Size(136, 22);
            this.contact_field.TabIndex = 13;
            // 
            // search_button
            // 
            this.search_button.AutoSize = true;
            this.search_button.Location = new System.Drawing.Point(350, 310);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(91, 31);
            this.search_button.TabIndex = 18;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // student_search_text_field
            // 
            this.student_search_text_field.Location = new System.Drawing.Point(332, 265);
            this.student_search_text_field.Name = "student_search_text_field";
            this.student_search_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_search_text_field.TabIndex = 17;
            this.student_search_text_field.Text = "Student ID";
            this.student_search_text_field.TextChanged += new System.EventHandler(this.student_search_text_field_TextChanged);
            this.student_search_text_field.Enter += new System.EventHandler(this.student_search_text_field_Enter);
            this.student_search_text_field.Leave += new System.EventHandler(this.student_search_text_field_Leave);
            // 
            // student_id_text_field
            // 
            this.student_id_text_field.BackColor = System.Drawing.SystemColors.Window;
            this.student_id_text_field.Location = new System.Drawing.Point(332, 83);
            this.student_id_text_field.Name = "student_id_text_field";
            this.student_id_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_id_text_field.TabIndex = 11;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(266, 130);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(52, 16);
            this.contact_label.TabIndex = 14;
            this.contact_label.Text = "Contact";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit_button
            // 
            this.submit_button.AutoSize = true;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_button.Location = new System.Drawing.Point(350, 175);
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
            this.st_id_label.Location = new System.Drawing.Point(250, 86);
            this.st_id_label.Name = "st_id_label";
            this.st_id_label.Size = new System.Drawing.Size(68, 16);
            this.st_id_label.TabIndex = 12;
            this.st_id_label.Text = "Student ID";
            this.st_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view_all_data
            // 
            this.view_all_data.BackColor = System.Drawing.Color.WhiteSmoke;
            this.view_all_data.Controls.Add(this.data_table);
            this.view_all_data.Location = new System.Drawing.Point(4, 25);
            this.view_all_data.Name = "view_all_data";
            this.view_all_data.Padding = new System.Windows.Forms.Padding(3);
            this.view_all_data.Size = new System.Drawing.Size(792, 425);
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
            this.data_table.Location = new System.Drawing.Point(228, 0);
            this.data_table.MultiSelect = false;
            this.data_table.Name = "data_table";
            this.data_table.ReadOnly = true;
            this.data_table.RowHeadersVisible = false;
            this.data_table.RowHeadersWidth = 51;
            this.data_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_table.RowTemplate.Height = 24;
            this.data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_table.Size = new System.Drawing.Size(336, 426);
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
            this.changeXmlPath.Size = new System.Drawing.Size(792, 425);
            this.changeXmlPath.TabIndex = 2;
            this.changeXmlPath.Text = "Change Xml Path";
            this.changeXmlPath.Click += new System.EventHandler(this.changeXmlPath_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(354, 263);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 31);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // new_path_field
            // 
            this.new_path_field.Location = new System.Drawing.Point(184, 192);
            this.new_path_field.Name = "new_path_field";
            this.new_path_field.Size = new System.Drawing.Size(520, 22);
            this.new_path_field.TabIndex = 16;
            // 
            // current_path_field
            // 
            this.current_path_field.Location = new System.Drawing.Point(184, 135);
            this.current_path_field.Name = "current_path_field";
            this.current_path_field.Size = new System.Drawing.Size(520, 22);
            this.current_path_field.TabIndex = 15;
            this.current_path_field.TextChanged += new System.EventHandler(this.current_path_field_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox student_search_text_field;
        private System.Windows.Forms.TextBox student_id_text_field;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label st_id_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage changeXmlPath;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox new_path_field;
        private System.Windows.Forms.TextBox current_path_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.TabPage view_all_data;
    }
}

