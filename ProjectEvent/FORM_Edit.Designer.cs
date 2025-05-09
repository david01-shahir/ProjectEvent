namespace ProjectEvent
{
    partial class FORM_Edit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxsalary = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.textBoxTitleName = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(331, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 49);
            this.panel1.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Silver;
            this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(632, 437);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(156, 59);
            this.save.TabIndex = 2;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 28;
            this.listBoxEmployees.Location = new System.Drawing.Point(12, 54);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(190, 368);
            this.listBoxEmployees.TabIndex = 4;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBox_Data_SelectedIndexChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(336, 54);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(156, 27);
            this.textBoxname.TabIndex = 5;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxsalary
            // 
            this.textBoxsalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsalary.Location = new System.Drawing.Point(336, 160);
            this.textBoxsalary.Name = "textBoxsalary";
            this.textBoxsalary.Size = new System.Drawing.Size(156, 27);
            this.textBoxsalary.TabIndex = 6;
            this.textBoxsalary.TextChanged += new System.EventHandler(this.textBoxsalary_TextChanged);
            // 
            // textBoxphone
            // 
            this.textBoxphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxphone.Location = new System.Drawing.Point(336, 211);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(156, 27);
            this.textBoxphone.TabIndex = 7;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBoxphone_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(208, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 20);
            this.name.TabIndex = 8;
            this.name.Text = "name";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(208, 167);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(62, 20);
            this.Salary.TabIndex = 9;
            this.Salary.Text = "Salary";
            this.Salary.Click += new System.EventHandler(this.label3_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(209, 214);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(61, 20);
            this.Phone.TabIndex = 10;
            this.Phone.Text = "Phone";
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(206, 106);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(109, 20);
            this.EmployeeID.TabIndex = 11;
            this.EmployeeID.Text = "EmployeeID";
            this.EmployeeID.Click += new System.EventHandler(this.EmployeeID_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.Location = new System.Drawing.Point(336, 106);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(156, 27);
            this.textBoxid.TabIndex = 12;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.Location = new System.Drawing.Point(208, 354);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(94, 20);
            this.TitleName.TabIndex = 14;
            this.TitleName.Text = "TitleName";
            this.TitleName.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTitleName
            // 
            this.textBoxTitleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitleName.Location = new System.Drawing.Point(336, 347);
            this.textBoxTitleName.Name = "textBoxTitleName";
            this.textBoxTitleName.Size = new System.Drawing.Size(156, 27);
            this.textBoxTitleName.TabIndex = 13;
            this.textBoxTitleName.TextChanged += new System.EventHandler(this.textBoxTitleName_TextChanged);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(206, 403);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(107, 20);
            this.Department.TabIndex = 16;
            this.Department.Text = "Department";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(336, 396);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(156, 27);
            this.textBoxDepartment.TabIndex = 15;
            this.textBoxDepartment.TextChanged += new System.EventHandler(this.textBoxDepartment_TextChanged);
            // 
            // FORM_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.textBoxTitleName);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.textBoxsalary);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.Name = "FORM_Edit";
            this.Text = "editForm2";
            this.Load += new System.EventHandler(this.edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxsalary;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.TextBox textBoxTitleName;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox textBoxDepartment;
    }
}