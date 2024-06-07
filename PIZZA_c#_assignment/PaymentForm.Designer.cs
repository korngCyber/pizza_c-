namespace PIZZA_c__assignment
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btnBackMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboDis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtReturn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtRecieved = new Guna.UI2.WinForms.Guna2TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDisPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnBackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBackMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.Image")));
            this.btnBackMenu.ImageSize = new System.Drawing.Size(22, 22);
            this.btnBackMenu.Location = new System.Drawing.Point(3, 3);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(158, 33);
            this.btnBackMenu.TabIndex = 0;
            this.btnBackMenu.Text = "Back to Menu";
            this.btnBackMenu.UseTransparentBackground = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.comboType);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.comboDis);
            this.guna2ShadowPanel1.Controls.Add(this.label28);
            this.guna2ShadowPanel1.Controls.Add(this.txtReturn);
            this.guna2ShadowPanel1.Controls.Add(this.label27);
            this.guna2ShadowPanel1.Controls.Add(this.txtRecieved);
            this.guna2ShadowPanel1.Controls.Add(this.label26);
            this.guna2ShadowPanel1.Controls.Add(this.txtDisPrice);
            this.guna2ShadowPanel1.Controls.Add(this.label25);
            this.guna2ShadowPanel1.Controls.Add(this.label24);
            this.guna2ShadowPanel1.Controls.Add(this.txtAmount);
            this.guna2ShadowPanel1.Controls.Add(this.btnEnter);
            this.guna2ShadowPanel1.Controls.Add(this.label23);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Green;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(731, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(528, 721);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Order Type";
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.Transparent;
            this.comboType.BorderRadius = 8;
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboType.ForeColor = System.Drawing.Color.Black;
            this.comboType.ItemHeight = 30;
            this.comboType.Items.AddRange(new object[] {
            "Pick up",
            "Delivery"});
            this.comboType.Location = new System.Drawing.Point(41, 246);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(452, 36);
            this.comboType.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // comboDis
            // 
            this.comboDis.BackColor = System.Drawing.Color.Transparent;
            this.comboDis.BorderRadius = 8;
            this.comboDis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboDis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboDis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboDis.ForeColor = System.Drawing.Color.Black;
            this.comboDis.ItemHeight = 30;
            this.comboDis.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "90%"});
            this.comboDis.Location = new System.Drawing.Point(41, 321);
            this.comboDis.Name = "comboDis";
            this.comboDis.Size = new System.Drawing.Size(452, 36);
            this.comboDis.TabIndex = 9;
            this.comboDis.SelectedIndexChanged += new System.EventHandler(this.comboDis_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(37, 533);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 20);
            this.label28.TabIndex = 20;
            this.label28.Text = "Money Return";
            // 
            // txtReturn
            // 
            this.txtReturn.BorderRadius = 8;
            this.txtReturn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturn.DefaultText = "";
            this.txtReturn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReturn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReturn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturn.ForeColor = System.Drawing.Color.Black;
            this.txtReturn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturn.Location = new System.Drawing.Point(41, 556);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.PasswordChar = '\0';
            this.txtReturn.PlaceholderText = "";
            this.txtReturn.ReadOnly = true;
            this.txtReturn.SelectedText = "";
            this.txtReturn.Size = new System.Drawing.Size(452, 37);
            this.txtReturn.TabIndex = 19;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(37, 452);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 20);
            this.label27.TabIndex = 18;
            this.label27.Text = "Money Recieve";
            // 
            // txtRecieved
            // 
            this.txtRecieved.BorderRadius = 8;
            this.txtRecieved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecieved.DefaultText = "";
            this.txtRecieved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecieved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecieved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecieved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecieved.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecieved.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecieved.ForeColor = System.Drawing.Color.Black;
            this.txtRecieved.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecieved.Location = new System.Drawing.Point(41, 475);
            this.txtRecieved.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRecieved.Name = "txtRecieved";
            this.txtRecieved.PasswordChar = '\0';
            this.txtRecieved.PlaceholderText = "";
            this.txtRecieved.SelectedText = "";
            this.txtRecieved.Size = new System.Drawing.Size(452, 37);
            this.txtRecieved.TabIndex = 17;
            this.txtRecieved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecieved_KeyUp);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(37, 372);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 20);
            this.label26.TabIndex = 16;
            this.label26.Text = "Pay";
            // 
            // txtDisPrice
            // 
            this.txtDisPrice.BorderRadius = 8;
            this.txtDisPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisPrice.DefaultText = "";
            this.txtDisPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDisPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisPrice.ForeColor = System.Drawing.Color.Black;
            this.txtDisPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisPrice.Location = new System.Drawing.Point(41, 395);
            this.txtDisPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDisPrice.Name = "txtDisPrice";
            this.txtDisPrice.PasswordChar = '\0';
            this.txtDisPrice.PlaceholderText = "";
            this.txtDisPrice.ReadOnly = true;
            this.txtDisPrice.SelectedText = "";
            this.txtDisPrice.Size = new System.Drawing.Size(452, 37);
            this.txtDisPrice.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(37, 294);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 20);
            this.label25.TabIndex = 14;
            this.label25.Text = "Discount";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(37, 149);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 20);
            this.label24.TabIndex = 12;
            this.label24.Text = "Total Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 8;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(41, 172);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(452, 37);
            this.txtAmount.TabIndex = 11;
            // 
            // btnEnter
            // 
            this.btnEnter.BorderRadius = 20;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.FillColor = System.Drawing.Color.White;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEnter.Location = new System.Drawing.Point(27, 619);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(483, 66);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(177, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(178, 34);
            this.label23.TabIndex = 9;
            this.label23.Text = "Cash Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "You have ... item in your cart";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 722F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 146);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(722, 587);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 745);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.btnBackMenu);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBackMenu;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private Guna.UI2.WinForms.Guna2TextBox txtReturn;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2TextBox txtRecieved;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2TextBox txtDisPrice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2ComboBox comboDis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}