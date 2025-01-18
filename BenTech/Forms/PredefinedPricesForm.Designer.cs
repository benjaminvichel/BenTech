
namespace BenTech.Forms
{
    partial class PredefinedPricesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredefinedPricesForm));
            this.colorDialogPredefinedPrices = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ctbName = new BenTech.UserControls.customTextBox();
            this.ctbChild07To10 = new BenTech.UserControls.customTextBox();
            this.ctbChild03To06 = new BenTech.UserControls.customTextBox();
            this.ctbQuintuple = new BenTech.UserControls.customTextBox();
            this.ctbQuadruple = new BenTech.UserControls.customTextBox();
            this.ctbTriple = new BenTech.UserControls.customTextBox();
            this.ctbSingle = new BenTech.UserControls.customTextBox();
            this.ctbCouple = new BenTech.UserControls.customTextBox();
            this.SuspendLayout();
            // 
            // colorDialogPredefinedPrices
            // 
            this.colorDialogPredefinedPrices.AllowFullOpen = false;
            this.colorDialogPredefinedPrices.SolidColorOnly = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnColor.Location = new System.Drawing.Point(383, 16);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 16;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(473, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(315, 32);
            this.panelColor.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnSave.Location = new System.Drawing.Point(414, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(713, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctbName
            // 
            this.ctbName.BackColor = System.Drawing.Color.White;
            this.ctbName.changeTextBoxSize = true;
            this.ctbName.customText = "Name";
            this.ctbName.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbName.Location = new System.Drawing.Point(12, 4);
            this.ctbName.Name = "ctbName";
            this.ctbName.password = false;
            this.ctbName.Size = new System.Drawing.Size(289, 49);
            this.ctbName.TabIndex = 34;
            // 
            // ctbChild07To10
            // 
            this.ctbChild07To10.BackColor = System.Drawing.Color.White;
            this.ctbChild07To10.changeTextBoxSize = true;
            this.ctbChild07To10.customText = "Child 07-10";
            this.ctbChild07To10.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbChild07To10.Location = new System.Drawing.Point(12, 389);
            this.ctbChild07To10.Name = "ctbChild07To10";
            this.ctbChild07To10.password = false;
            this.ctbChild07To10.Size = new System.Drawing.Size(289, 49);
            this.ctbChild07To10.TabIndex = 33;
            // 
            // ctbChild03To06
            // 
            this.ctbChild03To06.BackColor = System.Drawing.Color.White;
            this.ctbChild03To06.changeTextBoxSize = true;
            this.ctbChild03To06.customText = "Child 03-06";
            this.ctbChild03To06.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbChild03To06.Location = new System.Drawing.Point(12, 334);
            this.ctbChild03To06.Name = "ctbChild03To06";
            this.ctbChild03To06.password = false;
            this.ctbChild03To06.Size = new System.Drawing.Size(289, 49);
            this.ctbChild03To06.TabIndex = 32;
            // 
            // ctbQuintuple
            // 
            this.ctbQuintuple.BackColor = System.Drawing.Color.White;
            this.ctbQuintuple.changeTextBoxSize = true;
            this.ctbQuintuple.customText = "Quintuple";
            this.ctbQuintuple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbQuintuple.Location = new System.Drawing.Point(12, 279);
            this.ctbQuintuple.Name = "ctbQuintuple";
            this.ctbQuintuple.password = false;
            this.ctbQuintuple.Size = new System.Drawing.Size(289, 49);
            this.ctbQuintuple.TabIndex = 31;
            // 
            // ctbQuadruple
            // 
            this.ctbQuadruple.BackColor = System.Drawing.Color.White;
            this.ctbQuadruple.changeTextBoxSize = true;
            this.ctbQuadruple.customText = "Quadruple";
            this.ctbQuadruple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbQuadruple.Location = new System.Drawing.Point(12, 224);
            this.ctbQuadruple.Name = "ctbQuadruple";
            this.ctbQuadruple.password = false;
            this.ctbQuadruple.Size = new System.Drawing.Size(289, 49);
            this.ctbQuadruple.TabIndex = 30;
            // 
            // ctbTriple
            // 
            this.ctbTriple.BackColor = System.Drawing.Color.White;
            this.ctbTriple.changeTextBoxSize = true;
            this.ctbTriple.customText = "Triple";
            this.ctbTriple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTriple.Location = new System.Drawing.Point(12, 169);
            this.ctbTriple.Name = "ctbTriple";
            this.ctbTriple.password = false;
            this.ctbTriple.Size = new System.Drawing.Size(289, 49);
            this.ctbTriple.TabIndex = 29;
            // 
            // ctbSingle
            // 
            this.ctbSingle.BackColor = System.Drawing.Color.White;
            this.ctbSingle.changeTextBoxSize = true;
            this.ctbSingle.customText = "Single";
            this.ctbSingle.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbSingle.Location = new System.Drawing.Point(12, 114);
            this.ctbSingle.Name = "ctbSingle";
            this.ctbSingle.password = false;
            this.ctbSingle.Size = new System.Drawing.Size(289, 49);
            this.ctbSingle.TabIndex = 28;
            // 
            // ctbCouple
            // 
            this.ctbCouple.BackColor = System.Drawing.Color.White;
            this.ctbCouple.changeTextBoxSize = true;
            this.ctbCouple.customText = "Couple";
            this.ctbCouple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbCouple.Location = new System.Drawing.Point(12, 59);
            this.ctbCouple.Name = "ctbCouple";
            this.ctbCouple.password = false;
            this.ctbCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbCouple.TabIndex = 27;
            // 
            // PredefinedPricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctbName);
            this.Controls.Add(this.ctbChild07To10);
            this.Controls.Add(this.ctbChild03To06);
            this.Controls.Add(this.ctbQuintuple);
            this.Controls.Add(this.ctbQuadruple);
            this.Controls.Add(this.ctbTriple);
            this.Controls.Add(this.ctbSingle);
            this.Controls.Add(this.ctbCouple);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnColor);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PredefinedPricesForm";
            this.Load += new System.EventHandler(this.PredefinedPricesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogPredefinedPrices;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private UserControls.customTextBox ctbCouple;
        private UserControls.customTextBox ctbSingle;
        private UserControls.customTextBox ctbTriple;
        private UserControls.customTextBox ctbQuadruple;
        private UserControls.customTextBox ctbQuintuple;
        private UserControls.customTextBox ctbChild03To06;
        private UserControls.customTextBox ctbChild07To10;
        private UserControls.customTextBox ctbName;
    }
}