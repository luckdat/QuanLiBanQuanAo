namespace Quanlibanquanao
{
    partial class warehouse
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
            this.btn = new System.Windows.Forms.TabControl();
            this.product = new System.Windows.Forms.TabPage();
            this.groupBoxProduct1 = new System.Windows.Forms.GroupBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbcolor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimageData = new System.Windows.Forms.TextBox();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtstockQuantity = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.groupboxFilter = new System.Windows.Forms.GroupBox();
            this.txtminPrice = new System.Windows.Forms.TextBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtmaxPrice = new System.Windows.Forms.TextBox();
            this.txtcategory1 = new System.Windows.Forms.TextBox();
            this.groupboxImageProduct = new System.Windows.Forms.GroupBox();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.groupboxproduct = new System.Windows.Forms.GroupBox();
            this.btnexitProduct = new System.Windows.Forms.Button();
            this.btneditproduct = new System.Windows.Forms.Button();
            this.btncreateProduct = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtproductId = new System.Windows.Forms.TextBox();
            this.btnsearchProduct = new System.Windows.Forms.Button();
            this.btndeleteProduct = new System.Windows.Forms.Button();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.orderDetails = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexitOrderDetails = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtorderDetailId = new System.Windows.Forms.TextBox();
            this.btnsearchOrderDetailId = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.dgvorderDetails = new System.Windows.Forms.DataGridView();
            this.btn.SuspendLayout();
            this.product.SuspendLayout();
            this.groupBoxProduct1.SuspendLayout();
            this.groupboxFilter.SuspendLayout();
            this.groupboxImageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupboxproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.orderDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Controls.Add(this.product);
            this.btn.Controls.Add(this.orderDetails);
            this.btn.Location = new System.Drawing.Point(3, 1);
            this.btn.Name = "btn";
            this.btn.SelectedIndex = 0;
            this.btn.Size = new System.Drawing.Size(1173, 635);
            this.btn.TabIndex = 2;
            // 
            // product
            // 
            this.product.Controls.Add(this.groupBoxProduct1);
            this.product.Controls.Add(this.groupboxFilter);
            this.product.Controls.Add(this.groupboxImageProduct);
            this.product.Controls.Add(this.groupboxproduct);
            this.product.Controls.Add(this.dgvproduct);
            this.product.Controls.Add(this.label6);
            this.product.Location = new System.Drawing.Point(4, 29);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(1165, 602);
            this.product.TabIndex = 1;
            this.product.Text = "Product";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click_1);
            // 
            // groupBoxProduct1
            // 
            this.groupBoxProduct1.Controls.Add(this.txtcategory);
            this.groupBoxProduct1.Controls.Add(this.label20);
            this.groupBoxProduct1.Controls.Add(this.label19);
            this.groupBoxProduct1.Controls.Add(this.label18);
            this.groupBoxProduct1.Controls.Add(this.btnimage);
            this.groupBoxProduct1.Controls.Add(this.label16);
            this.groupBoxProduct1.Controls.Add(this.label15);
            this.groupBoxProduct1.Controls.Add(this.cbbcolor);
            this.groupBoxProduct1.Controls.Add(this.label14);
            this.groupBoxProduct1.Controls.Add(this.txtprice);
            this.groupBoxProduct1.Controls.Add(this.label13);
            this.groupBoxProduct1.Controls.Add(this.txtimageData);
            this.groupBoxProduct1.Controls.Add(this.txtproductName);
            this.groupBoxProduct1.Controls.Add(this.txtdescription);
            this.groupBoxProduct1.Controls.Add(this.txtstockQuantity);
            this.groupBoxProduct1.Controls.Add(this.txtsize);
            this.groupBoxProduct1.Location = new System.Drawing.Point(10, 14);
            this.groupBoxProduct1.Name = "groupBoxProduct1";
            this.groupBoxProduct1.Size = new System.Drawing.Size(694, 216);
            this.groupBoxProduct1.TabIndex = 32;
            this.groupBoxProduct1.TabStop = false;
            this.groupBoxProduct1.Text = "Infomation";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(149, 78);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(178, 26);
            this.txtcategory.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 20);
            this.label20.TabIndex = 4;
            this.label20.Text = "Product Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "Category";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(361, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Price";
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(365, 172);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(75, 31);
            this.btnimage.TabIndex = 23;
            this.btnimage.Text = "Image Data";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Stock Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Size";
            // 
            // cbbcolor
            // 
            this.cbbcolor.AutoCompleteCustomSource.AddRange(new string[] {
            "Emerald Green",
            "Lavender",
            "Rose Gold",
            "Midnight Blue",
            "Coral",
            "Peach",
            "Mustard Yellow",
            "Teal",
            "Burgundy",
            "Mint Green"});
            this.cbbcolor.FormattingEnabled = true;
            this.cbbcolor.Items.AddRange(new object[] {
            "Emerald Green",
            "Lavender",
            "Rose Gold",
            "Midnight Blue",
            "Coral",
            "Peach",
            "Mustard Yellow",
            "Teal",
            "Burgundy",
            "Mint Green"});
            this.cbbcolor.Location = new System.Drawing.Point(149, 176);
            this.cbbcolor.Name = "cbbcolor";
            this.cbbcolor.Size = new System.Drawing.Size(178, 28);
            this.cbbcolor.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Description";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(495, 24);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(178, 26);
            this.txtprice.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Color";
            // 
            // txtimageData
            // 
            this.txtimageData.Location = new System.Drawing.Point(495, 174);
            this.txtimageData.Name = "txtimageData";
            this.txtimageData.Size = new System.Drawing.Size(178, 26);
            this.txtimageData.TabIndex = 17;
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(149, 28);
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(178, 26);
            this.txtproductName.TabIndex = 14;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(495, 123);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(178, 26);
            this.txtdescription.TabIndex = 17;
            // 
            // txtstockQuantity
            // 
            this.txtstockQuantity.Location = new System.Drawing.Point(495, 76);
            this.txtstockQuantity.Name = "txtstockQuantity";
            this.txtstockQuantity.Size = new System.Drawing.Size(178, 26);
            this.txtstockQuantity.TabIndex = 20;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(149, 125);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(178, 26);
            this.txtsize.TabIndex = 16;
            // 
            // groupboxFilter
            // 
            this.groupboxFilter.Controls.Add(this.txtminPrice);
            this.groupboxFilter.Controls.Add(this.btnfilter);
            this.groupboxFilter.Controls.Add(this.label21);
            this.groupboxFilter.Controls.Add(this.label12);
            this.groupboxFilter.Controls.Add(this.label22);
            this.groupboxFilter.Controls.Add(this.txtmaxPrice);
            this.groupboxFilter.Controls.Add(this.txtcategory1);
            this.groupboxFilter.Location = new System.Drawing.Point(141, 240);
            this.groupboxFilter.Name = "groupboxFilter";
            this.groupboxFilter.Size = new System.Drawing.Size(1005, 67);
            this.groupboxFilter.TabIndex = 31;
            this.groupboxFilter.TabStop = false;
            this.groupboxFilter.Text = "Product Filter";
            // 
            // txtminPrice
            // 
            this.txtminPrice.Location = new System.Drawing.Point(423, 25);
            this.txtminPrice.Name = "txtminPrice";
            this.txtminPrice.Size = new System.Drawing.Size(133, 26);
            this.txtminPrice.TabIndex = 17;
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(888, 23);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(75, 31);
            this.btnfilter.TabIndex = 30;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Min Price";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(600, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Max Price";
            // 
            // txtmaxPrice
            // 
            this.txtmaxPrice.Location = new System.Drawing.Point(695, 25);
            this.txtmaxPrice.Name = "txtmaxPrice";
            this.txtmaxPrice.Size = new System.Drawing.Size(133, 26);
            this.txtmaxPrice.TabIndex = 17;
            // 
            // txtcategory1
            // 
            this.txtcategory1.Location = new System.Drawing.Point(127, 25);
            this.txtcategory1.Name = "txtcategory1";
            this.txtcategory1.Size = new System.Drawing.Size(159, 26);
            this.txtcategory1.TabIndex = 17;
            // 
            // groupboxImageProduct
            // 
            this.groupboxImageProduct.Controls.Add(this.pictureBoxProduct);
            this.groupboxImageProduct.Location = new System.Drawing.Point(1048, 58);
            this.groupboxImageProduct.Name = "groupboxImageProduct";
            this.groupboxImageProduct.Size = new System.Drawing.Size(99, 155);
            this.groupboxImageProduct.TabIndex = 29;
            this.groupboxImageProduct.TabStop = false;
            this.groupboxImageProduct.Text = "Image";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(95, 130);
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // groupboxproduct
            // 
            this.groupboxproduct.Controls.Add(this.btnexitProduct);
            this.groupboxproduct.Controls.Add(this.btneditproduct);
            this.groupboxproduct.Controls.Add(this.btncreateProduct);
            this.groupboxproduct.Controls.Add(this.label17);
            this.groupboxproduct.Controls.Add(this.txtproductId);
            this.groupboxproduct.Controls.Add(this.btnsearchProduct);
            this.groupboxproduct.Controls.Add(this.btndeleteProduct);
            this.groupboxproduct.Location = new System.Drawing.Point(726, 58);
            this.groupboxproduct.Name = "groupboxproduct";
            this.groupboxproduct.Size = new System.Drawing.Size(316, 158);
            this.groupboxproduct.TabIndex = 28;
            this.groupboxproduct.TabStop = false;
            this.groupboxproduct.Text = "Function";
            // 
            // btnexitProduct
            // 
            this.btnexitProduct.Location = new System.Drawing.Point(224, 115);
            this.btnexitProduct.Name = "btnexitProduct";
            this.btnexitProduct.Size = new System.Drawing.Size(75, 30);
            this.btnexitProduct.TabIndex = 34;
            this.btnexitProduct.Text = "Exit";
            this.btnexitProduct.UseVisualStyleBackColor = true;
            this.btnexitProduct.Click += new System.EventHandler(this.btnexitProduct_Click);
            // 
            // btneditproduct
            // 
            this.btneditproduct.Location = new System.Drawing.Point(19, 115);
            this.btneditproduct.Name = "btneditproduct";
            this.btneditproduct.Size = new System.Drawing.Size(75, 31);
            this.btneditproduct.TabIndex = 24;
            this.btneditproduct.Text = "Edit";
            this.btneditproduct.UseVisualStyleBackColor = true;
            this.btneditproduct.Click += new System.EventHandler(this.btneditproduct_Click);
            // 
            // btncreateProduct
            // 
            this.btncreateProduct.Location = new System.Drawing.Point(46, 70);
            this.btncreateProduct.Name = "btncreateProduct";
            this.btncreateProduct.Size = new System.Drawing.Size(75, 31);
            this.btncreateProduct.TabIndex = 23;
            this.btncreateProduct.Text = "Create";
            this.btncreateProduct.UseVisualStyleBackColor = true;
            this.btncreateProduct.Click += new System.EventHandler(this.btncreateProduct_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Product Id";
            // 
            // txtproductId
            // 
            this.txtproductId.Location = new System.Drawing.Point(125, 32);
            this.txtproductId.Name = "txtproductId";
            this.txtproductId.Size = new System.Drawing.Size(156, 26);
            this.txtproductId.TabIndex = 19;
            // 
            // btnsearchProduct
            // 
            this.btnsearchProduct.Location = new System.Drawing.Point(125, 115);
            this.btnsearchProduct.Name = "btnsearchProduct";
            this.btnsearchProduct.Size = new System.Drawing.Size(75, 30);
            this.btnsearchProduct.TabIndex = 26;
            this.btnsearchProduct.Text = "Search";
            this.btnsearchProduct.UseVisualStyleBackColor = true;
            this.btnsearchProduct.Click += new System.EventHandler(this.btnsearchProduct_Click);
            // 
            // btndeleteProduct
            // 
            this.btndeleteProduct.Location = new System.Drawing.Point(160, 70);
            this.btndeleteProduct.Name = "btndeleteProduct";
            this.btndeleteProduct.Size = new System.Drawing.Size(75, 30);
            this.btndeleteProduct.TabIndex = 25;
            this.btndeleteProduct.Text = "Delete";
            this.btndeleteProduct.UseVisualStyleBackColor = true;
            this.btndeleteProduct.Click += new System.EventHandler(this.btndeleteProduct_Click);
            // 
            // dgvproduct
            // 
            this.dgvproduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(6, 328);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersWidth = 62;
            this.dgvproduct.RowTemplate.Height = 28;
            this.dgvproduct.Size = new System.Drawing.Size(1144, 267);
            this.dgvproduct.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(751, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product Management";
            // 
            // orderDetails
            // 
            this.orderDetails.Controls.Add(this.groupBox3);
            this.orderDetails.Controls.Add(this.label34);
            this.orderDetails.Controls.Add(this.dgvorderDetails);
            this.orderDetails.Location = new System.Drawing.Point(4, 29);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(1165, 602);
            this.orderDetails.TabIndex = 4;
            this.orderDetails.Text = "Order details";
            this.orderDetails.UseVisualStyleBackColor = true;
            this.orderDetails.Click += new System.EventHandler(this.orderDetails_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnexitOrderDetails);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.txtorderDetailId);
            this.groupBox3.Controls.Add(this.btnsearchOrderDetailId);
            this.groupBox3.Location = new System.Drawing.Point(240, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 73);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // btnexitOrderDetails
            // 
            this.btnexitOrderDetails.Location = new System.Drawing.Point(513, 25);
            this.btnexitOrderDetails.Name = "btnexitOrderDetails";
            this.btnexitOrderDetails.Size = new System.Drawing.Size(75, 30);
            this.btnexitOrderDetails.TabIndex = 48;
            this.btnexitOrderDetails.Text = "Exit";
            this.btnexitOrderDetails.UseVisualStyleBackColor = true;
            this.btnexitOrderDetails.Click += new System.EventHandler(this.btnexitOrderDetails_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(120, 20);
            this.label33.TabIndex = 6;
            this.label33.Text = "Order Details Id";
            // 
            // txtorderDetailId
            // 
            this.txtorderDetailId.Location = new System.Drawing.Point(155, 26);
            this.txtorderDetailId.Name = "txtorderDetailId";
            this.txtorderDetailId.Size = new System.Drawing.Size(234, 26);
            this.txtorderDetailId.TabIndex = 19;
            // 
            // btnsearchOrderDetailId
            // 
            this.btnsearchOrderDetailId.Location = new System.Drawing.Point(420, 24);
            this.btnsearchOrderDetailId.Name = "btnsearchOrderDetailId";
            this.btnsearchOrderDetailId.Size = new System.Drawing.Size(75, 31);
            this.btnsearchOrderDetailId.TabIndex = 26;
            this.btnsearchOrderDetailId.Text = "Search";
            this.btnsearchOrderDetailId.UseVisualStyleBackColor = true;
            this.btnsearchOrderDetailId.Click += new System.EventHandler(this.btnsearchOrderDetailId_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Blue;
            this.label34.Location = new System.Drawing.Point(18, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(205, 32);
            this.label34.TabIndex = 45;
            this.label34.Text = "Order Details ";
            // 
            // dgvorderDetails
            // 
            this.dgvorderDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvorderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderDetails.Location = new System.Drawing.Point(5, 104);
            this.dgvorderDetails.Name = "dgvorderDetails";
            this.dgvorderDetails.RowHeadersWidth = 62;
            this.dgvorderDetails.RowTemplate.Height = 28;
            this.dgvorderDetails.Size = new System.Drawing.Size(848, 491);
            this.dgvorderDetails.TabIndex = 30;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 636);
            this.Controls.Add(this.btn);
            this.Name = "warehouse";
            this.Text = "Home";
            this.btn.ResumeLayout(false);
            this.product.ResumeLayout(false);
            this.product.PerformLayout();
            this.groupBoxProduct1.ResumeLayout(false);
            this.groupBoxProduct1.PerformLayout();
            this.groupboxFilter.ResumeLayout(false);
            this.groupboxFilter.PerformLayout();
            this.groupboxImageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.groupboxproduct.ResumeLayout(false);
            this.groupboxproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btn;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.GroupBox groupBoxProduct1;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbcolor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimageData;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtstockQuantity;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.GroupBox groupboxFilter;
        private System.Windows.Forms.TextBox txtminPrice;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtmaxPrice;
        private System.Windows.Forms.TextBox txtcategory1;
        private System.Windows.Forms.GroupBox groupboxImageProduct;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.GroupBox groupboxproduct;
        private System.Windows.Forms.Button btnexitProduct;
        private System.Windows.Forms.Button btneditproduct;
        private System.Windows.Forms.Button btncreateProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtproductId;
        private System.Windows.Forms.Button btnsearchProduct;
        private System.Windows.Forms.Button btndeleteProduct;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage orderDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnexitOrderDetails;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtorderDetailId;
        private System.Windows.Forms.Button btnsearchOrderDetailId;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgvorderDetails;
    }
}