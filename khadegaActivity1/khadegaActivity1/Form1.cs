using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for email
using System.Text.RegularExpressions;

using System.IO;

namespace khadegaActivity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = listcity.GetItemText(listcity.SelectedItem);
            MessageBox.Show(txt);

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string DOB = dateOfBirthday.Text;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Other";
            //dont work in 2013 version
            //string country = cmbCountry.SelectedItem?.ToString()??"Not Selected";
            //string color = lblSelectedColor.TextReplace("Selected Color: ". "");
            //lblResult.Text = $"Name: {name}\nGender: {gender}\n Birthdate: {DOB}";
            lblResult.Text = string.Format("Name: {0}\nGender: {1}\nBirthdate: {2}", name, gender, DOB);
            MessageBox.Show(name + " " + DOB);
            // validate name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("name is required !", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            // validate email
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("enter a valid Email address!", "validation message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            // validate password
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 character!", "validate error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            // validate gender
            if (!rdoMale.Checked && !rdoFemale.Checked && !rdoOther.Checked)
            {
                MessageBox.Show("please select gender", "validate error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // validate county
            if (cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("please select country", "validate error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCountry.Focus();
                return;
            }

            // all validate passed => proceed with display data
            string stuName = txtName.Text;
            string stuEmail = txtEmail.Text;
            string stuPassword = txtPassword.Text;
            string stuGender = rdoMale.Checked ? "male" : rdoFemale.Checked ? "female" : "other";
            string stuDOB = dateOfBirthday.Value.ToShortDateString();
            string stuCountry = cmbCountry.SelectedItem.ToString();


            // displaying result
            lblResult.Text = ("Name :" + stuName + "\nEmail :" + stuEmail + "\nGender :" + stuGender + "\n Date Of Birthday :" + stuDOB + "\nCountry :" + stuCountry);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear text fields
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            //uncheck rdo buttons
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;

            cmbCountry.SelectedIndex = -1;
            dateOfBirthday.Value = DateTime.Now;
            lblResult.Text = "";
            txtName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate fields before saving
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in at least Name and Email before saving!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Prepare data in a structured text format
            string data = txtName.Text + "\n" + txtEmail.Text + "\n" + txtPassword.Text + "\n" + (rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Other") + "\n" + dateOfBirthday.Value.ToShortDateString() + "\n" + cmbCountry.SelectedItem.ToString();
            // Save to text file
            File.WriteAllText("student_data.txt", data);
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (!File.Exists("student_data.txt"))
            {
                MessageBox.Show("No saved data found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Read all lines from the text file 
            string[] lines = File.ReadAllLines("student_data.txt"); 
            // Ensure file has the expected number of lines 
            if (lines.Length < 8) 
            {
                MessageBox.Show("Saved data is incomplete or corrupted!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            } 
            // Populate form fields 
            txtName.Text = lines[0]; 
            txtEmail.Text = lines[1]; 
            txtPassword.Text = lines[2]; 
            if (lines[3] == "Male") rdoMale.Checked = true;
            else if (lines[3] == "Female") rdoFemale.Checked = true; 
            else rdoOther.Checked = true; 
            dateOfBirthday.Value = DateTime.Parse(lines[4]); 
            cmbCountry.SelectedItem = lines[5]; 
            MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
    

