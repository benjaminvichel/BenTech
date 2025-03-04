﻿
namespace BenTech
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customTextBoxUsername = new BenTech.UserControls.customTextBox();
            this.customTextBoxPassword = new BenTech.UserControls.customTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(195)))), ((int)(((byte)(241)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConnect.Location = new System.Drawing.Point(77, 323);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(289, 42);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Enter";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.labelExit.Location = new System.Drawing.Point(203, 444);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(39, 20);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(77, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 101);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(192, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "BenTech";
            // 
            // customTextBoxUsername
            // 
            this.customTextBoxUsername.BackColor = System.Drawing.Color.White;
            this.customTextBoxUsername.changeTextBoxSize = false;
            this.customTextBoxUsername.customText = "Username";
            this.customTextBoxUsername.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.customTextBoxUsername.Location = new System.Drawing.Point(77, 136);
            this.customTextBoxUsername.Name = "customTextBoxUsername";
            this.customTextBoxUsername.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customTextBoxUsername.password = false;
            this.customTextBoxUsername.Size = new System.Drawing.Size(289, 49);
            this.customTextBoxUsername.TabIndex = 4;
            // 
            // customTextBoxPassword
            // 
            this.customTextBoxPassword.BackColor = System.Drawing.Color.White;
            this.customTextBoxPassword.changeTextBoxSize = false;
            this.customTextBoxPassword.customText = "Password";
            this.customTextBoxPassword.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.customTextBoxPassword.Location = new System.Drawing.Point(77, 212);
            this.customTextBoxPassword.Name = "customTextBoxPassword";
            this.customTextBoxPassword.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customTextBoxPassword.password = true;
            this.customTextBoxPassword.Size = new System.Drawing.Size(289, 49);
            this.customTextBoxPassword.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(434, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.customTextBoxUsername);
            this.Controls.Add(this.customTextBoxPassword);
            this.Controls.Add(this.buttonConnect);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private UserControls.customTextBox customTextBoxPassword;
        private UserControls.customTextBox customTextBoxUsername;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}

