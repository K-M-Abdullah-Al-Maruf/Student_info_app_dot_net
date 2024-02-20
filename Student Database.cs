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
                string temp = xml_path;

                xml_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Student Data.xml";
                
                try
                {
                    Console.WriteLine(xml_path);
                    XDocument xml = XDocument.Load(xml_path);
                }
                catch
                {
                    MessageBox.Show("Xml file was not found in\n" + temp + "\nor,\n" + xml_path, "Error");
                }
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            String id = student_id_text_field.Text.Trim();
            String name = student_name_text_field.Text.Trim();
            String contact = contact_field.Text.Trim();
            String institution = institution_name_text_field.Text.Trim();
            String department = dep_name_text_field.Text.Trim();
            String semester = semester_text_field.Text.Trim();
            String major = major_text_field.Text.Trim();

            String message = "";

            student_id_text_field.Clear();
            student_name_text_field.Clear();
            contact_field.Clear();
            institution_name_text_field.Clear();
            dep_name_text_field.Clear();
            semester_text_field.Clear();
            major_text_field.Clear();

            if (id == "")
            {
                message += "Enter Student ID\n";
            }

            if (name == "")
            {
                message += "Enter Name\n";
            }

            if (contact == "")
            {
                if (message != "")
                {
                    message += "Enter Contact Number\n";
                } 
                else
                {
                    message += "Enter Contact Number\n";
                }
            }
            else if ((contact.GetType() != typeof(int)) && contact.Length != 11) 
            {
                if (message != "")
                {
                    message += "Invalid Contact Number\n";
                }
                else
                {
                    message += "Invalid Contact Number\n";
                }
            }

            if (institution == "")
            {
                message += "Enter Institution Name\n";
            }

            if (department == "")
            {
                message += "Enter Department Name\n";
            }

            if (semester == "")
            {
                message += "Enter Semester\n";
            }

            if (major == "")
            {
                message += "Enter Major\n";
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
                            new XElement("name", name),
                            new XElement("contact", contact),
                            new XElement("institution", institution),
                            new XElement("department", department),
                            new XElement("semester", semester),
                            new XElement("major", major)));

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
                        var info_data = "Name: "+student_search.Element("name").Value;
                        info_data += "\nContact: "+student_search.Element("contact").Value;
                        info_data += "\nInstitution: " + student_search.Element("institution").Value;
                        info_data += "\nDep: " + student_search.Element("department").Value;
                        info_data += "\nSemester: " + student_search.Element("semester").Value;
                        info_data += "\nMajor: " + student_search.Element("major").Value;

                        MessageBox.Show("Student ID: "+id+"\n"+info_data, "Student found!");
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
                        dt.Columns.Add("Name");
                        dt.Columns.Add("contact");
                        dt.Columns.Add("Institution"); 
                        dt.Columns.Add("Department");
                        dt.Columns.Add("Semester");
                        dt.Columns.Add("Major");

                        var query = from data in xml.Root.Descendants("student")
                                    where data.Attribute("id") != null
                                    select data.Attribute("id").Value + " " +
                                    data.Element("name").Value + " " +
                                    data.Element("contact").Value + " " +
                                    data.Element("institution").Value + " " +
                                    data.Element("department").Value + " " +
                                    data.Element("semester").Value + " " +
                                    data.Element("major").Value;

                        foreach (string data in query)
                        {
                            var array = data.Split(' ');
                            dt.Rows.Add(array[0], array[1], array[2], array[3], array[4], array[5], array[6]);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void enter_info_Click(object sender, EventArgs e)
        {

        }

        private void st_id_label_Click(object sender, EventArgs e)
        {

        }
    }

}
