namespace Hotel_Billing_Software.Transaction
{
    partial class HotelExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelExpenses));
            this.elipHotelExpenses = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LblHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtBankName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbPayMode = new System.Windows.Forms.ComboBox();
            this.txtChaqueNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpChequeDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cmbSubExpensesCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeading.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipHotelExpenses
            // 
            this.elipHotelExpenses.ElipseRadius = 25;
            this.elipHotelExpenses.TargetControl = this;
            // 
            // pnlHeading
            // 
            this.pnlHeading.Controls.Add(this.bunifuSeparator1);
            this.pnlHeading.Controls.Add(this.LblHeading);
            this.pnlHeading.Controls.Add(this.btnClose);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(500, 41);
            this.pnlHeading.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 29);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(494, 11);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(12, 9);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(106, 17);
            this.LblHeading.TabIndex = 6;
            this.LblHeading.Text = "Hotel Expenses ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(462, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dtpDate);
            this.pnlBody.Controls.Add(this.txtNote);
            this.pnlBody.Controls.Add(this.TxtBankName);
            this.pnlBody.Controls.Add(this.cmbPayMode);
            this.pnlBody.Controls.Add(this.txtChaqueNo);
            this.pnlBody.Controls.Add(this.dtpChequeDate);
            this.pnlBody.Controls.Add(this.cmbSubExpensesCategory);
            this.pnlBody.Controls.Add(this.txtAmount);
            this.pnlBody.Controls.Add(this.cmbExpenseCategory);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 41);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(500, 254);
            this.pnlBody.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Silver;
            this.dtpDate.BorderRadius = 0;
            this.dtpDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.FormatCustom = "dd/MM/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(36, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(192, 23);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2018, 6, 20, 15, 57, 29, 137);
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.HintForeColor = System.Drawing.Color.Empty;
            this.txtNote.HintText = "Note";
            this.txtNote.isPassword = false;
            this.txtNote.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtNote.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNote.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtNote.LineThickness = 2;
            this.txtNote.Location = new System.Drawing.Point(272, 86);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(192, 29);
            this.txtNote.TabIndex = 4;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtBankName
            // 
            this.TxtBankName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBankName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBankName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBankName.HintText = "Bank Name";
            this.TxtBankName.isPassword = false;
            this.TxtBankName.LineFocusedColor = System.Drawing.Color.Tomato;
            this.TxtBankName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBankName.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.TxtBankName.LineThickness = 2;
            this.TxtBankName.Location = new System.Drawing.Point(272, 123);
            this.TxtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBankName.Name = "TxtBankName";
            this.TxtBankName.Size = new System.Drawing.Size(192, 29);
            this.TxtBankName.TabIndex = 6;
            this.TxtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBankName.Visible = false;
            // 
            // cmbPayMode
            // 
            this.cmbPayMode.BackColor = System.Drawing.Color.Silver;
            this.cmbPayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPayMode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayMode.ForeColor = System.Drawing.Color.Black;
            this.cmbPayMode.FormatString = "Select";
            this.cmbPayMode.FormattingEnabled = true;
            this.cmbPayMode.Location = new System.Drawing.Point(35, 129);
            this.cmbPayMode.MaxDropDownItems = 5;
            this.cmbPayMode.Name = "cmbPayMode";
            this.cmbPayMode.Size = new System.Drawing.Size(192, 23);
            this.cmbPayMode.Sorted = true;
            this.cmbPayMode.TabIndex = 5;
            this.cmbPayMode.Text = "Select Payment Mode ";
            // 
            // txtChaqueNo
            // 
            this.txtChaqueNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChaqueNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChaqueNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChaqueNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtChaqueNo.HintText = "Chaque No";
            this.txtChaqueNo.isPassword = false;
            this.txtChaqueNo.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtChaqueNo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtChaqueNo.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtChaqueNo.LineThickness = 2;
            this.txtChaqueNo.Location = new System.Drawing.Point(35, 159);
            this.txtChaqueNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtChaqueNo.Name = "txtChaqueNo";
            this.txtChaqueNo.Size = new System.Drawing.Size(192, 29);
            this.txtChaqueNo.TabIndex = 7;
            this.txtChaqueNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChaqueNo.Visible = false;
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.BackColor = System.Drawing.Color.Silver;
            this.dtpChequeDate.BorderRadius = 0;
            this.dtpChequeDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChequeDate.ForeColor = System.Drawing.Color.Black;
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChequeDate.FormatCustom = null;
            this.dtpChequeDate.Location = new System.Drawing.Point(272, 159);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(192, 29);
            this.dtpChequeDate.TabIndex = 8;
            this.dtpChequeDate.Value = new System.DateTime(2018, 6, 20, 15, 57, 29, 137);
            this.dtpChequeDate.Visible = false;
            // 
            // cmbSubExpensesCategory
            // 
            this.cmbSubExpensesCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbSubExpensesCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubExpensesCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubExpensesCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbSubExpensesCategory.FormatString = "Select";
            this.cmbSubExpensesCategory.FormattingEnabled = true;
            this.cmbSubExpensesCategory.Location = new System.Drawing.Point(272, 56);
            this.cmbSubExpensesCategory.MaxDropDownItems = 5;
            this.cmbSubExpensesCategory.Name = "cmbSubExpensesCategory";
            this.cmbSubExpensesCategory.Size = new System.Drawing.Size(192, 23);
            this.cmbSubExpensesCategory.TabIndex = 2;
            this.cmbSubExpensesCategory.Text = "Select Sub Expense Type";
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmount.HintText = "Amount";
            this.txtAmount.isPassword = false;
            this.txtAmount.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAmount.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtAmount.LineThickness = 2;
            this.txtAmount.Location = new System.Drawing.Point(35, 86);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(192, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbExpenseCategory
            // 
            this.cmbExpenseCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbExpenseCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExpenseCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbExpenseCategory.FormatString = "Select";
            this.cmbExpenseCategory.FormattingEnabled = true;
            this.cmbExpenseCategory.Location = new System.Drawing.Point(35, 56);
            this.cmbExpenseCategory.MaxDropDownItems = 5;
            this.cmbExpenseCategory.Name = "cmbExpenseCategory";
            this.cmbExpenseCategory.Size = new System.Drawing.Size(192, 23);
            this.cmbExpenseCategory.TabIndex = 1;
            this.cmbExpenseCategory.Text = "Select Expense Type";
            this.cmbExpenseCategory.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseCategory_SelectedIndexChanged);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.bunifuSeparator2);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnRemove);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 243);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(500, 52);
            this.pnlFooter.TabIndex = 2;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(2, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(494, 10);
            this.bunifuSeparator2.TabIndex = 19;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Orange;
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(389, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Orange;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.BorderRadius = 5;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemove.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRemove.Iconimage")));
            this.btnRemove.Iconimage_right = null;
            this.btnRemove.Iconimage_right_Selected = null;
            this.btnRemove.Iconimage_Selected = null;
            this.btnRemove.IconMarginLeft = 0;
            this.btnRemove.IconMarginRight = 0;
            this.btnRemove.IconRightVisible = true;
            this.btnRemove.IconRightZoom = 0D;
            this.btnRemove.IconVisible = true;
            this.btnRemove.IconZoom = 50D;
            this.btnRemove.IsTab = false;
            this.btnRemove.Location = new System.Drawing.Point(275, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(106, 32);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Textcolor = System.Drawing.Color.White;
            this.btnRemove.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.IconZoom = 40D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(183, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HotelExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 295);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Expenses";
            this.Load += new System.EventHandler(this.HotelExpenses_Load);
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipHotelExpenses;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeading;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeading;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNote;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBankName;
        private System.Windows.Forms.ComboBox cmbPayMode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChaqueNo;
        private Bunifu.Framework.UI.BunifuDatepicker dtpChequeDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmount;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.ComboBox cmbSubExpensesCategory;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemove;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}