using studentregistration.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentregistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidNumber(txtAge.Text))
            {
                if (isValidNumber(txtNum.Text))
                {
                    Student student = new Student();
                    student.name = txtName.Text;
                    student.age = Convert.ToInt32(txtAge.Text);
                    student.address = txtAddress.Text;
                    student.mobileno = Convert.ToInt64(txtNum.Text);
                    student.email = txtEmail.Text;
                    addstudent(student);

                }
              else
                {
                  MessageBox.Show("The Mobile Number you entered is incorrect");
                }

            }
              else
              {
                MessageBox.Show("The age you entered is incorrect");
              }


        }
        public void addstudent(Student student)
        {
            MessageBox.Show("Your form is registered");
        }
        private bool isValidNumber(string value)
        {
            int num;
            bool bResult = int.TryParse(value, out num);
            return bResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
