
namespace BenTech.Forms
{
    partial class DailyPricesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPricesForm));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCalculatePrices = new System.Windows.Forms.Button();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtNumbOfDays = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnShowEmail = new FontAwesome.Sharp.IconButton();
            this.ctbTotalValueQuintuple = new BenTech.UserControls.customTextBox();
            this.ctbTotalValueQuadruple = new BenTech.UserControls.customTextBox();
            this.ctbTotalValueTriple = new BenTech.UserControls.customTextBox();
            this.ctbTotalValueSingle = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateQuintuple = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateQuadruple = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateTriple = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateSingle = new BenTech.UserControls.customTextBox();
            this.ctbTotalValueLuxuryCouple = new BenTech.UserControls.customTextBox();
            this.ctbTotalValueCouple = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateLuxuryCouple = new BenTech.UserControls.customTextBox();
            this.ctbDailyRateCouple = new BenTech.UserControls.customTextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.cbChild03To06 = new System.Windows.Forms.ComboBox();
            this.cbSingleCustom = new System.Windows.Forms.ComboBox();
            this.cbChild07To10 = new System.Windows.Forms.ComboBox();
            this.lblChild07To10 = new System.Windows.Forms.Label();
            this.lblChild03To06 = new System.Windows.Forms.Label();
            this.lblSingle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelPrices = new System.Windows.Forms.Panel();
            this.ctbTotalPriceCustom = new BenTech.UserControls.customTextBox();
            this.ctbDailyPriceCustom = new BenTech.UserControls.customTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPrices.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(655, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(406, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnCalculatePrices
            // 
            this.btnCalculatePrices.BackColor = System.Drawing.Color.White;
            this.btnCalculatePrices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnCalculatePrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatePrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnCalculatePrices.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatePrices.Image")));
            this.btnCalculatePrices.Location = new System.Drawing.Point(529, 51);
            this.btnCalculatePrices.Name = "btnCalculatePrices";
            this.btnCalculatePrices.Size = new System.Drawing.Size(223, 39);
            this.btnCalculatePrices.TabIndex = 3;
            this.btnCalculatePrices.Text = "Calculate";
            this.btnCalculatePrices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculatePrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculatePrices.UseVisualStyleBackColor = false;
            this.btnCalculatePrices.Click += new System.EventHandler(this.btnCalculatePrices_Click);
            // 
            // PanelDate
            // 
            this.PanelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PanelDate.Controls.Add(this.dateTimePicker1);
            this.PanelDate.Controls.Add(this.dateTimePicker2);
            this.PanelDate.Controls.Add(this.btnCalculatePrices);
            this.PanelDate.Controls.Add(this.lblNumberOfDays);
            this.PanelDate.Controls.Add(this.txtNumbOfDays);
            this.PanelDate.Controls.Add(this.lblDiscount);
            this.PanelDate.Controls.Add(this.txbDiscount);
            this.PanelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDate.Location = new System.Drawing.Point(0, 0);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(1168, 100);
            this.PanelDate.TabIndex = 6;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblNumberOfDays.Location = new System.Drawing.Point(20, 25);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfDays.TabIndex = 47;
            this.lblNumberOfDays.Text = "Número de diárias";
            // 
            // txtNumbOfDays
            // 
            this.txtNumbOfDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumbOfDays.Location = new System.Drawing.Point(122, 26);
            this.txtNumbOfDays.Multiline = true;
            this.txtNumbOfDays.Name = "txtNumbOfDays";
            this.txtNumbOfDays.Size = new System.Drawing.Size(37, 16);
            this.txtNumbOfDays.TabIndex = 45;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblDiscount.Location = new System.Drawing.Point(20, 68);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 13);
            this.lblDiscount.TabIndex = 48;
            this.lblDiscount.Text = "Desconto - max. 100%";
            // 
            // txbDiscount
            // 
            this.txbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiscount.Location = new System.Drawing.Point(143, 64);
            this.txbDiscount.Multiline = true;
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(90, 22);
            this.txbDiscount.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.ibtnShowEmail);
            this.panel2.Controls.Add(this.ctbTotalValueQuintuple);
            this.panel2.Controls.Add(this.ctbTotalValueQuadruple);
            this.panel2.Controls.Add(this.ctbTotalValueTriple);
            this.panel2.Controls.Add(this.ctbTotalValueSingle);
            this.panel2.Controls.Add(this.ctbDailyRateQuintuple);
            this.panel2.Controls.Add(this.ctbDailyRateQuadruple);
            this.panel2.Controls.Add(this.ctbDailyRateTriple);
            this.panel2.Controls.Add(this.ctbDailyRateSingle);
            this.panel2.Controls.Add(this.ctbTotalValueLuxuryCouple);
            this.panel2.Controls.Add(this.ctbTotalValueCouple);
            this.panel2.Controls.Add(this.ctbDailyRateLuxuryCouple);
            this.panel2.Controls.Add(this.ctbDailyRateCouple);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lblDailyPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 654);
            this.panel2.TabIndex = 7;
            // 
            // ibtnShowEmail
            // 
            this.ibtnShowEmail.BackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnShowEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnShowEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnShowEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnShowEmail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnShowEmail.IconColor = System.Drawing.Color.Black;
            this.ibtnShowEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnShowEmail.Location = new System.Drawing.Point(218, 426);
            this.ibtnShowEmail.Name = "ibtnShowEmail";
            this.ibtnShowEmail.Size = new System.Drawing.Size(223, 49);
            this.ibtnShowEmail.TabIndex = 62;
            this.ibtnShowEmail.Text = "Create Email";
            this.ibtnShowEmail.UseVisualStyleBackColor = false;
            this.ibtnShowEmail.Visible = false;
            this.ibtnShowEmail.Click += new System.EventHandler(this.ShowEmail_Click);
            this.ibtnShowEmail.MouseEnter += new System.EventHandler(this.ShowEmail_MouseEnter);
            this.ibtnShowEmail.MouseLeave += new System.EventHandler(this.ShowEmail_MouseLeave);
            // 
            // ctbTotalValueQuintuple
            // 
            this.ctbTotalValueQuintuple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueQuintuple.changeTextBoxSize = false;
            this.ctbTotalValueQuintuple.customText = "";
            this.ctbTotalValueQuintuple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueQuintuple.Location = new System.Drawing.Point(319, 309);
            this.ctbTotalValueQuintuple.Name = "ctbTotalValueQuintuple";
            this.ctbTotalValueQuintuple.password = false;
            this.ctbTotalValueQuintuple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueQuintuple.TabIndex = 61;
            // 
            // ctbTotalValueQuadruple
            // 
            this.ctbTotalValueQuadruple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueQuadruple.changeTextBoxSize = false;
            this.ctbTotalValueQuadruple.customText = "";
            this.ctbTotalValueQuadruple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueQuadruple.Location = new System.Drawing.Point(319, 254);
            this.ctbTotalValueQuadruple.Name = "ctbTotalValueQuadruple";
            this.ctbTotalValueQuadruple.password = false;
            this.ctbTotalValueQuadruple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueQuadruple.TabIndex = 60;
            // 
            // ctbTotalValueTriple
            // 
            this.ctbTotalValueTriple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueTriple.changeTextBoxSize = false;
            this.ctbTotalValueTriple.customText = "";
            this.ctbTotalValueTriple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueTriple.Location = new System.Drawing.Point(319, 196);
            this.ctbTotalValueTriple.Name = "ctbTotalValueTriple";
            this.ctbTotalValueTriple.password = false;
            this.ctbTotalValueTriple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueTriple.TabIndex = 59;
            // 
            // ctbTotalValueSingle
            // 
            this.ctbTotalValueSingle.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueSingle.changeTextBoxSize = false;
            this.ctbTotalValueSingle.customText = "";
            this.ctbTotalValueSingle.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueSingle.Location = new System.Drawing.Point(319, 141);
            this.ctbTotalValueSingle.Name = "ctbTotalValueSingle";
            this.ctbTotalValueSingle.password = false;
            this.ctbTotalValueSingle.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueSingle.TabIndex = 58;
            // 
            // ctbDailyRateQuintuple
            // 
            this.ctbDailyRateQuintuple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateQuintuple.changeTextBoxSize = true;
            this.ctbDailyRateQuintuple.customText = "Quintuplo";
            this.ctbDailyRateQuintuple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateQuintuple.Location = new System.Drawing.Point(15, 309);
            this.ctbDailyRateQuintuple.Name = "ctbDailyRateQuintuple";
            this.ctbDailyRateQuintuple.password = false;
            this.ctbDailyRateQuintuple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateQuintuple.TabIndex = 57;
            // 
            // ctbDailyRateQuadruple
            // 
            this.ctbDailyRateQuadruple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateQuadruple.changeTextBoxSize = true;
            this.ctbDailyRateQuadruple.customText = "Quadruplo";
            this.ctbDailyRateQuadruple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateQuadruple.Location = new System.Drawing.Point(15, 254);
            this.ctbDailyRateQuadruple.Name = "ctbDailyRateQuadruple";
            this.ctbDailyRateQuadruple.password = false;
            this.ctbDailyRateQuadruple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateQuadruple.TabIndex = 56;
            // 
            // ctbDailyRateTriple
            // 
            this.ctbDailyRateTriple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateTriple.changeTextBoxSize = true;
            this.ctbDailyRateTriple.customText = "Triplo";
            this.ctbDailyRateTriple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateTriple.Location = new System.Drawing.Point(15, 196);
            this.ctbDailyRateTriple.Name = "ctbDailyRateTriple";
            this.ctbDailyRateTriple.password = false;
            this.ctbDailyRateTriple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateTriple.TabIndex = 55;
            // 
            // ctbDailyRateSingle
            // 
            this.ctbDailyRateSingle.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateSingle.changeTextBoxSize = true;
            this.ctbDailyRateSingle.customText = "Solteiro";
            this.ctbDailyRateSingle.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateSingle.Location = new System.Drawing.Point(15, 141);
            this.ctbDailyRateSingle.Name = "ctbDailyRateSingle";
            this.ctbDailyRateSingle.password = false;
            this.ctbDailyRateSingle.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateSingle.TabIndex = 54;
            // 
            // ctbTotalValueLuxuryCouple
            // 
            this.ctbTotalValueLuxuryCouple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueLuxuryCouple.changeTextBoxSize = false;
            this.ctbTotalValueLuxuryCouple.customText = "";
            this.ctbTotalValueLuxuryCouple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueLuxuryCouple.Location = new System.Drawing.Point(319, 86);
            this.ctbTotalValueLuxuryCouple.Name = "ctbTotalValueLuxuryCouple";
            this.ctbTotalValueLuxuryCouple.password = false;
            this.ctbTotalValueLuxuryCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueLuxuryCouple.TabIndex = 53;
            // 
            // ctbTotalValueCouple
            // 
            this.ctbTotalValueCouple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueCouple.changeTextBoxSize = false;
            this.ctbTotalValueCouple.customText = "";
            this.ctbTotalValueCouple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalValueCouple.Location = new System.Drawing.Point(319, 31);
            this.ctbTotalValueCouple.Name = "ctbTotalValueCouple";
            this.ctbTotalValueCouple.password = false;
            this.ctbTotalValueCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueCouple.TabIndex = 52;
            // 
            // ctbDailyRateLuxuryCouple
            // 
            this.ctbDailyRateLuxuryCouple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateLuxuryCouple.changeTextBoxSize = true;
            this.ctbDailyRateLuxuryCouple.customText = "Casal Luxo";
            this.ctbDailyRateLuxuryCouple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateLuxuryCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ctbDailyRateLuxuryCouple.Location = new System.Drawing.Point(15, 86);
            this.ctbDailyRateLuxuryCouple.Name = "ctbDailyRateLuxuryCouple";
            this.ctbDailyRateLuxuryCouple.password = false;
            this.ctbDailyRateLuxuryCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateLuxuryCouple.TabIndex = 51;
            // 
            // ctbDailyRateCouple
            // 
            this.ctbDailyRateCouple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateCouple.changeTextBoxSize = true;
            this.ctbDailyRateCouple.customText = "Casal";
            this.ctbDailyRateCouple.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyRateCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ctbDailyRateCouple.Location = new System.Drawing.Point(15, 31);
            this.ctbDailyRateCouple.Name = "ctbDailyRateCouple";
            this.ctbDailyRateCouple.password = false;
            this.ctbDailyRateCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateCouple.TabIndex = 50;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(442, 7);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(69, 13);
            this.lblTotalPrice.TabIndex = 42;
            this.lblTotalPrice.Text = "Valor Total";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblDailyPrice.Location = new System.Drawing.Point(131, 7);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(40, 13);
            this.lblDailyPrice.TabIndex = 46;
            this.lblDailyPrice.Text = "Diária";
            // 
            // cbChild03To06
            // 
            this.cbChild03To06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChild03To06.FormattingEnabled = true;
            this.cbChild03To06.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbChild03To06.Location = new System.Drawing.Point(196, 55);
            this.cbChild03To06.Name = "cbChild03To06";
            this.cbChild03To06.Size = new System.Drawing.Size(73, 21);
            this.cbChild03To06.TabIndex = 26;
            // 
            // cbSingleCustom
            // 
            this.cbSingleCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSingleCustom.FormattingEnabled = true;
            this.cbSingleCustom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSingleCustom.Location = new System.Drawing.Point(51, 55);
            this.cbSingleCustom.Name = "cbSingleCustom";
            this.cbSingleCustom.Size = new System.Drawing.Size(73, 21);
            this.cbSingleCustom.TabIndex = 25;
            // 
            // cbChild07To10
            // 
            this.cbChild07To10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChild07To10.FormattingEnabled = true;
            this.cbChild07To10.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbChild07To10.Location = new System.Drawing.Point(353, 55);
            this.cbChild07To10.Name = "cbChild07To10";
            this.cbChild07To10.Size = new System.Drawing.Size(73, 21);
            this.cbChild07To10.TabIndex = 24;
            // 
            // lblChild07To10
            // 
            this.lblChild07To10.AutoSize = true;
            this.lblChild07To10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild07To10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblChild07To10.Location = new System.Drawing.Point(329, 39);
            this.lblChild07To10.Name = "lblChild07To10";
            this.lblChild07To10.Size = new System.Drawing.Size(128, 13);
            this.lblChild07To10.TabIndex = 21;
            this.lblChild07To10.Text = "Criança 07 a 10 anos";
            // 
            // lblChild03To06
            // 
            this.lblChild03To06.AutoSize = true;
            this.lblChild03To06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild03To06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblChild03To06.Location = new System.Drawing.Point(172, 39);
            this.lblChild03To06.Name = "lblChild03To06";
            this.lblChild03To06.Size = new System.Drawing.Size(128, 13);
            this.lblChild03To06.TabIndex = 20;
            this.lblChild03To06.Text = "Criança 03 a 06 anos";
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblSingle.Location = new System.Drawing.Point(59, 39);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(50, 13);
            this.lblSingle.TabIndex = 47;
            this.lblSingle.Text = "Solteiro";
            this.lblSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 1);
            this.panel4.TabIndex = 49;
            // 
            // PanelPrices
            // 
            this.PanelPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PanelPrices.Controls.Add(this.cbChild03To06);
            this.PanelPrices.Controls.Add(this.lblChild03To06);
            this.PanelPrices.Controls.Add(this.lblSingle);
            this.PanelPrices.Controls.Add(this.lblChild07To10);
            this.PanelPrices.Controls.Add(this.ctbTotalPriceCustom);
            this.PanelPrices.Controls.Add(this.cbChild07To10);
            this.PanelPrices.Controls.Add(this.ctbDailyPriceCustom);
            this.PanelPrices.Controls.Add(this.cbSingleCustom);
            this.PanelPrices.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrices.Location = new System.Drawing.Point(646, 104);
            this.PanelPrices.Name = "PanelPrices";
            this.PanelPrices.Size = new System.Drawing.Size(534, 654);
            this.PanelPrices.TabIndex = 50;
            // 
            // ctbTotalPriceCustom
            // 
            this.ctbTotalPriceCustom.BackColor = System.Drawing.Color.White;
            this.ctbTotalPriceCustom.changeTextBoxSize = true;
            this.ctbTotalPriceCustom.customText = "Total";
            this.ctbTotalPriceCustom.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbTotalPriceCustom.Location = new System.Drawing.Point(96, 155);
            this.ctbTotalPriceCustom.Name = "ctbTotalPriceCustom";
            this.ctbTotalPriceCustom.password = false;
            this.ctbTotalPriceCustom.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalPriceCustom.TabIndex = 46;
            // 
            // ctbDailyPriceCustom
            // 
            this.ctbDailyPriceCustom.BackColor = System.Drawing.Color.White;
            this.ctbDailyPriceCustom.changeTextBoxSize = true;
            this.ctbDailyPriceCustom.customText = "Diária";
            this.ctbDailyPriceCustom.CustomTextAlign = BenTech.UserControls.customTextBox.TextAlign.Left;
            this.ctbDailyPriceCustom.Location = new System.Drawing.Point(96, 100);
            this.ctbDailyPriceCustom.Name = "ctbDailyPriceCustom";
            this.ctbDailyPriceCustom.password = false;
            this.ctbDailyPriceCustom.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyPriceCustom.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(1180, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 654);
            this.panel3.TabIndex = 48;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PanelMain.Controls.Add(this.panel3);
            this.PanelMain.Controls.Add(this.PanelPrices);
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Controls.Add(this.PanelDate);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1168, 758);
            this.PanelMain.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 4);
            this.panel1.TabIndex = 51;
            // 
            // DailyPricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1168, 758);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PanelMain);
            this.MinimumSize = new System.Drawing.Size(1184, 797);
            this.Name = "DailyPricesForm";
            this.Text = "DailyPricesForm";
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelPrices.ResumeLayout(false);
            this.PanelPrices.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCalculatePrices;
        private System.Windows.Forms.Panel PanelDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.TextBox txtNumbOfDays;
        private System.Windows.Forms.ComboBox cbChild03To06;
        private System.Windows.Forms.ComboBox cbSingleCustom;
        private System.Windows.Forms.ComboBox cbChild07To10;
        private System.Windows.Forms.Label lblChild07To10;
        private System.Windows.Forms.Label lblChild03To06;
        private UserControls.customTextBox ctbTotalValueQuintuple;
        private UserControls.customTextBox ctbTotalValueQuadruple;
        private UserControls.customTextBox ctbTotalValueTriple;
        private UserControls.customTextBox ctbTotalValueSingle;
        private UserControls.customTextBox ctbDailyRateQuintuple;
        private UserControls.customTextBox ctbDailyRateQuadruple;
        private UserControls.customTextBox ctbDailyRateTriple;
        private UserControls.customTextBox ctbDailyRateSingle;
        private UserControls.customTextBox ctbTotalValueLuxuryCouple;
        private UserControls.customTextBox ctbTotalValueCouple;
        private UserControls.customTextBox ctbDailyRateLuxuryCouple;
        private UserControls.customTextBox ctbDailyRateCouple;
        private UserControls.customTextBox ctbDailyPriceCustom;
        private UserControls.customTextBox ctbTotalPriceCustom;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelPrices;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibtnShowEmail;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel1;
    }
}