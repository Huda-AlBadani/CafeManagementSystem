namespace CafeManagementSystem.UserControls
{
    partial class uc_add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_add));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategoris = new System.Windows.Forms.Label();
            this.lblProNamw = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtProName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(356, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Product";
            this.lblTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblCategoris
            // 
            this.lblCategoris.AutoSize = true;
            this.lblCategoris.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoris.Location = new System.Drawing.Point(247, 122);
            this.lblCategoris.Name = "lblCategoris";
            this.lblCategoris.Size = new System.Drawing.Size(117, 24);
            this.lblCategoris.TabIndex = 2;
            this.lblCategoris.Text = "Categories";
            // 
            // lblProNamw
            // 
            this.lblProNamw.AutoSize = true;
            this.lblProNamw.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProNamw.Location = new System.Drawing.Point(247, 258);
            this.lblProNamw.Name = "lblProNamw";
            this.lblProNamw.Size = new System.Drawing.Size(150, 24);
            this.lblProNamw.TabIndex = 3;
            this.lblProNamw.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(247, 393);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategories.ItemHeight = 30;
            this.cmbCategories.Items.AddRange(new object[] {
            "Hot drinks",
            "Ice drinks",
            "Cheese Cake",
            "Croissant",
            "Donut",
            "Sandwich",
            "Pastries",
            "Cakes",
            "Juices"});
            this.cmbCategories.Location = new System.Drawing.Point(252, 175);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(425, 36);
            this.cmbCategories.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbCategories.TabIndex = 6;
            // 
            // txtProName
            // 
            this.txtProName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProName.DefaultText = "";
            this.txtProName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Location = new System.Drawing.Point(252, 313);
            this.txtProName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProName.Name = "txtProName";
            this.txtProName.PlaceholderText = "";
            this.txtProName.SelectedText = "";
            this.txtProName.Size = new System.Drawing.Size(426, 44);
            this.txtProName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtProName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(252, 443);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(426, 44);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 8;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(715, -23);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(196, 126);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(84)))), ((int)(((byte)(76)))));
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(84)))), ((int)(((byte)(76)))));
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(84)))), ((int)(((byte)(76)))));
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(360, 540);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProNamw);
            this.Controls.Add(this.lblCategoris);
            this.Controls.Add(this.lblTitle);
            this.Name = "uc_add";
            this.Size = new System.Drawing.Size(911, 633);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategoris;
        private System.Windows.Forms.Label lblProNamw;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategories;
        private Guna.UI2.WinForms.Guna2TextBox txtProName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
