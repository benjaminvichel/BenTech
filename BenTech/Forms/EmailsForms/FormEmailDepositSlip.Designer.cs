
namespace BenTech.Forms.EmailsForms
{
    partial class FormEmailDepositSlip
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
            this.ctbDepositPersonName = new BenTech.UserControls.customTextBox();
            this.ctbDepositReservationNumber = new BenTech.UserControls.customTextBox();
            this.ctbDepositValue = new BenTech.UserControls.customTextBox();
            this.ibtnCreateQuoteEmail = new FontAwesome.Sharp.IconButton();
            this.lblDepositEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctbDepositPersonName
            // 
            this.ctbDepositPersonName.BackColor = System.Drawing.Color.White;
            this.ctbDepositPersonName.changeTextBoxSize = false;
            this.ctbDepositPersonName.customText = "Name";
            this.ctbDepositPersonName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDepositPersonName.Location = new System.Drawing.Point(25, 46);
            this.ctbDepositPersonName.Name = "ctbDepositPersonName";
            this.ctbDepositPersonName.password = false;
            this.ctbDepositPersonName.Size = new System.Drawing.Size(289, 49);
            this.ctbDepositPersonName.TabIndex = 0;
            // 
            // ctbDepositReservationNumber
            // 
            this.ctbDepositReservationNumber.BackColor = System.Drawing.Color.White;
            this.ctbDepositReservationNumber.changeTextBoxSize = false;
            this.ctbDepositReservationNumber.customText = "R. Number";
            this.ctbDepositReservationNumber.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDepositReservationNumber.Location = new System.Drawing.Point(25, 101);
            this.ctbDepositReservationNumber.Name = "ctbDepositReservationNumber";
            this.ctbDepositReservationNumber.password = false;
            this.ctbDepositReservationNumber.Size = new System.Drawing.Size(289, 49);
            this.ctbDepositReservationNumber.TabIndex = 1;
            // 
            // ctbDepositValue
            // 
            this.ctbDepositValue.BackColor = System.Drawing.Color.White;
            this.ctbDepositValue.changeTextBoxSize = false;
            this.ctbDepositValue.customText = "Deposit";
            this.ctbDepositValue.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDepositValue.Location = new System.Drawing.Point(25, 156);
            this.ctbDepositValue.Name = "ctbDepositValue";
            this.ctbDepositValue.password = false;
            this.ctbDepositValue.Size = new System.Drawing.Size(289, 49);
            this.ctbDepositValue.TabIndex = 2;
            // 
            // ibtnCreateQuoteEmail
            // 
            this.ibtnCreateQuoteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibtnCreateQuoteEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnCreateQuoteEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCreateQuoteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCreateQuoteEmail.ForeColor = System.Drawing.Color.White;
            this.ibtnCreateQuoteEmail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCreateQuoteEmail.IconColor = System.Drawing.Color.Black;
            this.ibtnCreateQuoteEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCreateQuoteEmail.Location = new System.Drawing.Point(16, 268);
            this.ibtnCreateQuoteEmail.Name = "ibtnCreateQuoteEmail";
            this.ibtnCreateQuoteEmail.Size = new System.Drawing.Size(136, 44);
            this.ibtnCreateQuoteEmail.TabIndex = 24;
            this.ibtnCreateQuoteEmail.Text = "Criar email";
            this.ibtnCreateQuoteEmail.UseVisualStyleBackColor = false;
            this.ibtnCreateQuoteEmail.Click += new System.EventHandler(this.ibtnCreateQuoteEmail_Click);
            // 
            // lblDepositEmail
            // 
            this.lblDepositEmail.AutoSize = true;
            this.lblDepositEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblDepositEmail.Location = new System.Drawing.Point(12, 9);
            this.lblDepositEmail.Name = "lblDepositEmail";
            this.lblDepositEmail.Size = new System.Drawing.Size(120, 20);
            this.lblDepositEmail.TabIndex = 29;
            this.lblDepositEmail.Text = "Deposit Email";
            // 
            // FormEmailDepositSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ibtnCreateQuoteEmail);
            this.Controls.Add(this.lblDepositEmail);
            this.Controls.Add(this.ctbDepositValue);
            this.Controls.Add(this.ctbDepositReservationNumber);
            this.Controls.Add(this.ctbDepositPersonName);
            this.Name = "FormEmailDepositSlip";
            this.Text = "FormEmailDepositSlip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.customTextBox ctbDepositPersonName;
        private UserControls.customTextBox ctbDepositReservationNumber;
        private UserControls.customTextBox ctbDepositValue;
        private FontAwesome.Sharp.IconButton ibtnCreateQuoteEmail;
        private System.Windows.Forms.Label lblDepositEmail;
    }
}