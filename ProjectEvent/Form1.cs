using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace ProjectEvent
{
    public partial class Basic_interface_FORM: Form
    {
        public Basic_interface_FORM()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_edit_employee_Click(object sender, EventArgs e)
        {
            FORM_Edit editForm = new FORM_Edit();
            editForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDataBaseFORM employeesForm = new ShowDataBaseFORM();
            employeesForm.ShowDialog();
        }

        private void button_add_employee_Click(object sender, EventArgs e)
        {
            Add_Employee_FORM addEmployee = new Add_Employee_FORM();
            addEmployee.ShowDialog();
        }

        private void Basic_interface_FORM_Load(object sender, EventArgs e)
        {

        }
    }
}
