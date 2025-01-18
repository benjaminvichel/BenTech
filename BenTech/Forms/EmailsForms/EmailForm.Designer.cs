
namespace BenTech.Forms
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCancellation = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnQuoteEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDisplayEmailForms = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelLineVertical = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panelLineVertical);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnCancellation);
            this.panel1.Controls.Add(this.btnDeposit);
            this.panel1.Controls.Add(this.btnConfirmation);
            this.panel1.Controls.Add(this.btnQuoteEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 450);
            this.panel1.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.button5.Location = new System.Drawing.Point(10, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "- Change Reservation";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.btnQuoteEmail_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.btnQuoteEmail_MouseLeave);
            // 
            // btnCancellation
            // 
            this.btnCancellation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCancellation.FlatAppearance.BorderSize = 0;
            this.btnCancellation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancellation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancellation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnCancellation.Location = new System.Drawing.Point(10, 120);
            this.btnCancellation.Name = "btnCancellation";
            this.btnCancellation.Size = new System.Drawing.Size(139, 23);
            this.btnCancellation.TabIndex = 10;
            this.btnCancellation.Text = "- Cancellation";
            this.btnCancellation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancellation.UseVisualStyleBackColor = false;
            this.btnCancellation.Click += new System.EventHandler(this.btnCancellation_Click);
            this.btnCancellation.MouseEnter += new System.EventHandler(this.btnQuoteEmail_MouseEnter);
            this.btnCancellation.MouseLeave += new System.EventHandler(this.btnQuoteEmail_MouseLeave);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnDeposit.Location = new System.Drawing.Point(10, 91);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(139, 23);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "- Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.MouseEnter += new System.EventHandler(this.btnQuoteEmail_MouseEnter);
            this.btnDeposit.MouseLeave += new System.EventHandler(this.btnQuoteEmail_MouseLeave);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnConfirmation.FlatAppearance.BorderSize = 0;
            this.btnConfirmation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnConfirmation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnConfirmation.Location = new System.Drawing.Point(10, 62);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(139, 23);
            this.btnConfirmation.TabIndex = 8;
            this.btnConfirmation.Text = "- Confirmation";
            this.btnConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            this.btnConfirmation.MouseEnter += new System.EventHandler(this.btnQuoteEmail_MouseEnter);
            this.btnConfirmation.MouseLeave += new System.EventHandler(this.btnQuoteEmail_MouseLeave);
            // 
            // btnQuoteEmail
            // 
            this.btnQuoteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnQuoteEmail.FlatAppearance.BorderSize = 0;
            this.btnQuoteEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQuoteEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQuoteEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuoteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuoteEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnQuoteEmail.Location = new System.Drawing.Point(10, 33);
            this.btnQuoteEmail.Name = "btnQuoteEmail";
            this.btnQuoteEmail.Size = new System.Drawing.Size(139, 23);
            this.btnQuoteEmail.TabIndex = 7;
            this.btnQuoteEmail.Text = "- Orçamento";
            this.btnQuoteEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuoteEmail.UseVisualStyleBackColor = false;
            this.btnQuoteEmail.Click += new System.EventHandler(this.btnQuoteEmail_Click);
            this.btnQuoteEmail.MouseEnter += new System.EventHandler(this.btnQuoteEmail_MouseEnter);
            this.btnQuoteEmail.MouseLeave += new System.EventHandler(this.btnQuoteEmail_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "     Emails";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDisplayEmailForms
            // 
            this.PanelDisplayEmailForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PanelDisplayEmailForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDisplayEmailForms.Location = new System.Drawing.Point(155, 0);
            this.PanelDisplayEmailForms.Name = "PanelDisplayEmailForms";
            this.PanelDisplayEmailForms.Size = new System.Drawing.Size(645, 450);
            this.PanelDisplayEmailForms.TabIndex = 14;
            // 
            // panelLineVertical
            // 
            this.panelLineVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panelLineVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLineVertical.Location = new System.Drawing.Point(154, 0);
            this.panelLineVertical.Name = "panelLineVertical";
            this.panelLineVertical.Size = new System.Drawing.Size(1, 450);
            this.panelLineVertical.TabIndex = 12;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDisplayEmailForms);
            this.Controls.Add(this.panel1);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelDisplayEmailForms;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCancellation;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnQuoteEmail;
        private System.Windows.Forms.Panel panelLineVertical;
    }
}