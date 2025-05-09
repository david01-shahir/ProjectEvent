using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEvent
{
    public partial class Add_Employee_FORM: Form
    {
        public Add_Employee_FORM()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpolyeeID, Phone, Salary, TitleID;
                string Name, TitleName, Department;

                EmpolyeeID = Convert.ToInt32(textBox_Empolyee_ID.Text);
                Name = textBox_Name.Text;
                Phone = Convert.ToInt32(textBox_Phone.Text);
                Salary = Convert.ToInt32(textBox_Salary.Text);
                TitleID = Convert.ToInt32(textBox_Title_ID.Text);
                TitleName = textBox_Job_Title_Name.Text;
                Department = textBox_Department.Text;


            }
            catch
            {
                MessageBox.Show("You must enter appropriate input types.");
            }
        }
    }
}
