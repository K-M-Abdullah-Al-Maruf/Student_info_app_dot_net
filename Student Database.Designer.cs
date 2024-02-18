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
            this.student_id_text_field = new System.Windows.Forms.TextBox();
            this.st_id_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.contact_field = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.student_search_text_field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_id_text_field
            // 
            this.student_id_text_field.BackColor = System.Drawing.SystemColors.Window;
            this.student_id_text_field.Location = new System.Drawing.Point(346, 86);
            this.student_id_text_field.Name = "student_id_text_field";
            this.student_id_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_id_text_field.TabIndex = 0;
            this.student_id_text_field.TextChanged += new System.EventHandler(this.student_id_text_field_TextChanged);
            // 
            // st_id_label
            // 
            this.st_id_label.AutoSize = true;
            this.st_id_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st_id_label.Location = new System.Drawing.Point(264, 89);
            this.st_id_label.Name = "st_id_label";
            this.st_id_label.Size = new System.Drawing.Size(68, 16);
            this.st_id_label.TabIndex = 1;
            this.st_id_label.Text = "Student ID";
            this.st_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.st_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(280, 133);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(52, 16);
            this.contact_label.TabIndex = 3;
            this.contact_label.Text = "Contact";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contact_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // contact_field
            // 
            this.contact_field.Location = new System.Drawing.Point(346, 130);
            this.contact_field.Name = "contact_field";
            this.contact_field.Size = new System.Drawing.Size(136, 22);
            this.contact_field.TabIndex = 2;
            this.contact_field.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // submit_button
            // 
            this.submit_button.AutoSize = true;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_button.Location = new System.Drawing.Point(364, 178);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(91, 31);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // student_search_text_field
            // 
            this.student_search_text_field.Location = new System.Drawing.Point(346, 268);
            this.student_search_text_field.Name = "student_search_text_field";
            this.student_search_text_field.Size = new System.Drawing.Size(136, 22);
            this.student_search_text_field.TabIndex = 8;
            this.student_search_text_field.Text = "Student ID";
            this.student_search_text_field.TextChanged += new System.EventHandler(this.student_search_text_field_TextChanged);
            this.student_search_text_field.Enter += new System.EventHandler(this.student_search_text_field_Enter);
            this.student_search_text_field.Leave += new System.EventHandler(this.student_search_text_field_Leave);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(364, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Change Xml Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.student_search_text_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.contact_field);
            this.Controls.Add(this.st_id_label);
            this.Controls.Add(this.student_id_text_field);
            this.Name = "Form1";
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox student_id_text_field;
        private System.Windows.Forms.Label st_id_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.TextBox contact_field;
        private System.Windows.Forms.Button submit_button;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox student_search_text_field;
        private System.Windows.Forms.Button button2;
    }
}

