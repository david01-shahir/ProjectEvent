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
    public partial class ShowDataBaseFORM: Form
    {
        public ShowDataBaseFORM()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataBaseDataSet);

        }

        private void ShowDataBaseFORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataBaseDataSet.JobTitles' table. You can move, or remove it, as needed.
            this.jobTitlesTableAdapter.Fill(this.employeesDataBaseDataSet.JobTitles);
            // TODO: This line of code loads data into the 'employeesDataBaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataBaseDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
