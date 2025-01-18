
namespace BenTech.Forms.EmailsForms
{
    partial class FormChangeReservation
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
            this.dtpStartBefore = new System.Windows.Forms.DateTimePicker();
            this.dtpStartAfter = new System.Windows.Forms.DateTimePicker();
            this.dtpEndBefore = new System.Windows.Forms.DateTimePicker();
            this.dtpEndAfter = new System.Windows.Forms.DateTimePicker();
            this.panelAfterChange = new System.Windows.Forms.Panel();
            this.ctbEmailAdress = new BenTech.UserControls.customTextBox();
            this.panelBeforeChange = new System.Windows.Forms.Panel();
            this.ctbReservationNumber = new BenTech.UserControls.customTextBox();
            this.ibtnCreateEmail = new FontAwesome.Sharp.IconButton();
            this.ctbRoomTypeAfter = new BenTech.UserControls.customTextBox();
            this.ctbRoomTypeBefore = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateAfter = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateBefore = new BenTech.UserControls.customTextBox();
            this.ctbPersonName = new BenTech.UserControls.customTextBox();
            this.lblAfterChange = new System.Windows.Forms.Label();
            this.lblBeforeChange = new System.Windows.Forms.Label();
            this.panelButtonCreateEmail = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.panelLine3 = new System.Windows.Forms.Panel();
            this.lblDateBefore = new System.Windows.Forms.Label();
            this.lblDateAfter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAfterChange.SuspendLayout();
            this.panelBeforeChange.SuspendLayout();
            this.panelButtonCreateEmail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartBefore
            // 
            this.dtpStartBefore.Location = new System.Drawing.Point(353, 54);
            this.dtpStartBefore.Name = "dtpStartBefore";
            this.dtpStartBefore.Size = new System.Drawing.Size(233, 20);
            this.dtpStartBefore.TabIndex = 0;
            // 
            // dtpStartAfter
            // 
            this.dtpStartAfter.Location = new System.Drawing.Point(591, 54);
            this.dtpStartAfter.Name = "dtpStartAfter";
            this.dtpStartAfter.Size = new System.Drawing.Size(233, 20);
            this.dtpStartAfter.TabIndex = 1;
            // 
            // dtpEndBefore
            // 
            this.dtpEndBefore.Location = new System.Drawing.Point(353, 66);
            this.dtpEndBefore.Name = "dtpEndBefore";
            this.dtpEndBefore.Size = new System.Drawing.Size(233, 20);
            this.dtpEndBefore.TabIndex = 2;
            // 
            // dtpEndAfter
            // 
            this.dtpEndAfter.Location = new System.Drawing.Point(591, 66);
            this.dtpEndAfter.Name = "dtpEndAfter";
            this.dtpEndAfter.Size = new System.Drawing.Size(233, 20);
            this.dtpEndAfter.TabIndex = 3;
            // 
            // panelAfterChange
            // 
            this.panelAfterChange.Controls.Add(this.lblDateBefore);
            this.panelAfterChange.Controls.Add(this.panelLine3);
            this.panelAfterChange.Controls.Add(this.lblBeforeChange);
            this.panelAfterChange.Controls.Add(this.dtpStartBefore);
            this.panelAfterChange.Controls.Add(this.ctbRoomTypeBefore);
            this.panelAfterChange.Controls.Add(this.ctbDailyRateBefore);
            this.panelAfterChange.Controls.Add(this.dtpStartAfter);
            this.panelAfterChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAfterChange.Location = new System.Drawing.Point(0, 148);
            this.panelAfterChange.Name = "panelAfterChange";
            this.panelAfterChange.Size = new System.Drawing.Size(1168, 150);
            this.panelAfterChange.TabIndex = 4;
            // 
            // ctbEmailAdress
            // 
            this.ctbEmailAdress.BackColor = System.Drawing.Color.White;
            this.ctbEmailAdress.changeTextBoxSize = false;
            this.ctbEmailAdress.customText = "Email Adress";
            this.ctbEmailAdress.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbEmailAdress.Location = new System.Drawing.Point(334, 43);
            this.ctbEmailAdress.Name = "ctbEmailAdress";
            this.ctbEmailAdress.password = false;
            this.ctbEmailAdress.Size = new System.Drawing.Size(289, 49);
            this.ctbEmailAdress.TabIndex = 2;
            // 
            // panelBeforeChange
            // 
            this.panelBeforeChange.Controls.Add(this.lblDateAfter);
            this.panelBeforeChange.Controls.Add(this.panelLine2);
            this.panelBeforeChange.Controls.Add(this.lblAfterChange);
            this.panelBeforeChange.Controls.Add(this.ctbRoomTypeAfter);
            this.panelBeforeChange.Controls.Add(this.dtpEndBefore);
            this.panelBeforeChange.Controls.Add(this.ctbDailyRateAfter);
            this.panelBeforeChange.Controls.Add(this.dtpEndAfter);
            this.panelBeforeChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBeforeChange.Location = new System.Drawing.Point(0, 298);
            this.panelBeforeChange.Name = "panelBeforeChange";
            this.panelBeforeChange.Size = new System.Drawing.Size(1168, 150);
            this.panelBeforeChange.TabIndex = 5;
            // 
            // ctbReservationNumber
            // 
            this.ctbReservationNumber.BackColor = System.Drawing.Color.White;
            this.ctbReservationNumber.changeTextBoxSize = true;
            this.ctbReservationNumber.customText = "Reservation Number";
            this.ctbReservationNumber.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbReservationNumber.Location = new System.Drawing.Point(644, 43);
            this.ctbReservationNumber.Name = "ctbReservationNumber";
            this.ctbReservationNumber.password = false;
            this.ctbReservationNumber.Size = new System.Drawing.Size(289, 49);
            this.ctbReservationNumber.TabIndex = 4;
            // 
            // ibtnCreateEmail
            // 
            this.ibtnCreateEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibtnCreateEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnCreateEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCreateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnCreateEmail.ForeColor = System.Drawing.Color.White;
            this.ibtnCreateEmail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCreateEmail.IconColor = System.Drawing.Color.Black;
            this.ibtnCreateEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCreateEmail.Location = new System.Drawing.Point(21, 6);
            this.ibtnCreateEmail.Name = "ibtnCreateEmail";
            this.ibtnCreateEmail.Size = new System.Drawing.Size(136, 44);
            this.ibtnCreateEmail.TabIndex = 10;
            this.ibtnCreateEmail.Text = "Create Email";
            this.ibtnCreateEmail.UseVisualStyleBackColor = false;
            this.ibtnCreateEmail.Click += new System.EventHandler(this.ibtnCreateEmail_Click);
            // 
            // ctbRoomTypeAfter
            // 
            this.ctbRoomTypeAfter.BackColor = System.Drawing.Color.White;
            this.ctbRoomTypeAfter.changeTextBoxSize = true;
            this.ctbRoomTypeAfter.customText = "Room Type After";
            this.ctbRoomTypeAfter.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbRoomTypeAfter.Location = new System.Drawing.Point(21, 37);
            this.ctbRoomTypeAfter.Name = "ctbRoomTypeAfter";
            this.ctbRoomTypeAfter.password = false;
            this.ctbRoomTypeAfter.Size = new System.Drawing.Size(289, 49);
            this.ctbRoomTypeAfter.TabIndex = 11;
            // 
            // ctbRoomTypeBefore
            // 
            this.ctbRoomTypeBefore.BackColor = System.Drawing.Color.White;
            this.ctbRoomTypeBefore.changeTextBoxSize = true;
            this.ctbRoomTypeBefore.customText = "Room Type Before";
            this.ctbRoomTypeBefore.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbRoomTypeBefore.Location = new System.Drawing.Point(21, 25);
            this.ctbRoomTypeBefore.Name = "ctbRoomTypeBefore";
            this.ctbRoomTypeBefore.password = false;
            this.ctbRoomTypeBefore.Size = new System.Drawing.Size(289, 49);
            this.ctbRoomTypeBefore.TabIndex = 9;
            // 
            // ctbDailyRateAfter
            // 
            this.ctbDailyRateAfter.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateAfter.changeTextBoxSize = true;
            this.ctbDailyRateAfter.customText = "Daily rate after";
            this.ctbDailyRateAfter.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbDailyRateAfter.Location = new System.Drawing.Point(21, 91);
            this.ctbDailyRateAfter.Name = "ctbDailyRateAfter";
            this.ctbDailyRateAfter.password = false;
            this.ctbDailyRateAfter.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateAfter.TabIndex = 8;
            // 
            // ctbDailyRateBefore
            // 
            this.ctbDailyRateBefore.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateBefore.changeTextBoxSize = true;
            this.ctbDailyRateBefore.customText = "Daily rate before";
            this.ctbDailyRateBefore.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbDailyRateBefore.Location = new System.Drawing.Point(21, 80);
            this.ctbDailyRateBefore.Name = "ctbDailyRateBefore";
            this.ctbDailyRateBefore.password = false;
            this.ctbDailyRateBefore.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateBefore.TabIndex = 7;
            // 
            // ctbPersonName
            // 
            this.ctbPersonName.BackColor = System.Drawing.Color.White;
            this.ctbPersonName.changeTextBoxSize = true;
            this.ctbPersonName.customText = "Person Name";
            this.ctbPersonName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Right;
            this.ctbPersonName.Location = new System.Drawing.Point(21, 43);
            this.ctbPersonName.Name = "ctbPersonName";
            this.ctbPersonName.password = false;
            this.ctbPersonName.Size = new System.Drawing.Size(289, 49);
            this.ctbPersonName.TabIndex = 6;
            // 
            // lblAfterChange
            // 
            this.lblAfterChange.AutoSize = true;
            this.lblAfterChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblAfterChange.Location = new System.Drawing.Point(13, 13);
            this.lblAfterChange.Name = "lblAfterChange";
            this.lblAfterChange.Size = new System.Drawing.Size(97, 16);
            this.lblAfterChange.TabIndex = 12;
            this.lblAfterChange.Text = "After Change";
            // 
            // lblBeforeChange
            // 
            this.lblBeforeChange.AutoSize = true;
            this.lblBeforeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeforeChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblBeforeChange.Location = new System.Drawing.Point(13, 6);
            this.lblBeforeChange.Name = "lblBeforeChange";
            this.lblBeforeChange.Size = new System.Drawing.Size(111, 16);
            this.lblBeforeChange.TabIndex = 13;
            this.lblBeforeChange.Text = "Before Change";
            // 
            // panelButtonCreateEmail
            // 
            this.panelButtonCreateEmail.Controls.Add(this.ibtnCreateEmail);
            this.panelButtonCreateEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonCreateEmail.Location = new System.Drawing.Point(0, 448);
            this.panelButtonCreateEmail.Name = "panelButtonCreateEmail";
            this.panelButtonCreateEmail.Size = new System.Drawing.Size(1168, 57);
            this.panelButtonCreateEmail.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panelLine1);
            this.panel3.Controls.Add(this.ctbPersonName);
            this.panel3.Controls.Add(this.ctbEmailAdress);
            this.panel3.Controls.Add(this.ctbReservationNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 148);
            this.panel3.TabIndex = 12;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panelLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine1.Location = new System.Drawing.Point(0, 144);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1168, 4);
            this.panelLine1.TabIndex = 7;
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panelLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine2.Location = new System.Drawing.Point(0, 146);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(1168, 4);
            this.panelLine2.TabIndex = 13;
            // 
            // panelLine3
            // 
            this.panelLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panelLine3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine3.Location = new System.Drawing.Point(0, 146);
            this.panelLine3.Name = "panelLine3";
            this.panelLine3.Size = new System.Drawing.Size(1168, 4);
            this.panelLine3.TabIndex = 14;
            // 
            // lblDateBefore
            // 
            this.lblDateBefore.AutoSize = true;
            this.lblDateBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblDateBefore.Location = new System.Drawing.Point(546, 25);
            this.lblDateBefore.Name = "lblDateBefore";
            this.lblDateBefore.Size = new System.Drawing.Size(80, 16);
            this.lblDateBefore.TabIndex = 15;
            this.lblDateBefore.Text = "Date Before";
            // 
            // lblDateAfter
            // 
            this.lblDateAfter.AutoSize = true;
            this.lblDateAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblDateAfter.Location = new System.Drawing.Point(556, 37);
            this.lblDateAfter.Name = "lblDateAfter";
            this.lblDateAfter.Size = new System.Drawing.Size(67, 16);
            this.lblDateAfter.TabIndex = 16;
            this.lblDateAfter.Text = "Date After";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reservation Change";
            // 
            // FormChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1168, 771);
            this.Controls.Add(this.panelButtonCreateEmail);
            this.Controls.Add(this.panelBeforeChange);
            this.Controls.Add(this.panelAfterChange);
            this.Controls.Add(this.panel3);
            this.Name = "FormChangeReservation";
            this.Text = "FormChangeReservation";
            this.panelAfterChange.ResumeLayout(false);
            this.panelAfterChange.PerformLayout();
            this.panelBeforeChange.ResumeLayout(false);
            this.panelBeforeChange.PerformLayout();
            this.panelButtonCreateEmail.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartBefore;
        private System.Windows.Forms.DateTimePicker dtpStartAfter;
        private System.Windows.Forms.DateTimePicker dtpEndBefore;
        private System.Windows.Forms.DateTimePicker dtpEndAfter;
        private System.Windows.Forms.Panel panelAfterChange;
        private System.Windows.Forms.Panel panelBeforeChange;
        private UserControls.customTextBox ctbPersonName;
        private UserControls.customTextBox ctbDailyRateBefore;
        private UserControls.customTextBox ctbDailyRateAfter;
        private UserControls.customTextBox ctbRoomTypeBefore;
        private FontAwesome.Sharp.IconButton ibtnCreateEmail;
        private UserControls.customTextBox ctbEmailAdress;
        private UserControls.customTextBox ctbReservationNumber;
        private UserControls.customTextBox ctbRoomTypeAfter;
        private System.Windows.Forms.Label lblBeforeChange;
        private System.Windows.Forms.Label lblAfterChange;
        private System.Windows.Forms.Panel panelButtonCreateEmail;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine3;
        private System.Windows.Forms.Label lblDateBefore;
        private System.Windows.Forms.Label lblDateAfter;
        private System.Windows.Forms.Label label1;
    }
}