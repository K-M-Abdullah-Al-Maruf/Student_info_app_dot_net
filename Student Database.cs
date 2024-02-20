using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

namespace Student_Info_App
{
    public partial class Form1 : Form
    {
        static String xml_path = "C:\\Users\\Maruf\\source\\repos\\Student_Info_App\\Student_Info_App\\Student Data.xml";
        //static String xml_path = "C:\\Users\\Maruf\\source\\repos\\Student_Info_App\\Student Data.xml";
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            xml_file_check();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_path_field.Text = xml_path;
        }

        public static String get_path()
        {
            return xml_path;
        }

        public static bool set_path(String path)
        {   
            xml_path = path; 

            return true;
        }

        private void xml_file_check()
        {  
            try
            {
                XDocument xml = XDocument.Load(xml_path);
            }
            catch 
            {
                MessageBox.Show("Xml file not found in\n" + xml_path, "Error");
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            //path of this file. Kept it for the dynamic location of the xml file
            //Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)

            String id = student_id_text_field.Text;
            String contact = contact_field.Text;
            String message = "";

            student_id_text_field.Clear();
            contact_field.Clear();

            if (id == "")
            {
                message = "Enter Student ID";
            }
            
            if (contact == "")
            {
                if (message != "")
                {
                    message += "\nEnter Contact Number";
                } 
                else
                {
                    message += "Enter Contact Number";
                }
            }
            else if ((contact.GetType() != typeof(int)) && contact.Length != 11) 
            {
                if (message != "")
                {
                    message += "\nInvalid Contact Number";
                }
                else
                {
                    message += "Invalid Contact Number";
                }
            }
            if (message == "")
            {
                
                try
                {
                    XDocument xml = XDocument.Load(xml_path);
                    XElement student_search = xml.Element("student_data").Elements("student").Where(student => student.Attribute("id").Value == id).FirstOrDefault();
                    
                    if (student_search == null )
                    {
                        XElement student_data = xml.Element("student_data");

                        try
                        {
                            student_data.Add(new XElement("student",
                            new XAttribute("id", id),
                            new XElement("contact", contact)));

                            xml.Save(xml_path);
                            MessageBox.Show("Contact successfully added for student id "+id, "Data");
                        }
                        catch 
                        {
                            MessageBox.Show("Data append failed.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID = "+id+" already have added contact.", "Error");
                    }
                }
                catch
                {
                    MessageBox.Show("Xml file not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show(message,"Error");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            String id = student_search_text_field.Text;
            Console.WriteLine(id);
            student_search_text_field.Clear();

            if ((id == "Student ID") || (id == ""))
            {
                MessageBox.Show("Enter Student ID", "Error");

            }
            else
            {
                try
                {
                    XDocument xml = XDocument.Load(xml_path);
                    XElement student_search = xml.Element("student_data").Elements("student").Where(student => student.Attribute("id").Value == id).FirstOrDefault();

                    if (student_search != null)
                    {
                        var contact = student_search.Element("contact").Value;
                        MessageBox.Show("Student ID: "+id+"\nContatc: "+contact, "Student found!");
                    }
                    else
                    {
                        MessageBox.Show("Student with ID "+id+" not found.", "Student not found!");
                    }
                }
                catch
                {
                    MessageBox.Show("Data fetch failed", "Error");
                }
            }

            student_search_text_field.Text = "Student ID";
        }

        private void student_search_text_field_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void student_search_text_field_Enter(object sender, EventArgs e)
        {
            if (student_search_text_field.Text == "Student ID")
            {
                student_search_text_field.Clear();
            }
            
        }

        private void student_search_text_field_Leave(object sender, EventArgs e)
        {
            if (student_search_text_field.Text == "")
            {
                student_search_text_field.Text = "Student ID";

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["view_all_data"])
            {
                DataTable dt = new DataTable("Student Info");

                try
                {
                    XDocument xml = XDocument.Load(xml_path);
                    XElement student_data = xml.Element("student_data");

                    if (student_data != null)
                    {
                        dt.Columns.Add("ID");
                        dt.Columns.Add("Contact");

                        var query = from data in xml.Root.Descendants("student")
                                    where (int)data.Attribute("id") > -1
                                    select data.Attribute("id").Value + " " +
                                    data.Element("contact").Value;

                        foreach (string data in query)
                        {
                            var array = data.Split(' ');
                            dt.Rows.Add(array[0], array[1]);
                        }
                    }
                    else
                    {
                        dt.Columns.Add("No Data Found");
                    }
                }
                catch
                {
                    MessageBox.Show("Data fetch failed", "Error");
                }

                data_table.DataSource = dt;
            }
        }

        private void changeXmlPath_Click(object sender, EventArgs e)
        {

        }

        private void current_path_field_TextChanged(object sender, EventArgs e)
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
                    MessageBox.Show("Added new path.");
                    xml_path = new_path;
                    current_path_field.Text = xml_path;
                    new_path_field.Clear();
                }
            }
            else
            {
                MessageBox.Show("New path can not be empty.");
            }

        }
    }

}
