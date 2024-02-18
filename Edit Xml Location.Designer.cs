namespace Student_Info_App
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.current_path_field = new System.Windows.Forms.TextBox();
            this.new_path_field = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Path";
            // 
            // current_path_field
            // 
            this.current_path_field.Location = new System.Drawing.Point(187, 89);
            this.current_path_field.Name = "current_path_field";
            this.current_path_field.Size = new System.Drawing.Size(520, 22);
            this.current_path_field.TabIndex = 2;
            this.current_path_field.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // new_path_field
            // 
            this.new_path_field.Location = new System.Drawing.Point(187, 146);
            this.new_path_field.Name = "new_path_field";
            this.new_path_field.Size = new System.Drawing.Size(520, 22);
            this.new_path_field.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(414, 213);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 31);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Location = new System.Drawing.Point(296, 213);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 31);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.new_path_field);
            this.Controls.Add(this.current_path_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Edit Xml Location";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox current_path_field;
        private System.Windows.Forms.TextBox new_path_field;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancel;
    }
}