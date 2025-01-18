
namespace BenTech.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.ctbEmployeePassw = new BenTech.UserControls.customTextBox();
            this.labelIsAdmin = new System.Windows.Forms.Label();
            this.ctbEmployeeName = new BenTech.UserControls.customTextBox();
            this.cbEmployeeTF = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.panelAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(150, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 600);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(12, 33);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(120, 33);
            this.buttonEmployees.TabIndex = 2;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            this.buttonEmployees.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.buttonEmployees.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(12, 109);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(120, 33);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            this.btnDeleteEmployee.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDeleteEmployee.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(12, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 33);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddEmployee.Controls.Add(this.ctbEmployeePassw);
            this.panelAddEmployee.Controls.Add(this.labelIsAdmin);
            this.panelAddEmployee.Controls.Add(this.ctbEmployeeName);
            this.panelAddEmployee.Controls.Add(this.cbEmployeeTF);
            this.panelAddEmployee.Controls.Add(this.btnSaveEmployee);
            this.panelAddEmployee.Location = new System.Drawing.Point(736, 59);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(398, 257);
            this.panelAddEmployee.TabIndex = 8;
            this.panelAddEmployee.Visible = false;
            // 
            // ctbEmployeePassw
            // 
            this.ctbEmployeePassw.BackColor = System.Drawing.Color.White;
            this.ctbEmployeePassw.changeTextBoxSize = false;
            this.ctbEmployeePassw.customText = "Password";
            this.ctbEmployeePassw.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbEmployeePassw.Location = new System.Drawing.Point(37, 88);
            this.ctbEmployeePassw.Name = "ctbEmployeePassw";
            this.ctbEmployeePassw.password = false;
            this.ctbEmployeePassw.Size = new System.Drawing.Size(289, 49);
            this.ctbEmployeePassw.TabIndex = 10;
            // 
            // labelIsAdmin
            // 
            this.labelIsAdmin.AutoSize = true;
            this.labelIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.labelIsAdmin.Location = new System.Drawing.Point(16, 159);
            this.labelIsAdmin.Name = "labelIsAdmin";
            this.labelIsAdmin.Size = new System.Drawing.Size(36, 13);
            this.labelIsAdmin.TabIndex = 4;
            this.labelIsAdmin.Text = "Admin";
            // 
            // ctbEmployeeName
            // 
            this.ctbEmployeeName.BackColor = System.Drawing.Color.White;
            this.ctbEmployeeName.changeTextBoxSize = false;
            this.ctbEmployeeName.customText = "Name";
            this.ctbEmployeeName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbEmployeeName.Location = new System.Drawing.Point(37, 14);
            this.ctbEmployeeName.Name = "ctbEmployeeName";
            this.ctbEmployeeName.password = false;
            this.ctbEmployeeName.Size = new System.Drawing.Size(289, 49);
            this.ctbEmployeeName.TabIndex = 9;
            // 
            // cbEmployeeTF
            // 
            this.cbEmployeeTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmployeeTF.FormattingEnabled = true;
            this.cbEmployeeTF.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbEmployeeTF.Location = new System.Drawing.Point(67, 155);
            this.cbEmployeeTF.Name = "cbEmployeeTF";
            this.cbEmployeeTF.Size = new System.Drawing.Size(53, 21);
            this.cbEmployeeTF.TabIndex = 2;
            this.cbEmployeeTF.Text = "False";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.btnSaveEmployee.FlatAppearance.BorderSize = 0;
            this.btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSaveEmployee.Location = new System.Drawing.Point(168, 215);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEmployee.TabIndex = 0;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1238, 758);
            this.Controls.Add(this.panelAddEmployee);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(1184, 797);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelAddEmployee;
        private System.Windows.Forms.Label labelIsAdmin;
        private System.Windows.Forms.ComboBox cbEmployeeTF;
        private System.Windows.Forms.Button btnSaveEmployee;
        private UserControls.customTextBox ctbEmployeeName;
        private UserControls.customTextBox ctbEmployeePassw;
    }
}