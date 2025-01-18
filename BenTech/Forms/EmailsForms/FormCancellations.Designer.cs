
namespace BenTech.Forms.EmailsForms
{
    partial class FormCancellations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnCancellationNoDeposit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCancellationEmail = new System.Windows.Forms.Label();
            this.ibtnCreateEmailCancellationRequest = new FontAwesome.Sharp.IconButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.ctbReservationNumber = new BenTech.UserControls.customTextBox();
            this.lblCancellation = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ctbEmailAdress = new BenTech.UserControls.customTextBox();
            this.ctbPersonName = new BenTech.UserControls.customTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.ibtnCancellationNoDeposit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(452, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 287);
            this.panel1.TabIndex = 0;
            // 
            // ibtnCancellationNoDeposit
            // 
            this.ibtnCancellationNoDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibtnCancellationNoDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnCancellationNoDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancellationNoDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCancellationNoDeposit.ForeColor = System.Drawing.Color.White;
            this.ibtnCancellationNoDeposit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCancellationNoDeposit.IconColor = System.Drawing.Color.Black;
            this.ibtnCancellationNoDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancellationNoDeposit.Location = new System.Drawing.Point(97, 164);
            this.ibtnCancellationNoDeposit.Name = "ibtnCancellationNoDeposit";
            this.ibtnCancellationNoDeposit.Size = new System.Drawing.Size(136, 44);
            this.ibtnCancellationNoDeposit.TabIndex = 1;
            this.ibtnCancellationNoDeposit.Text = "Create Email";
            this.ibtnCancellationNoDeposit.UseVisualStyleBackColor = false;
            this.ibtnCancellationNoDeposit.Click += new System.EventHandler(this.ibtnCancellationNoDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancellation - Deposit receipt not received";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.lblCancellationEmail);
            this.panel2.Controls.Add(this.ibtnCreateEmailCancellationRequest);
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtpStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 287);
            this.panel2.TabIndex = 1;
            // 
            // lblCancellationEmail
            // 
            this.lblCancellationEmail.AutoSize = true;
            this.lblCancellationEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellationEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblCancellationEmail.Location = new System.Drawing.Point(4, 20);
            this.lblCancellationEmail.Name = "lblCancellationEmail";
            this.lblCancellationEmail.Size = new System.Drawing.Size(255, 13);
            this.lblCancellationEmail.TabIndex = 6;
            this.lblCancellationEmail.Text = "Cancellation - Guest requested cancellation";
            // 
            // ibtnCreateEmailCancellationRequest
            // 
            this.ibtnCreateEmailCancellationRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibtnCreateEmailCancellationRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnCreateEmailCancellationRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCreateEmailCancellationRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCreateEmailCancellationRequest.ForeColor = System.Drawing.Color.White;
            this.ibtnCreateEmailCancellationRequest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCreateEmailCancellationRequest.IconColor = System.Drawing.Color.Black;
            this.ibtnCreateEmailCancellationRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCreateEmailCancellationRequest.Location = new System.Drawing.Point(165, 164);
            this.ibtnCreateEmailCancellationRequest.Name = "ibtnCreateEmailCancellationRequest";
            this.ibtnCreateEmailCancellationRequest.Size = new System.Drawing.Size(136, 44);
            this.ibtnCreateEmailCancellationRequest.TabIndex = 4;
            this.ibtnCreateEmailCancellationRequest.Text = "Create Email";
            this.ibtnCreateEmailCancellationRequest.UseVisualStyleBackColor = false;
            this.ibtnCreateEmailCancellationRequest.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(229, 68);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(216, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(7, 68);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(216, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // ctbReservationNumber
            // 
            this.ctbReservationNumber.BackColor = System.Drawing.Color.White;
            this.ctbReservationNumber.changeTextBoxSize = true;
            this.ctbReservationNumber.customText = "Reservation  Number";
            this.ctbReservationNumber.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbReservationNumber.Location = new System.Drawing.Point(12, 99);
            this.ctbReservationNumber.Name = "ctbReservationNumber";
            this.ctbReservationNumber.password = false;
            this.ctbReservationNumber.Size = new System.Drawing.Size(289, 49);
            this.ctbReservationNumber.TabIndex = 0;
            // 
            // lblCancellation
            // 
            this.lblCancellation.AutoSize = true;
            this.lblCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblCancellation.Location = new System.Drawing.Point(3, 9);
            this.lblCancellation.Name = "lblCancellation";
            this.lblCancellation.Size = new System.Drawing.Size(166, 20);
            this.lblCancellation.TabIndex = 3;
            this.lblCancellation.Text = "Cancellation Emails";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.lblCancellation);
            this.panel4.Controls.Add(this.ctbReservationNumber);
            this.panel4.Controls.Add(this.ctbEmailAdress);
            this.panel4.Controls.Add(this.ctbPersonName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 159);
            this.panel4.TabIndex = 3;
            // 
            // ctbEmailAdress
            // 
            this.ctbEmailAdress.BackColor = System.Drawing.Color.White;
            this.ctbEmailAdress.changeTextBoxSize = false;
            this.ctbEmailAdress.customText = "Email";
            this.ctbEmailAdress.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbEmailAdress.Location = new System.Drawing.Point(322, 44);
            this.ctbEmailAdress.Name = "ctbEmailAdress";
            this.ctbEmailAdress.password = false;
            this.ctbEmailAdress.Size = new System.Drawing.Size(289, 49);
            this.ctbEmailAdress.TabIndex = 2;
            // 
            // ctbPersonName
            // 
            this.ctbPersonName.BackColor = System.Drawing.Color.White;
            this.ctbPersonName.changeTextBoxSize = false;
            this.ctbPersonName.customText = "Name";
            this.ctbPersonName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbPersonName.Location = new System.Drawing.Point(12, 44);
            this.ctbPersonName.Name = "ctbPersonName";
            this.ctbPersonName.password = false;
            this.ctbPersonName.Size = new System.Drawing.Size(289, 49);
            this.ctbPersonName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 4);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(448, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 287);
            this.panel5.TabIndex = 5;
            // 
            // FormCancellations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "FormCancellations";
            this.Text = "FormCancellations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControls.customTextBox ctbPersonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnCancellationNoDeposit;
        private FontAwesome.Sharp.IconButton ibtnCreateEmailCancellationRequest;
        private System.Windows.Forms.Label lblCancellation;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private UserControls.customTextBox ctbReservationNumber;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Panel panel4;
        private UserControls.customTextBox ctbEmailAdress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCancellationEmail;
    }
}