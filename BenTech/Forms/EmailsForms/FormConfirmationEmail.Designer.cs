
namespace BenTech.Forms.EmailsForms
{
    partial class FormConfirmationEmail
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
            this.ctbTax = new BenTech.UserControls.customTextBox();
            this.ctbPersonName = new BenTech.UserControls.customTextBox();
            this.ibtnCreateQuoteEmail = new FontAwesome.Sharp.IconButton();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.checkBoxLuxuryCouple = new System.Windows.Forms.CheckBox();
            this.checkBoxQuintuple = new System.Windows.Forms.CheckBox();
            this.checkBoxQuadruple = new System.Windows.Forms.CheckBox();
            this.checkBoxCouple = new System.Windows.Forms.CheckBox();
            this.checkBoxTriple = new System.Windows.Forms.CheckBox();
            this.ctbReservationNumber = new BenTech.UserControls.customTextBox();
            this.dtpDeposit = new System.Windows.Forms.DateTimePicker();
            this.lblEmailConfirmation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctbTax
            // 
            this.ctbTax.BackColor = System.Drawing.Color.White;
            this.ctbTax.changeTextBoxSize = false;
            this.ctbTax.customText = "Tax";
            this.ctbTax.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTax.Location = new System.Drawing.Point(202, 67);
            this.ctbTax.Name = "ctbTax";
            this.ctbTax.password = false;
            this.ctbTax.Size = new System.Drawing.Size(289, 49);
            this.ctbTax.TabIndex = 25;
            // 
            // ctbPersonName
            // 
            this.ctbPersonName.BackColor = System.Drawing.Color.White;
            this.ctbPersonName.changeTextBoxSize = false;
            this.ctbPersonName.customText = "Name";
            this.ctbPersonName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbPersonName.Location = new System.Drawing.Point(202, 12);
            this.ctbPersonName.Name = "ctbPersonName";
            this.ctbPersonName.password = false;
            this.ctbPersonName.Size = new System.Drawing.Size(289, 49);
            this.ctbPersonName.TabIndex = 24;
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
            this.ibtnCreateQuoteEmail.Location = new System.Drawing.Point(25, 383);
            this.ibtnCreateQuoteEmail.Name = "ibtnCreateQuoteEmail";
            this.ibtnCreateQuoteEmail.Size = new System.Drawing.Size(136, 44);
            this.ibtnCreateQuoteEmail.TabIndex = 23;
            this.ibtnCreateQuoteEmail.Text = "Criar email";
            this.ibtnCreateQuoteEmail.UseVisualStyleBackColor = false;
            this.ibtnCreateQuoteEmail.Click += new System.EventHandler(this.ibtnCreateQuoteEmail_Click);
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxCustom.Location = new System.Drawing.Point(25, 154);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(61, 17);
            this.checkBoxCustom.TabIndex = 22;
            this.checkBoxCustom.Text = "Custom";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            // 
            // checkBoxLuxuryCouple
            // 
            this.checkBoxLuxuryCouple.AutoSize = true;
            this.checkBoxLuxuryCouple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxLuxuryCouple.Location = new System.Drawing.Point(25, 62);
            this.checkBoxLuxuryCouple.Name = "checkBoxLuxuryCouple";
            this.checkBoxLuxuryCouple.Size = new System.Drawing.Size(78, 17);
            this.checkBoxLuxuryCouple.TabIndex = 18;
            this.checkBoxLuxuryCouple.Text = "Casal Luxo";
            this.checkBoxLuxuryCouple.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuintuple
            // 
            this.checkBoxQuintuple.AutoSize = true;
            this.checkBoxQuintuple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxQuintuple.Location = new System.Drawing.Point(25, 131);
            this.checkBoxQuintuple.Name = "checkBoxQuintuple";
            this.checkBoxQuintuple.Size = new System.Drawing.Size(71, 17);
            this.checkBoxQuintuple.TabIndex = 21;
            this.checkBoxQuintuple.Text = "Quintuplo";
            this.checkBoxQuintuple.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuadruple
            // 
            this.checkBoxQuadruple.AutoSize = true;
            this.checkBoxQuadruple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxQuadruple.Location = new System.Drawing.Point(25, 108);
            this.checkBoxQuadruple.Name = "checkBoxQuadruple";
            this.checkBoxQuadruple.Size = new System.Drawing.Size(75, 17);
            this.checkBoxQuadruple.TabIndex = 20;
            this.checkBoxQuadruple.Text = "Quadruplo";
            this.checkBoxQuadruple.UseVisualStyleBackColor = true;
            // 
            // checkBoxCouple
            // 
            this.checkBoxCouple.AutoSize = true;
            this.checkBoxCouple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxCouple.Location = new System.Drawing.Point(25, 39);
            this.checkBoxCouple.Name = "checkBoxCouple";
            this.checkBoxCouple.Size = new System.Drawing.Size(52, 17);
            this.checkBoxCouple.TabIndex = 17;
            this.checkBoxCouple.Text = "Casal";
            this.checkBoxCouple.UseVisualStyleBackColor = true;
            // 
            // checkBoxTriple
            // 
            this.checkBoxTriple.AutoSize = true;
            this.checkBoxTriple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.checkBoxTriple.Location = new System.Drawing.Point(25, 85);
            this.checkBoxTriple.Name = "checkBoxTriple";
            this.checkBoxTriple.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTriple.TabIndex = 19;
            this.checkBoxTriple.Text = "Triplo";
            this.checkBoxTriple.UseVisualStyleBackColor = true;
            // 
            // ctbReservationNumber
            // 
            this.ctbReservationNumber.BackColor = System.Drawing.Color.White;
            this.ctbReservationNumber.changeTextBoxSize = true;
            this.ctbReservationNumber.customText = "Reservation Number";
            this.ctbReservationNumber.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbReservationNumber.Location = new System.Drawing.Point(202, 122);
            this.ctbReservationNumber.Name = "ctbReservationNumber";
            this.ctbReservationNumber.password = false;
            this.ctbReservationNumber.Size = new System.Drawing.Size(289, 49);
            this.ctbReservationNumber.TabIndex = 26;
            // 
            // dtpDeposit
            // 
            this.dtpDeposit.Location = new System.Drawing.Point(322, 189);
            this.dtpDeposit.Name = "dtpDeposit";
            this.dtpDeposit.Size = new System.Drawing.Size(236, 20);
            this.dtpDeposit.TabIndex = 27;
            // 
            // lblEmailConfirmation
            // 
            this.lblEmailConfirmation.AutoSize = true;
            this.lblEmailConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblEmailConfirmation.Location = new System.Drawing.Point(13, 9);
            this.lblEmailConfirmation.Name = "lblEmailConfirmation";
            this.lblEmailConfirmation.Size = new System.Drawing.Size(160, 20);
            this.lblEmailConfirmation.TabIndex = 28;
            this.lblEmailConfirmation.Text = "Email Confirmation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(199, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Max date deposit :";
            // 
            // FormConfirmationEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailConfirmation);
            this.Controls.Add(this.dtpDeposit);
            this.Controls.Add(this.ctbReservationNumber);
            this.Controls.Add(this.ctbTax);
            this.Controls.Add(this.ctbPersonName);
            this.Controls.Add(this.ibtnCreateQuoteEmail);
            this.Controls.Add(this.checkBoxCustom);
            this.Controls.Add(this.checkBoxLuxuryCouple);
            this.Controls.Add(this.checkBoxQuintuple);
            this.Controls.Add(this.checkBoxQuadruple);
            this.Controls.Add(this.checkBoxCouple);
            this.Controls.Add(this.checkBoxTriple);
            this.Name = "FormConfirmationEmail";
            this.Text = "FormConfirmationEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.customTextBox ctbTax;
        private UserControls.customTextBox ctbPersonName;
        private FontAwesome.Sharp.IconButton ibtnCreateQuoteEmail;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxLuxuryCouple;
        private System.Windows.Forms.CheckBox checkBoxQuintuple;
        private System.Windows.Forms.CheckBox checkBoxQuadruple;
        private System.Windows.Forms.CheckBox checkBoxCouple;
        private System.Windows.Forms.CheckBox checkBoxTriple;
        private UserControls.customTextBox ctbReservationNumber;
        private System.Windows.Forms.DateTimePicker dtpDeposit;
        private System.Windows.Forms.Label lblEmailConfirmation;
        private System.Windows.Forms.Label label1;
    }
}