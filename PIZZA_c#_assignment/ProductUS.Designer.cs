using Guna.UI2.Designer;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    partial class ProductUS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUS));
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtProName = new Guna.UI2.WinForms.Guna2TextBox();
            this.uiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddcash = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.txtProPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(7, 7);
            this.picBox.Margin = new System.Windows.Forms.Padding(7);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(360, 184);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 205);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(111, 20);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Product Name";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(26, 261);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(7);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(100, 20);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Product Size";
            // 
            // txtProName
            // 
            this.txtProName.AutoRoundedCorners = true;
            this.txtProName.BorderRadius = 19;
            this.txtProName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProName.DefaultText = "";
            this.txtProName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.ForeColor = System.Drawing.Color.Black;
            this.txtProName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Location = new System.Drawing.Point(139, 196);
            this.txtProName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProName.Name = "txtProName";
            this.txtProName.PasswordChar = '\0';
            this.txtProName.PlaceholderText = "";
            this.txtProName.ReadOnly = true;
            this.txtProName.SelectedText = "";
            this.txtProName.Size = new System.Drawing.Size(202, 40);
            this.txtProName.TabIndex = 4;
            // 
            // uiComboBox
            // 
            this.uiComboBox.AutoRoundedCorners = true;
            this.uiComboBox.BackColor = System.Drawing.Color.Transparent;
            this.uiComboBox.BorderRadius = 17;
            this.uiComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uiComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uiComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiComboBox.ForeColor = System.Drawing.Color.Black;
            this.uiComboBox.ItemHeight = 30;
            this.uiComboBox.Location = new System.Drawing.Point(139, 252);
            this.uiComboBox.Name = "uiComboBox";
            this.uiComboBox.Size = new System.Drawing.Size(202, 36);
            this.uiComboBox.TabIndex = 7;
            this.uiComboBox.SelectedIndexChanged += new System.EventHandler(this.uiComboBox_SelectedIndexChanged);
            // 
            // btnAddcash
            // 
            this.btnAddcash.Animated = true;
            this.btnAddcash.AutoRoundedCorners = true;
            this.btnAddcash.BackColor = System.Drawing.Color.Transparent;
            this.btnAddcash.BorderRadius = 20;
            this.btnAddcash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddcash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddcash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddcash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddcash.FillColor = System.Drawing.Color.Green;
            this.btnAddcash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddcash.ForeColor = System.Drawing.Color.White;
            this.btnAddcash.Location = new System.Drawing.Point(190, 365);
            this.btnAddcash.Name = "btnAddcash";
            this.btnAddcash.Size = new System.Drawing.Size(158, 42);
            this.btnAddcash.TabIndex = 11;
            this.btnAddcash.Text = "Add Cash ";
            this.btnAddcash.Click += new System.EventHandler(this.btnAddcash_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddcash);
            this.guna2ShadowPanel1.Controls.Add(this.picBox);
            this.guna2ShadowPanel1.Controls.Add(this.uiComboBox);
            this.guna2ShadowPanel1.Controls.Add(this.txtProPrice);
            this.guna2ShadowPanel1.Controls.Add(this.txtProName);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(380, 436);
            this.guna2ShadowPanel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(26, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProPrice
            // 
            this.txtProPrice.AutoRoundedCorners = true;
            this.txtProPrice.BorderRadius = 17;
            this.txtProPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProPrice.DefaultText = "";
            this.txtProPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPrice.ForeColor = System.Drawing.Color.Black;
            this.txtProPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProPrice.Location = new System.Drawing.Point(139, 304);
            this.txtProPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.PasswordChar = '\0';
            this.txtProPrice.PlaceholderText = "";
            this.txtProPrice.ReadOnly = true;
            this.txtProPrice.SelectedText = "";
            this.txtProPrice.Size = new System.Drawing.Size(202, 37);
            this.txtProPrice.TabIndex = 6;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 316);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(7);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(106, 20);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Product Price";
            // 
            // ProductUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ProductUS";
            this.Size = new System.Drawing.Size(380, 436);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtProName;
        private Guna.UI2.WinForms.Guna2ComboBox uiComboBox;
        private Guna.UI2.WinForms.Guna2Button btnAddcash;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtProPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnCancel;

        public Image Picture {
            get { return picBox.Image; }
            set { picBox.Image = value; }   
        }
        public string Product_Name
        {
            get { return txtProName.Text;}
            set { txtProName.Text = value;}
        }
       public string Product_price
        {
            get { return txtProPrice.Text;} 
            set { txtProPrice.Text = value;}
        }
        public ComboBox UiComboBox { get { return uiComboBox; } }
    }
}
