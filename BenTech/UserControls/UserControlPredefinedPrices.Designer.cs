
namespace BenTech.UserControls
{
    partial class UserControlPredefinedPrices
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelColor = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelColor
            // 
            this.PanelColor.Location = new System.Drawing.Point(163, 2);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(29, 19);
            this.PanelColor.TabIndex = 0;
            this.PanelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.lblName.Location = new System.Drawing.Point(27, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDown);
            this.lblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseMove);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(18, 17);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "i";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UserControlPredefinedPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.PanelColor);
            this.Name = "UserControlPredefinedPrices";
            this.Size = new System.Drawing.Size(200, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
    }
}
