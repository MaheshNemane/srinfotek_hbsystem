namespace Hotel_Billing_Software.Transaction
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.txtItemCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTableNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gridBillDescription = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtGrandTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbWaiter = new System.Windows.Forms.ComboBox();
            this.cmbPaymentModel = new System.Windows.Forms.ComboBox();
            this.txtSubTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRelease = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMerge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSwitch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBillDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemCode
            // 
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemCode.HintForeColor = System.Drawing.Color.Empty;
            this.txtItemCode.HintText = "Item Code";
            this.txtItemCode.isPassword = false;
            this.txtItemCode.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtItemCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemCode.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtItemCode.LineThickness = 2;
            this.txtItemCode.Location = new System.Drawing.Point(10, 49);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(85, 29);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemCode.OnValueChanged += new System.EventHandler(this.txtItemCode_OnValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "Price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(7, 119);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(88, 29);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 5);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Table No.";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(119, 5);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(24, 19);
            this.lblTableNo.TabIndex = 1;
            this.lblTableNo.Text = "---";
            // 
            // txtQty
            // 
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.HintForeColor = System.Drawing.Color.Empty;
            this.txtQty.HintText = "Qty";
            this.txtQty.isPassword = false;
            this.txtQty.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtQty.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQty.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtQty.LineThickness = 2;
            this.txtQty.Location = new System.Drawing.Point(240, 85);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(126, 29);
            this.txtQty.TabIndex = 1;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gridBillDescription
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridBillDescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridBillDescription.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridBillDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBillDescription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBillDescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridBillDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBillDescription.DoubleBuffered = true;
            this.gridBillDescription.EnableHeadersVisualStyles = false;
            this.gridBillDescription.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridBillDescription.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridBillDescription.Location = new System.Drawing.Point(7, 153);
            this.gridBillDescription.Name = "gridBillDescription";
            this.gridBillDescription.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridBillDescription.Size = new System.Drawing.Size(361, 163);
            this.gridBillDescription.TabIndex = 7;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrandTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtGrandTotal.HintText = "Grand Total";
            this.txtGrandTotal.isPassword = false;
            this.txtGrandTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtGrandTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGrandTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtGrandTotal.LineThickness = 2;
            this.txtGrandTotal.Location = new System.Drawing.Point(204, 514);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(159, 29);
            this.txtGrandTotal.TabIndex = 4;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCGST
            // 
            this.txtCGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCGST.HintForeColor = System.Drawing.Color.Empty;
            this.txtCGST.HintText = "CGST";
            this.txtCGST.isPassword = false;
            this.txtCGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtCGST.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtCGST.LineThickness = 2;
            this.txtCGST.Location = new System.Drawing.Point(205, 366);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(159, 29);
            this.txtCGST.TabIndex = 4;
            this.txtCGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSGST
            // 
            this.btnSGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSGST.HintForeColor = System.Drawing.Color.Empty;
            this.btnSGST.HintText = "SGST";
            this.btnSGST.isPassword = false;
            this.btnSGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.btnSGST.LineIdleColor = System.Drawing.Color.Gray;
            this.btnSGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.btnSGST.LineThickness = 2;
            this.btnSGST.Location = new System.Drawing.Point(205, 403);
            this.btnSGST.Margin = new System.Windows.Forms.Padding(4);
            this.btnSGST.Name = "btnSGST";
            this.btnSGST.Size = new System.Drawing.Size(159, 29);
            this.btnSGST.TabIndex = 4;
            this.btnSGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtIGST
            // 
            this.txtIGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIGST.HintForeColor = System.Drawing.Color.Empty;
            this.txtIGST.HintText = "IGST";
            this.txtIGST.isPassword = false;
            this.txtIGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtIGST.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtIGST.LineThickness = 2;
            this.txtIGST.Location = new System.Drawing.Point(204, 440);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Size = new System.Drawing.Size(158, 29);
            this.txtIGST.TabIndex = 4;
            this.txtIGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.BackColor = System.Drawing.Color.Silver;
            this.cmbWaiter.FormattingEnabled = true;
            this.cmbWaiter.Location = new System.Drawing.Point(10, 374);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Size = new System.Drawing.Size(150, 21);
            this.cmbWaiter.TabIndex = 7;
            this.cmbWaiter.Text = "Waiter";
            // 
            // cmbPaymentModel
            // 
            this.cmbPaymentModel.BackColor = System.Drawing.Color.Silver;
            this.cmbPaymentModel.FormattingEnabled = true;
            this.cmbPaymentModel.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbPaymentModel.Location = new System.Drawing.Point(10, 401);
            this.cmbPaymentModel.Name = "cmbPaymentModel";
            this.cmbPaymentModel.Size = new System.Drawing.Size(150, 21);
            this.cmbPaymentModel.TabIndex = 8;
            this.cmbPaymentModel.Text = "Paymode";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtSubTotal.HintText = "Sub Total";
            this.txtSubTotal.isPassword = false;
            this.txtSubTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtSubTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSubTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtSubTotal.LineThickness = 2;
            this.txtSubTotal.Location = new System.Drawing.Point(204, 477);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(158, 29);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 356);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(372, 10);
            this.bunifuSeparator1.TabIndex = 35;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, 36);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(372, 10);
            this.bunifuSeparator2.TabIndex = 36;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.ButtonText = "    Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 50D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(187, 550);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnPrint.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(86, 32);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "    Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRelease
            // 
            this.btnRelease.Activecolor = System.Drawing.Color.Tomato;
            this.btnRelease.BackColor = System.Drawing.Color.Tomato;
            this.btnRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelease.BorderRadius = 5;
            this.btnRelease.ButtonText = "Release";
            this.btnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelease.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelease.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelease.Iconimage = global::Hotel_Billing_Software.Properties.Resources.verified;
            this.btnRelease.Iconimage_right = null;
            this.btnRelease.Iconimage_right_Selected = null;
            this.btnRelease.Iconimage_Selected = null;
            this.btnRelease.IconMarginLeft = 0;
            this.btnRelease.IconMarginRight = 0;
            this.btnRelease.IconRightVisible = true;
            this.btnRelease.IconRightZoom = 0D;
            this.btnRelease.IconVisible = true;
            this.btnRelease.IconZoom = 50D;
            this.btnRelease.IsTab = false;
            this.btnRelease.Location = new System.Drawing.Point(270, 319);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Normalcolor = System.Drawing.Color.Tomato;
            this.btnRelease.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnRelease.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelease.selected = false;
            this.btnRelease.Size = new System.Drawing.Size(99, 32);
            this.btnRelease.TabIndex = 6;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Textcolor = System.Drawing.Color.White;
            this.btnRelease.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnKot
            // 
            this.btnKot.Activecolor = System.Drawing.Color.Tomato;
            this.btnKot.BackColor = System.Drawing.Color.Tomato;
            this.btnKot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKot.BorderRadius = 5;
            this.btnKot.ButtonText = "KOT";
            this.btnKot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKot.DisabledColor = System.Drawing.Color.Gray;
            this.btnKot.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKot.Iconimage")));
            this.btnKot.Iconimage_right = null;
            this.btnKot.Iconimage_right_Selected = null;
            this.btnKot.Iconimage_Selected = null;
            this.btnKot.IconMarginLeft = 0;
            this.btnKot.IconMarginRight = 0;
            this.btnKot.IconRightVisible = true;
            this.btnKot.IconRightZoom = 0D;
            this.btnKot.IconVisible = true;
            this.btnKot.IconZoom = 90D;
            this.btnKot.IsTab = false;
            this.btnKot.Location = new System.Drawing.Point(279, 550);
            this.btnKot.Name = "btnKot";
            this.btnKot.Normalcolor = System.Drawing.Color.Tomato;
            this.btnKot.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnKot.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKot.selected = false;
            this.btnKot.Size = new System.Drawing.Size(86, 32);
            this.btnKot.TabIndex = 6;
            this.btnKot.Text = "KOT";
            this.btnKot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKot.Textcolor = System.Drawing.Color.White;
            this.btnKot.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMerge
            // 
            this.btnMerge.Activecolor = System.Drawing.Color.Tomato;
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.btnMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMerge.BorderRadius = 5;
            this.btnMerge.ButtonText = "Merge";
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.DisabledColor = System.Drawing.Color.Gray;
            this.btnMerge.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMerge.Iconimage = global::Hotel_Billing_Software.Properties.Resources.arrows_merge_pointing_to_right;
            this.btnMerge.Iconimage_right = null;
            this.btnMerge.Iconimage_right_Selected = null;
            this.btnMerge.Iconimage_Selected = null;
            this.btnMerge.IconMarginLeft = 0;
            this.btnMerge.IconMarginRight = 0;
            this.btnMerge.IconRightVisible = true;
            this.btnMerge.IconRightZoom = 0D;
            this.btnMerge.IconVisible = true;
            this.btnMerge.IconZoom = 50D;
            this.btnMerge.IsTab = false;
            this.btnMerge.Location = new System.Drawing.Point(183, 319);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.btnMerge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMerge.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMerge.selected = false;
            this.btnMerge.Size = new System.Drawing.Size(86, 32);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.Textcolor = System.Drawing.Color.White;
            this.btnMerge.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSwitch
            // 
            this.btnSwitch.Activecolor = System.Drawing.Color.Tomato;
            this.btnSwitch.BackColor = System.Drawing.Color.Orange;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.BorderRadius = 5;
            this.btnSwitch.ButtonText = "Switch";
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSwitch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSwitch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Iconimage")));
            this.btnSwitch.Iconimage_right = null;
            this.btnSwitch.Iconimage_right_Selected = null;
            this.btnSwitch.Iconimage_Selected = null;
            this.btnSwitch.IconMarginLeft = 0;
            this.btnSwitch.IconMarginRight = 0;
            this.btnSwitch.IconRightVisible = true;
            this.btnSwitch.IconRightZoom = 0D;
            this.btnSwitch.IconVisible = true;
            this.btnSwitch.IconZoom = 50D;
            this.btnSwitch.IsTab = false;
            this.btnSwitch.Location = new System.Drawing.Point(96, 319);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Normalcolor = System.Drawing.Color.Orange;
            this.btnSwitch.OnHovercolor = System.Drawing.Color.Gold;
            this.btnSwitch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSwitch.selected = false;
            this.btnSwitch.Size = new System.Drawing.Size(86, 32);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitch.Textcolor = System.Drawing.Color.White;
            this.btnSwitch.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(7, 319);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Green;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(99, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(82, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::Hotel_Billing_Software.Properties.Resources.plus;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(299, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(68, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "Total";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtTotal.LineThickness = 2;
            this.txtTotal.Location = new System.Drawing.Point(132, 119);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 29);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(240, 53);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(126, 21);
            this.cmbSubCategory.TabIndex = 54;
            this.cmbSubCategory.Text = "Select Sub Category";
            this.cmbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategory_SelectedIndexChanged_1);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(102, 53);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(126, 21);
            this.cmbCategory.TabIndex = 54;
            this.cmbCategory.Text = "Select Category";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(10, 93);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(218, 21);
            this.cmbItemName.TabIndex = 54;
            this.cmbItemName.Text = "Select Item";
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(204, 6);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(162, 21);
            this.cmbCustomerName.TabIndex = 55;
            this.cmbCustomerName.Text = "Select Customer";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 593);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSubCategory);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cmbPaymentModel);
            this.Controls.Add(this.cmbWaiter);
            this.Controls.Add(this.gridBillDescription);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnKot);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtIGST);
            this.Controls.Add(this.btnSGST);
            this.Controls.Add(this.txtCGST);
            this.Controls.Add(this.txtItemCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bill";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.gridBillDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridBillDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnKot;
        private Bunifu.Framework.UI.BunifuFlatButton btnMerge;
        private Bunifu.Framework.UI.BunifuFlatButton btnSwitch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQty;
        private System.Windows.Forms.ComboBox cmbWaiter;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelease;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGrandTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIGST;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnSGST;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCGST;
        private System.Windows.Forms.ComboBox cmbPaymentModel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSubTotal;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTableNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbCustomerName;
    }
}