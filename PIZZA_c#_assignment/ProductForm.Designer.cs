namespace PIZZA_c__assignment
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnable = new Guna.UI2.WinForms.Guna2Button();
            this.btnProupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnProDelte = new Guna.UI2.WinForms.Guna2Button();
            this.btnProsave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProFlavor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnProbrowe = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEnable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 100);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Pizza Company";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnable
            // 
            this.btnEnable.AutoRoundedCorners = true;
            this.btnEnable.BorderRadius = 18;
            this.btnEnable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnable.FillColor = System.Drawing.Color.Green;
            this.btnEnable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEnable.Location = new System.Drawing.Point(822, 30);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(204, 39);
            this.btnEnable.TabIndex = 31;
            this.btnEnable.Text = "Click here to enable ID";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnProupdate
            // 
            this.btnProupdate.AutoRoundedCorners = true;
            this.btnProupdate.BorderRadius = 18;
            this.btnProupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProupdate.FillColor = System.Drawing.Color.Green;
            this.btnProupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnProupdate.ForeColor = System.Drawing.Color.White;
            this.btnProupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProupdate.Image")));
            this.btnProupdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProupdate.Location = new System.Drawing.Point(349, 697);
            this.btnProupdate.Name = "btnProupdate";
            this.btnProupdate.Size = new System.Drawing.Size(142, 39);
            this.btnProupdate.TabIndex = 26;
            this.btnProupdate.Text = "Update";
            this.btnProupdate.Click += new System.EventHandler(this.btnProupdate_Click);
            // 
            // btnProDelte
            // 
            this.btnProDelte.AutoRoundedCorners = true;
            this.btnProDelte.BorderRadius = 18;
            this.btnProDelte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProDelte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProDelte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProDelte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProDelte.FillColor = System.Drawing.Color.Green;
            this.btnProDelte.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnProDelte.ForeColor = System.Drawing.Color.White;
            this.btnProDelte.Image = ((System.Drawing.Image)(resources.GetObject("btnProDelte.Image")));
            this.btnProDelte.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProDelte.Location = new System.Drawing.Point(627, 697);
            this.btnProDelte.Name = "btnProDelte";
            this.btnProDelte.Size = new System.Drawing.Size(142, 39);
            this.btnProDelte.TabIndex = 25;
            this.btnProDelte.Text = "Delete";
            this.btnProDelte.Click += new System.EventHandler(this.btnProDelte_Click);
            // 
            // btnProsave
            // 
            this.btnProsave.AutoRoundedCorners = true;
            this.btnProsave.BorderRadius = 18;
            this.btnProsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProsave.FillColor = System.Drawing.Color.Green;
            this.btnProsave.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnProsave.ForeColor = System.Drawing.Color.White;
            this.btnProsave.Image = ((System.Drawing.Image)(resources.GetObject("btnProsave.Image")));
            this.btnProsave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProsave.Location = new System.Drawing.Point(38, 697);
            this.btnProsave.Name = "btnProsave";
            this.btnProsave.Size = new System.Drawing.Size(142, 39);
            this.btnProsave.TabIndex = 24;
            this.btnProsave.Text = "Save";
            this.btnProsave.Click += new System.EventHandler(this.btnProsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Categaries";
            // 
            // txtProFlavor
            // 
            this.txtProFlavor.AutoRoundedCorners = true;
            this.txtProFlavor.BorderRadius = 18;
            this.txtProFlavor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProFlavor.DefaultText = "";
            this.txtProFlavor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProFlavor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProFlavor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProFlavor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProFlavor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProFlavor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtProFlavor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProFlavor.Location = new System.Drawing.Point(326, 255);
            this.txtProFlavor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProFlavor.Name = "txtProFlavor";
            this.txtProFlavor.PasswordChar = '\0';
            this.txtProFlavor.PlaceholderText = "";
            this.txtProFlavor.SelectedText = "";
            this.txtProFlavor.Size = new System.Drawing.Size(373, 39);
            this.txtProFlavor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Product Flavour";
            // 
            // txtProName
            // 
            this.txtProName.AutoRoundedCorners = true;
            this.txtProName.BorderRadius = 18;
            this.txtProName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProName.DefaultText = "";
            this.txtProName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtProName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Location = new System.Drawing.Point(326, 188);
            this.txtProName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProName.Name = "txtProName";
            this.txtProName.PasswordChar = '\0';
            this.txtProName.PlaceholderText = "";
            this.txtProName.SelectedText = "";
            this.txtProName.Size = new System.Drawing.Size(373, 39);
            this.txtProName.TabIndex = 19;
            this.txtProName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProName_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Product Name";
            // 
            // txtProId
            // 
            this.txtProId.AutoRoundedCorners = true;
            this.txtProId.BorderRadius = 18;
            this.txtProId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProId.DefaultText = "";
            this.txtProId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProId.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtProId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProId.Location = new System.Drawing.Point(326, 122);
            this.txtProId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProId.Name = "txtProId";
            this.txtProId.PasswordChar = '\0';
            this.txtProId.PlaceholderText = "";
            this.txtProId.SelectedText = "";
            this.txtProId.Size = new System.Drawing.Size(373, 39);
            this.txtProId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product ID";
            // 
            // comboCat
            // 
            this.comboCat.AutoRoundedCorners = true;
            this.comboCat.BackColor = System.Drawing.Color.Transparent;
            this.comboCat.BorderRadius = 17;
            this.comboCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCat.ItemHeight = 30;
            this.comboCat.Items.AddRange(new object[] {
            "Pizza",
            "Drink",
            "Chicken"});
            this.comboCat.Location = new System.Drawing.Point(326, 328);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(373, 36);
            this.comboCat.TabIndex = 29;
            // 
            // btnProbrowe
            // 
            this.btnProbrowe.AutoRoundedCorners = true;
            this.btnProbrowe.BorderRadius = 18;
            this.btnProbrowe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProbrowe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProbrowe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProbrowe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProbrowe.FillColor = System.Drawing.Color.Green;
            this.btnProbrowe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnProbrowe.ForeColor = System.Drawing.Color.White;
            this.btnProbrowe.Image = ((System.Drawing.Image)(resources.GetObject("btnProbrowe.Image")));
            this.btnProbrowe.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProbrowe.Location = new System.Drawing.Point(822, 335);
            this.btnProbrowe.Name = "btnProbrowe";
            this.btnProbrowe.Size = new System.Drawing.Size(158, 39);
            this.btnProbrowe.TabIndex = 31;
            this.btnProbrowe.Text = "browse";
            this.btnProbrowe.Click += new System.EventHandler(this.btnProbrowe_Click);
            // 
            // btnexit
            // 
            this.btnexit.AutoRoundedCorners = true;
            this.btnexit.BorderRadius = 18;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.Green;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnexit.Location = new System.Drawing.Point(903, 697);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(142, 39);
            this.btnexit.TabIndex = 32;
            this.btnexit.Text = "Exit";
            this.btnexit.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.flav,
            this.cat,
            this.Column1});
            this.dataGrid.Location = new System.Drawing.Point(12, 380);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 41;
            this.dataGrid.Size = new System.Drawing.Size(1033, 302);
            this.dataGrid.TabIndex = 33;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 240;
            // 
            // flav
            // 
            this.flav.HeaderText = "Flavour";
            this.flav.Name = "flav";
            this.flav.ReadOnly = true;
            this.flav.Width = 240;
            // 
            // cat
            // 
            this.cat.HeaderText = "Category";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            this.cat.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Picture";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 240;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PIZZA_c__assignment.Properties.Resources.No_Image_Available;
            this.pictureBox.Location = new System.Drawing.Point(776, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(231, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 34;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 760);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnProbrowe);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProupdate);
            this.Controls.Add(this.btnProDelte);
            this.Controls.Add(this.btnProsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProFlavor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProId);
            this.Controls.Add(this.label2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnProupdate;
        private Guna.UI2.WinForms.Guna2Button btnProDelte;
        private Guna.UI2.WinForms.Guna2Button btnProsave;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtProFlavor;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtProName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboCat;
        private Guna.UI2.WinForms.Guna2Button btnProbrowe;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn flav;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private Guna.UI2.WinForms.Guna2Button btnEnable;
    }
}