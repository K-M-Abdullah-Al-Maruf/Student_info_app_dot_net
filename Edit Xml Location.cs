using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info_App
{
    public partial class Form2 : Form
    {
        String current_path = Form1.get_path();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            current_path_field.Text = current_path;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            current_path_field.ReadOnly = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var new_path = new_path_field.Text;

            if (new_path != "")
            {
                new_path = ((new_path.Trim('"')).Trim('\'')).Trim(' ');

                if (Form1.set_path(new_path))
                {
                    //Form1.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("New path can not be empty");
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
