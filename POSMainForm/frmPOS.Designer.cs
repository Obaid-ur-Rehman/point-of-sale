namespace POSMainForm
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.txtBarcode = new POSMainForm.AutoCompleteTextboxBarcode();
            this.txtItemDesc = new POSMainForm.AutoCompleteTextbox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRePrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSettlepayment = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnNewTran = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.dgwInvoice = new System.Windows.Forms.DataGridView();
            this.sQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.ProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTtime = new System.Windows.Forms.Label();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductNo = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblVatPercent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbClearInvoice = new System.Windows.Forms.CheckBox();
            this.Panel1.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Panel11);
            this.Panel1.Controls.Add(this.Panel9);
            this.Panel1.Controls.Add(this.Panel8);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1804, 936);
            this.Panel1.TabIndex = 0;
            // 
            // Panel11
            // 
            this.Panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel11.Controls.Add(this.Panel12);
            this.Panel11.Location = new System.Drawing.Point(1429, 121);
            this.Panel11.Margin = new System.Windows.Forms.Padding(4);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(363, 79);
            this.Panel11.TabIndex = 49;
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel12.Controls.Add(this.lblInvoice);
            this.Panel12.Controls.Add(this.Label6);
            this.Panel12.Location = new System.Drawing.Point(7, 6);
            this.Panel12.Margin = new System.Windows.Forms.Padding(4);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(349, 66);
            this.Panel12.TabIndex = 0;
            // 
            // lblInvoice
            // 
            this.lblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoice.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoice.Location = new System.Drawing.Point(140, 17);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(200, 32);
            this.lblInvoice.TabIndex = 2;
            this.lblInvoice.Text = "10001000010000";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label6.Location = new System.Drawing.Point(1, 17);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(142, 34);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Invoice No :";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel9.Controls.Add(this.Panel10);
            this.Panel9.Location = new System.Drawing.Point(11, 121);
            this.Panel9.Margin = new System.Windows.Forms.Padding(4);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(1411, 79);
            this.Panel9.TabIndex = 1;
            // 
            // Panel10
            // 
            this.Panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel10.Controls.Add(this.cbClearInvoice);
            this.Panel10.Controls.Add(this.txtBarcode);
            this.Panel10.Controls.Add(this.txtItemDesc);
            this.Panel10.Controls.Add(this.Label2);
            this.Panel10.Controls.Add(this.Label10);
            this.Panel10.Controls.Add(this.txtItemCode);
            this.Panel10.Controls.Add(this.Label3);
            this.Panel10.Controls.Add(this.Label5);
            this.Panel10.Controls.Add(this.Label4);
            this.Panel10.Controls.Add(this.Label1);
            this.Panel10.Controls.Add(this.txtTotal);
            this.Panel10.Controls.Add(this.txtPrice);
            this.Panel10.Controls.Add(this.txtQuantity);
            this.Panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel10.ForeColor = System.Drawing.Color.White;
            this.Panel10.Location = new System.Drawing.Point(8, 6);
            this.Panel10.Margin = new System.Windows.Forms.Padding(4);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(1393, 66);
            this.Panel10.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("txtBarcode.AutoCompleteList")));
            this.txtBarcode.CaseSensitive = false;
            this.txtBarcode.Location = new System.Drawing.Point(12, 34);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.MinTypedCharacters = 2;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.SelectedIndex = -1;
            this.txtBarcode.Size = new System.Drawing.Size(153, 24);
            this.txtBarcode.TabIndex = 26;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("txtItemDesc.AutoCompleteList")));
            this.txtItemDesc.CaseSensitive = false;
            this.txtItemDesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDesc.Location = new System.Drawing.Point(295, 34);
            this.txtItemDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemDesc.MinTypedCharacters = 2;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.SelectedIndex = -1;
            this.txtItemDesc.Size = new System.Drawing.Size(601, 26);
            this.txtItemDesc.TabIndex = 2;
            this.txtItemDesc.TextChanged += new System.EventHandler(this.txtItemDesc_TextChanged);
            this.txtItemDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemDesc_KeyDown_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Location = new System.Drawing.Point(8, 11);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 20);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Barcode";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label10.Location = new System.Drawing.Point(171, 11);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(111, 20);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "Product Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtItemCode.Location = new System.Drawing.Point(175, 34);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(112, 26);
            this.txtItemCode.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label3.Location = new System.Drawing.Point(292, 11);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 20);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Item Description";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label5.Location = new System.Drawing.Point(1115, 14);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 20);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Total";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label4.Location = new System.Drawing.Point(909, 14);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 20);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Unit Price";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(1013, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 20);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Quantity";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotal.Location = new System.Drawing.Point(1113, 34);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 26);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(905, 34);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtQuantity.Location = new System.Drawing.Point(1011, 34);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 26);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel8.Controls.Add(this.btnAddProduct);
            this.Panel8.Controls.Add(this.btnRePrint);
            this.Panel8.Controls.Add(this.btnClose);
            this.Panel8.Controls.Add(this.btnQuantity);
            this.Panel8.Controls.Add(this.btnDiscount);
            this.Panel8.Controls.Add(this.btnSettlepayment);
            this.Panel8.Controls.Add(this.btnRemoveItem);
            this.Panel8.Controls.Add(this.btnNewTran);
            this.Panel8.Location = new System.Drawing.Point(1429, 495);
            this.Panel8.Margin = new System.Windows.Forms.Padding(4);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(364, 426);
            this.Panel8.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(193, 270);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 78);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product [F8]";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRePrint
            // 
            this.btnRePrint.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRePrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRePrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnRePrint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePrint.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePrint.Location = new System.Drawing.Point(21, 270);
            this.btnRePrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(156, 78);
            this.btnRePrint.TabIndex = 6;
            this.btnRePrint.Text = "Re-Print Invoice [F7]";
            this.btnRePrint.UseVisualStyleBackColor = false;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(193, 185);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 78);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close [F6]";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuantity
            // 
            this.btnQuantity.BackColor = System.Drawing.Color.PowderBlue;
            this.btnQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantity.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantity.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantity.Location = new System.Drawing.Point(21, 185);
            this.btnQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(156, 78);
            this.btnQuantity.TabIndex = 4;
            this.btnQuantity.Text = "Enter &Quantity [F5]";
            this.btnQuantity.UseVisualStyleBackColor = false;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(191, 100);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(156, 78);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "&Discount [F4]";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSettlepayment
            // 
            this.btnSettlepayment.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSettlepayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettlepayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettlepayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSettlepayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSettlepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlepayment.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlepayment.Location = new System.Drawing.Point(19, 100);
            this.btnSettlepayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettlepayment.Name = "btnSettlepayment";
            this.btnSettlepayment.Size = new System.Drawing.Size(156, 78);
            this.btnSettlepayment.TabIndex = 2;
            this.btnSettlepayment.Text = "&Settle Payment [F3]";
            this.btnSettlepayment.UseVisualStyleBackColor = false;
            this.btnSettlepayment.Click += new System.EventHandler(this.btnSettlepayment_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(191, 15);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(156, 78);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "&Remove Item [F2]";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnNewTran
            // 
            this.btnNewTran.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNewTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTran.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnNewTran.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTran.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTran.Location = new System.Drawing.Point(19, 15);
            this.btnNewTran.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTran.Name = "btnNewTran";
            this.btnNewTran.Size = new System.Drawing.Size(156, 78);
            this.btnNewTran.TabIndex = 0;
            this.btnNewTran.Text = "&New Transaction [F1]";
            this.btnNewTran.UseVisualStyleBackColor = false;
            this.btnNewTran.Click += new System.EventHandler(this.btnNewTran_Click);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel5.Controls.Add(this.Panel7);
            this.Panel5.Location = new System.Drawing.Point(1431, 324);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(364, 166);
            this.Panel5.TabIndex = 46;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel7.Controls.Add(this.lblTotalAmount);
            this.Panel7.Controls.Add(this.lblSubTotal);
            this.Panel7.Controls.Add(this.Label20);
            this.Panel7.Controls.Add(this.lblVAT);
            this.Panel7.Controls.Add(this.lblTotalItems);
            this.Panel7.Controls.Add(this.Label22);
            this.Panel7.Controls.Add(this.Label17);
            this.Panel7.Controls.Add(this.Label18);
            this.Panel7.Controls.Add(this.Label19);
            this.Panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Panel7.Location = new System.Drawing.Point(8, 10);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(349, 148);
            this.Panel7.TabIndex = 0;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(148, 107);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(190, 36);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(180, 79);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(157, 24);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(4, 117);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(132, 20);
            this.Label20.TabIndex = 9;
            this.Label20.Text = "Total Amount :";
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(180, 50);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(157, 24);
            this.lblVAT.TabIndex = 11;
            this.lblVAT.Text = "0.00";
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(180, 22);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(157, 24);
            this.lblTotalItems.TabIndex = 11;
            this.lblTotalItems.Text = "0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(16, 54);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(44, 20);
            this.Label22.TabIndex = 8;
            this.Label22.Text = "Vat :";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(16, 81);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(90, 20);
            this.Label17.TabIndex = 9;
            this.Label17.Text = "Sub Total :";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(15, 30);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(102, 20);
            this.Label18.TabIndex = 8;
            this.Label18.Text = "Total Items :";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(7, 4);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(167, 20);
            this.Label19.TabIndex = 7;
            this.Label19.Text = "Basket Information";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel3.Controls.Add(this.Panel6);
            this.Panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel3.Location = new System.Drawing.Point(1429, 204);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(364, 114);
            this.Panel3.TabIndex = 46;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel6.Controls.Add(this.lblCustName);
            this.Panel6.Controls.Add(this.lblPosition);
            this.Panel6.Controls.Add(this.Label9);
            this.Panel6.Controls.Add(this.Label8);
            this.Panel6.Controls.Add(this.Label7);
            this.Panel6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Panel6.Location = new System.Drawing.Point(7, 6);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(351, 102);
            this.Panel6.TabIndex = 0;
            // 
            // lblCustName
            // 
            this.lblCustName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(151, 62);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(189, 24);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "GATSAN Technologies";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(151, 32);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(189, 24);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "ADMIN";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(13, 66);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(63, 20);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Name :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(13, 37);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(79, 20);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Position :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(8, 11);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(149, 20);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Staff Information";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel4.Controls.Add(this.dgwInvoice);
            this.Panel4.Controls.Add(this.dgw);
            this.Panel4.Location = new System.Drawing.Point(12, 204);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1409, 716);
            this.Panel4.TabIndex = 43;
            // 
            // dgwInvoice
            // 
            this.dgwInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgwInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sQuantity,
            this.sPrice});
            this.dgwInvoice.GridColor = System.Drawing.Color.White;
            this.dgwInvoice.Location = new System.Drawing.Point(1031, 305);
            this.dgwInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dgwInvoice.Name = "dgwInvoice";
            this.dgwInvoice.RowHeadersVisible = false;
            this.dgwInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInvoice.Size = new System.Drawing.Size(369, 399);
            this.dgwInvoice.TabIndex = 44;
            this.dgwInvoice.DoubleClick += new System.EventHandler(this.dgwInvoice_DoubleClick);
            // 
            // sQuantity
            // 
            this.sQuantity.HeaderText = "Date";
            this.sQuantity.Name = "sQuantity";
            // 
            // sPrice
            // 
            this.sPrice.HeaderText = "Invoice No";
            this.sPrice.Name = "sPrice";
            this.sPrice.Width = 150;
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.ColumnHeadersHeight = 24;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNo,
            this.ItemCode,
            this.ProdName,
            this.UnitPrice,
            this.Quantity,
            this.Total,
            this.Discount});
            this.dgw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.White;
            this.dgw.Location = new System.Drawing.Point(11, 9);
            this.dgw.Margin = new System.Windows.Forms.Padding(4);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw.RowHeadersVisible = false;
            this.dgw.RowHeadersWidth = 25;
            this.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw.RowTemplate.Height = 18;
            this.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1389, 695);
            this.dgw.TabIndex = 42;
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            this.dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellDoubleClick);
            // 
            // ProductNo
            // 
            this.ProductNo.HeaderText = "Product No";
            this.ProductNo.Name = "ProductNo";
            this.ProductNo.ReadOnly = true;
            this.ProductNo.Visible = false;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 120;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Item Description";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 550;
            // 
            // UnitPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 85;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 75;
            // 
            // Total
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Discount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 80;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.lblDiscount);
            this.Panel2.Controls.Add(this.lblTtime);
            this.Panel2.Controls.Add(this.Panel13);
            this.Panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.Location = new System.Drawing.Point(9, 9);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1783, 106);
            this.Panel2.TabIndex = 0;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDiscount.Location = new System.Drawing.Point(973, 16);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(0, 17);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Visible = false;
            // 
            // lblTtime
            // 
            this.lblTtime.BackColor = System.Drawing.Color.White;
            this.lblTtime.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtime.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTtime.Location = new System.Drawing.Point(1399, 12);
            this.lblTtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtime.Name = "lblTtime";
            this.lblTtime.Size = new System.Drawing.Size(108, 26);
            this.lblTtime.TabIndex = 2;
            this.lblTtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel13
            // 
            this.Panel13.BackColor = System.Drawing.Color.White;
            this.Panel13.Controls.Add(this.label13);
            this.Panel13.Controls.Add(this.label12);
            this.Panel13.Controls.Add(this.lblTime);
            this.Panel13.Controls.Add(this.label14);
            this.Panel13.Controls.Add(this.lblTitle);
            this.Panel13.Controls.Add(this.lblDate);
            this.Panel13.Controls.Add(this.lblDay);
            this.Panel13.Controls.Add(this.label11);
            this.Panel13.Controls.Add(this.Label24);
            this.Panel13.Controls.Add(this.lblPrice);
            this.Panel13.Controls.Add(this.lblProductNo);
            this.Panel13.Controls.Add(this.lblStaffID);
            this.Panel13.Controls.Add(this.lblVatPercent);
            this.Panel13.Location = new System.Drawing.Point(9, 6);
            this.Panel13.Margin = new System.Windows.Forms.Padding(4);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(1767, 92);
            this.Panel13.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Goudy Old Style", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(1202, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 43);
            this.label13.TabIndex = 53;
            this.label13.Text = "www.gatsan.com";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Goudy Old Style", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(55, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 43);
            this.label12.TabIndex = 52;
            this.label12.Text = "03038170020";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1628, 48);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 23);
            this.lblTime.TabIndex = 51;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1549, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Time :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(405, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(649, 75);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GATSAN Inventory System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1628, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(131, 23);
            this.lblDate.TabIndex = 9;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDay.Location = new System.Drawing.Point(639, 20);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(157, 39);
            this.lblDay.TabIndex = 2;
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1549, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Date :";
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Label24.Location = new System.Drawing.Point(700, 4);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(95, 26);
            this.Label24.TabIndex = 2;
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(760, 63);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 14);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Visible = false;
            // 
            // lblProductNo
            // 
            this.lblProductNo.BackColor = System.Drawing.Color.Transparent;
            this.lblProductNo.Location = new System.Drawing.Point(640, 63);
            this.lblProductNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(72, 14);
            this.lblProductNo.TabIndex = 21;
            this.lblProductNo.Visible = false;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.Location = new System.Drawing.Point(640, 39);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(16, 17);
            this.lblStaffID.TabIndex = 20;
            this.lblStaffID.Text = "1";
            this.lblStaffID.Visible = false;
            // 
            // lblVatPercent
            // 
            this.lblVatPercent.AutoSize = true;
            this.lblVatPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblVatPercent.Location = new System.Drawing.Point(639, 20);
            this.lblVatPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatPercent.Name = "lblVatPercent";
            this.lblVatPercent.Size = new System.Drawing.Size(35, 17);
            this.lblVatPercent.TabIndex = 19;
            this.lblVatPercent.Text = "VAT";
            this.lblVatPercent.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbClearInvoice
            // 
            this.cbClearInvoice.AutoSize = true;
            this.cbClearInvoice.ForeColor = System.Drawing.Color.Black;
            this.cbClearInvoice.Location = new System.Drawing.Point(1266, 34);
            this.cbClearInvoice.Name = "cbClearInvoice";
            this.cbClearInvoice.Size = new System.Drawing.Size(115, 22);
            this.cbClearInvoice.TabIndex = 27;
            this.cbClearInvoice.Text = "Clear invoice";
            this.cbClearInvoice.UseVisualStyleBackColor = true;
            this.cbClearInvoice.CheckedChanged += new System.EventHandler(this.cbClearInvoice_CheckedChanged);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1804, 936);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            this.Panel1.ResumeLayout(false);
            this.Panel11.ResumeLayout(false);
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel13.ResumeLayout(false);
            this.Panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel11;
        internal System.Windows.Forms.Panel Panel12;
        internal System.Windows.Forms.Label lblInvoice;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel9;
        internal System.Windows.Forms.Panel Panel10;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtItemCode;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.Label lblTotalAmount;
        internal System.Windows.Forms.Label lblSubTotal;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label lblVAT;
        internal System.Windows.Forms.Label lblTotalItems;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Label lblCustName;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.DataGridView dgw;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lblDiscount;
        internal System.Windows.Forms.Label lblTtime;
        internal System.Windows.Forms.Panel Panel13;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblDay;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblProductNo;
        internal System.Windows.Forms.Label lblStaffID;
        internal System.Windows.Forms.Label lblVatPercent;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnSettlepayment;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnNewTran;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Button btnRePrint;
        internal System.Windows.Forms.DataGridView dgwInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPrice;
        private AutoCompleteTextbox txtItemDesc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddProduct;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label label11;
        private AutoCompleteTextboxBarcode txtBarcode;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbClearInvoice;
    }
}