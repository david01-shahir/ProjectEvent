namespace ProjectEvent
{
    partial class Basic_interface_FORM
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_Filtering_of_employees = new System.Windows.Forms.Button();
            this.button_edit_employee = new System.Windows.Forms.Button();
            this.button_remove_employee = new System.Windows.Forms.Button();
            this.button_add_employee = new System.Windows.Forms.Button();
            this.label_for_chose = new System.Windows.Forms.Label();
            this.label_for_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(314, 345);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(161, 92);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_Filtering_of_employees
            // 
            this.button_Filtering_of_employees.BackColor = System.Drawing.Color.Cyan;
            this.button_Filtering_of_employees.Location = new System.Drawing.Point(128, 261);
            this.button_Filtering_of_employees.Name = "button_Filtering_of_employees";
            this.button_Filtering_of_employees.Size = new System.Drawing.Size(161, 79);
            this.button_Filtering_of_employees.TabIndex = 12;
            this.button_Filtering_of_employees.Text = "Filtering of Employees";
            this.button_Filtering_of_employees.UseVisualStyleBackColor = false;
            // 
            // button_edit_employee
            // 
            this.button_edit_employee.BackColor = System.Drawing.Color.Lime;
            this.button_edit_employee.Location = new System.Drawing.Point(314, 261);
            this.button_edit_employee.Name = "button_edit_employee";
            this.button_edit_employee.Size = new System.Drawing.Size(161, 79);
            this.button_edit_employee.TabIndex = 11;
            this.button_edit_employee.Text = "Edit Employee";
            this.button_edit_employee.UseVisualStyleBackColor = false;
            this.button_edit_employee.Click += new System.EventHandler(this.button_edit_employee_Click);
            // 
            // button_remove_employee
            // 
            this.button_remove_employee.BackColor = System.Drawing.Color.Fuchsia;
            this.button_remove_employee.Location = new System.Drawing.Point(499, 346);
            this.button_remove_employee.Name = "button_remove_employee";
            this.button_remove_employee.Size = new System.Drawing.Size(153, 92);
            this.button_remove_employee.TabIndex = 10;
            this.button_remove_employee.Text = "Remove Employee";
            this.button_remove_employee.UseVisualStyleBackColor = false;
            // 
            // button_add_employee
            // 
            this.button_add_employee.BackColor = System.Drawing.Color.Yellow;
            this.button_add_employee.Location = new System.Drawing.Point(499, 261);
            this.button_add_employee.Name = "button_add_employee";
            this.button_add_employee.Size = new System.Drawing.Size(153, 79);
            this.button_add_employee.TabIndex = 9;
            this.button_add_employee.Text = "Add Employee";
            this.button_add_employee.UseVisualStyleBackColor = false;
            this.button_add_employee.Click += new System.EventHandler(this.button_add_employee_Click);
            // 
            // label_for_chose
            // 
            this.label_for_chose.AutoSize = true;
            this.label_for_chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_for_chose.Location = new System.Drawing.Point(150, 183);
            this.label_for_chose.Name = "label_for_chose";
            this.label_for_chose.Size = new System.Drawing.Size(466, 25);
            this.label_for_chose.TabIndex = 8;
            this.label_for_chose.Text = "Click on the button you want to perform the operation";
            // 
            // label_for_title
            // 
            this.label_for_title.AutoSize = true;
            this.label_for_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_for_title.Location = new System.Drawing.Point(150, 31);
            this.label_for_title.Name = "label_for_title";
            this.label_for_title.Size = new System.Drawing.Size(476, 29);
            this.label_for_title.TabIndex = 7;
            this.label_for_title.Text = "This is the employee database software";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(128, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 91);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show DataBase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Basic_interface_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Filtering_of_employees);
            this.Controls.Add(this.button_edit_employee);
            this.Controls.Add(this.button_remove_employee);
            this.Controls.Add(this.button_add_employee);
            this.Controls.Add(this.label_for_chose);
            this.Controls.Add(this.label_for_title);
            this.Name = "Basic_interface_FORM";
            this.Text = "Basic_interface_FORM";
            this.Load += new System.EventHandler(this.Basic_interface_FORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_Filtering_of_employees;
        private System.Windows.Forms.Button button_edit_employee;
        private System.Windows.Forms.Button button_remove_employee;
        private System.Windows.Forms.Button button_add_employee;
        private System.Windows.Forms.Label label_for_chose;
        private System.Windows.Forms.Label label_for_title;
        private System.Windows.Forms.Button button1;
    }
}

