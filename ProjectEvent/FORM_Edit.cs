using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjectEvent
{
    public partial class FORM_Edit: Form
    {
        public FORM_Edit()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\acu\ProjectEvent\ProjectEvent\ProjectEvent\EmployeesDataBase.mdf;Integrated Security=True;Connect Timeout=30";

        private void LoadData()
        {
            // تعديل الاستعلام لجلب البيانات من جدولين باستخدام JOIN
            string query = @"
            SELECT 
            Employees.EmployeeID, 
            Employees.Name, 
            Employees.Salary, 
            Employees.Phone, 
            JobTitles.TitleName, 
            JobTitles.Department,
            Employees.TitleID  
            FROM Employees
            INNER JOIN JobTitles ON Employees.TitleID = JobTitles.TitleID";  // هنا نقوم بربط الجدولين على أساس TitleID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                listBoxEmployees.DisplayMember = "Name";  // اللي هيظهر في الـ ListBox (أسماء الموظفين)
                listBoxEmployees.ValueMember = "EmployeeID";  // القيمة المستخدمة داخليًا (ID)
                listBoxEmployees.DataSource = table;
            }
        }




        private void edit_Load(object sender, EventArgs e)
        {
            LoadData();  // تحميل البيانات عند فتح الفورم
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employeeId;
            decimal newSalary;
            long newPhone;

            string newName = textBoxname.Text.Trim();
            string newDepartment = textBoxDepartment.Text.Trim();
            string newTitleName = textBoxTitleName.Text.Trim();

            // التحقق من EmployeeID
            if (!int.TryParse(textBoxid.Text, out employeeId))
            {
                MessageBox.Show("الرجاء إدخال معرف الموظف بشكل صحيح (رقم).");
            }
            else if (string.IsNullOrWhiteSpace(newName) || newName.Any(char.IsDigit))
            {
                MessageBox.Show("الرجاء إدخال اسم صحيح (بدون أرقام).");
            }
            else if (string.IsNullOrWhiteSpace(newTitleName) || newTitleName.Any(char.IsDigit))
            {
                MessageBox.Show("الرجاء إدخال مسمى وظيفي صحيح (بدون أرقام).");
            }
            else if (string.IsNullOrWhiteSpace(newDepartment) || newDepartment.Any(char.IsDigit))
            {
                MessageBox.Show("الرجاء إدخال اسم القسم بشكل صحيح (بدون أرقام).");
            }
            else if (!decimal.TryParse(textBoxsalary.Text, out newSalary))
            {
                MessageBox.Show("الرجاء إدخال المرتب بشكل صحيح (رقم).");
            }
            else if (!long.TryParse(textBoxphone.Text, out newPhone))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف بشكل صحيح.");
            }
            else
            {
                // إذا كل حاجة سليمة نبدأ نحدث البيانات
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // تحديث جدول Employees
                    string updateEmployeeQuery = @"
                UPDATE Employees
                SET Name = @Name, 
                    Salary = @Salary, 
                    Phone = @Phone
                WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand cmdEmp = new SqlCommand(updateEmployeeQuery, connection))
                    {
                        cmdEmp.Parameters.AddWithValue("@Name", newName);
                        cmdEmp.Parameters.AddWithValue("@Salary", newSalary);
                        cmdEmp.Parameters.AddWithValue("@Phone", newPhone);
                        cmdEmp.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmdEmp.ExecuteNonQuery();
                    }

                    // الحصول على TitleID المرتبط بالموظف
                    string getTitleIdQuery = "SELECT TitleID FROM Employees WHERE EmployeeID = @EmployeeID";
                    int titleId = 0;

                    using (SqlCommand cmdGetTitle = new SqlCommand(getTitleIdQuery, connection))
                    {
                        cmdGetTitle.Parameters.AddWithValue("@EmployeeID", employeeId);
                        object result = cmdGetTitle.ExecuteScalar();
                        if (result != null)
                        {
                            titleId = Convert.ToInt32(result);
                        }
                    }

                    // تحديث جدول JobTitles
                    string updateTitleQuery = @"
                UPDATE JobTitles
                SET TitleName = @TitleName,
                    Department = @Department
                WHERE TitleID = @TitleID";

                    using (SqlCommand cmdTitle = new SqlCommand(updateTitleQuery, connection))
                    {
                        cmdTitle.Parameters.AddWithValue("@TitleName", newTitleName);
                        cmdTitle.Parameters.AddWithValue("@Department", newDepartment);
                        cmdTitle.Parameters.AddWithValue("@TitleID", titleId);
                        cmdTitle.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                LoadData();
                MessageBox.Show("تم حفظ التعديلات بنجاح!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                // الحصول على العنصر المحدد من الـ ListBox
                DataRowView selectedRow = (DataRowView)listBoxEmployees.SelectedItem;

                // تعبئة الحقول بالنصوص المناسبة من الـ DataRow
                textBoxname.Text = selectedRow["name"].ToString();
                textBoxid.Text = selectedRow["EmployeeID"].ToString();
                textBoxTitleName.Text = selectedRow["TitleName"].ToString();
                textBoxsalary.Text = selectedRow["Salary"].ToString();
                textBoxDepartment.Text = selectedRow["Department"].ToString();
                textBoxphone.Text = selectedRow["Phone"].ToString();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTitleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepartment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
