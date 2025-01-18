
namespace BenTech.Forms
{
    partial class FormTestResponsive
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
            System.Windows.Forms.Panel panelShadow;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestResponsive));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnDataBase = new FontAwesome.Sharp.IconButton();
            this.ibtnEmployees = new FontAwesome.Sharp.IconButton();
            this.ibtnPricesCalculator = new FontAwesome.Sharp.IconButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ibLogout = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.ibExitApp = new FontAwesome.Sharp.IconButton();
            this.ibMinimize = new FontAwesome.Sharp.IconButton();
            this.ibMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            panelShadow.Location = new System.Drawing.Point(220, 62);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new System.Drawing.Size(1184, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.ibtnDataBase);
            this.panelMenu.Controls.Add(this.ibtnEmployees);
            this.panelMenu.Controls.Add(this.ibtnPricesCalculator);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 881);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnDataBase
            // 
            this.ibtnDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDataBase.FlatAppearance.BorderSize = 0;
            this.ibtnDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ibtnDataBase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDataBase.Location = new System.Drawing.Point(0, 231);
            this.ibtnDataBase.Name = "ibtnDataBase";
            this.ibtnDataBase.Size = new System.Drawing.Size(220, 60);
            this.ibtnDataBase.TabIndex = 3;
            this.ibtnDataBase.Text = "DataBase";
            this.ibtnDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDataBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDataBase.UseVisualStyleBackColor = true;
            this.ibtnDataBase.Click += new System.EventHandler(this.ibtnDataBase_Click);
            this.ibtnDataBase.MouseEnter += new System.EventHandler(this.ibtnDataBase_MouseEnter);
            this.ibtnDataBase.MouseLeave += new System.EventHandler(this.ibtnDataBase_MouseLeave);
            // 
            // ibtnEmployees
            // 
            this.ibtnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnEmployees.FlatAppearance.BorderSize = 0;
            this.ibtnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnEmployees.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnEmployees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmployees.Location = new System.Drawing.Point(0, 171);
            this.ibtnEmployees.Name = "ibtnEmployees";
            this.ibtnEmployees.Size = new System.Drawing.Size(220, 60);
            this.ibtnEmployees.TabIndex = 2;
            this.ibtnEmployees.Text = "Employees";
            this.ibtnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEmployees.UseVisualStyleBackColor = true;
            this.ibtnEmployees.Click += new System.EventHandler(this.ibtnEmployees_Click);
            this.ibtnEmployees.MouseEnter += new System.EventHandler(this.ibtnDataBase_MouseEnter);
            this.ibtnEmployees.MouseLeave += new System.EventHandler(this.ibtnDataBase_MouseLeave);
            // 
            // ibtnPricesCalculator
            // 
            this.ibtnPricesCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPricesCalculator.FlatAppearance.BorderSize = 0;
            this.ibtnPricesCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnPricesCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnPricesCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPricesCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnPricesCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnPricesCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.ibtnPricesCalculator.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnPricesCalculator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPricesCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPricesCalculator.Location = new System.Drawing.Point(0, 111);
            this.ibtnPricesCalculator.Name = "ibtnPricesCalculator";
            this.ibtnPricesCalculator.Size = new System.Drawing.Size(220, 60);
            this.ibtnPricesCalculator.TabIndex = 1;
            this.ibtnPricesCalculator.Text = "Prices Calculator";
            this.ibtnPricesCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPricesCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPricesCalculator.UseVisualStyleBackColor = true;
            this.ibtnPricesCalculator.Click += new System.EventHandler(this.ibtnPricesCalculator_Click);
            this.ibtnPricesCalculator.MouseEnter += new System.EventHandler(this.ibtnDataBase_MouseEnter);
            this.ibtnPricesCalculator.MouseLeave += new System.EventHandler(this.ibtnDataBase_MouseLeave);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.ibLogout);
            this.panelHome.Controls.Add(this.pictureBoxLogo);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(220, 111);
            this.panelHome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "BenTech";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ibLogout
            // 
            this.ibLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibLogout.BackColor = System.Drawing.Color.White;
            this.ibLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibLogout.FlatAppearance.BorderSize = 0;
            this.ibLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.ibLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLogout.IconSize = 18;
            this.ibLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibLogout.Location = new System.Drawing.Point(3, 3);
            this.ibLogout.Name = "ibLogout";
            this.ibLogout.Size = new System.Drawing.Size(66, 23);
            this.ibLogout.TabIndex = 2;
            this.ibLogout.Text = "Logout";
            this.ibLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibLogout.UseVisualStyleBackColor = false;
            this.ibLogout.Click += new System.EventHandler(this.ibLogout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 21);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 87);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.ibExitApp);
            this.panelTitleBar.Controls.Add(this.ibMinimize);
            this.panelTitleBar.Controls.Add(this.ibMaximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1184, 62);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // ibExitApp
            // 
            this.ibExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibExitApp.FlatAppearance.BorderSize = 0;
            this.ibExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibExitApp.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibExitApp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibExitApp.IconColor = System.Drawing.Color.Gainsboro;
            this.ibExitApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibExitApp.IconSize = 18;
            this.ibExitApp.Location = new System.Drawing.Point(1155, 2);
            this.ibExitApp.Margin = new System.Windows.Forms.Padding(0);
            this.ibExitApp.Name = "ibExitApp";
            this.ibExitApp.Size = new System.Drawing.Size(29, 23);
            this.ibExitApp.TabIndex = 5;
            this.ibExitApp.Text = "X";
            this.ibExitApp.UseVisualStyleBackColor = true;
            this.ibExitApp.Click += new System.EventHandler(this.ibExitApp_Click);
            // 
            // ibMinimize
            // 
            this.ibMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibMinimize.FlatAppearance.BorderSize = 0;
            this.ibMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.ibMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMinimize.IconSize = 18;
            this.ibMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibMinimize.Location = new System.Drawing.Point(1109, 0);
            this.ibMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ibMinimize.Name = "ibMinimize";
            this.ibMinimize.Size = new System.Drawing.Size(20, 23);
            this.ibMinimize.TabIndex = 4;
            this.ibMinimize.UseVisualStyleBackColor = false;
            this.ibMinimize.Click += new System.EventHandler(this.ibMinimize_Click);
            // 
            // ibMaximize
            // 
            this.ibMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibMaximize.FlatAppearance.BorderSize = 0;
            this.ibMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.ibMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.ibMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMaximize.IconSize = 18;
            this.ibMaximize.Location = new System.Drawing.Point(1135, 3);
            this.ibMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ibMaximize.Name = "ibMaximize";
            this.ibMaximize.Size = new System.Drawing.Size(20, 23);
            this.ibMaximize.TabIndex = 3;
            this.ibMaximize.UseVisualStyleBackColor = false;
            this.ibMaximize.Click += new System.EventHandler(this.ibMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.White;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 71);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1184, 797);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1184, 810);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormTestResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 881);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1420, 920);
            this.Name = "FormTestResponsive";
            this.Text = "FormTestResponsive";
            this.panelMenu.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHome;
        private FontAwesome.Sharp.IconButton ibtnPricesCalculator;
        private FontAwesome.Sharp.IconButton ibtnDataBase;
        private FontAwesome.Sharp.IconButton ibtnEmployees;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton ibMinimize;
        private FontAwesome.Sharp.IconButton ibMaximize;
        private FontAwesome.Sharp.IconButton ibLogout;
        private FontAwesome.Sharp.IconButton ibExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}