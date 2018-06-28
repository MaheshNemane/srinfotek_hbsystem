﻿namespace Hotel_Billing_Software
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.ElipseExpenses = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChaqueDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtBankName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtChaqueNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cmbSubExpenseType = new System.Windows.Forms.ComboBox();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LblHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sepratorFooter = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseExpenses
            // 
            this.ElipseExpenses.ElipseRadius = 25;
            this.ElipseExpenses.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.ChaqueDate);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.TxtBankName);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.txtChaqueNo);
            this.panel1.Controls.Add(this.bunifuDatepicker1);
            this.panel1.Controls.Add(this.cmbSubExpenseType);
            this.panel1.Controls.Add(this.cmbExpenseType);
            this.panel1.Controls.Add(this.comboBoxEmployeeId);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 280);
            this.panel1.TabIndex = 4;
            // 
            // ChaqueDate
            // 
            this.ChaqueDate.BackColor = System.Drawing.Color.Silver;
            this.ChaqueDate.BorderRadius = 0;
            this.ChaqueDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaqueDate.ForeColor = System.Drawing.Color.Black;
            this.ChaqueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ChaqueDate.FormatCustom = null;
            this.ChaqueDate.Location = new System.Drawing.Point(261, 189);
            this.ChaqueDate.Name = "ChaqueDate";
            this.ChaqueDate.Size = new System.Drawing.Size(204, 29);
            this.ChaqueDate.TabIndex = 25;
            this.ChaqueDate.Value = new System.DateTime(2018, 6, 20, 15, 57, 29, 137);
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
            this.txtNote.Location = new System.Drawing.Point(261, 116);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(204, 29);
            this.txtNote.TabIndex = 24;
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
            this.TxtBankName.Location = new System.Drawing.Point(261, 153);
            this.TxtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBankName.Name = "TxtBankName";
            this.TxtBankName.Size = new System.Drawing.Size(204, 29);
            this.TxtBankName.TabIndex = 23;
            this.TxtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Silver;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormatString = "Select";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 156);
            this.comboBox2.MaxDropDownItems = 5;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 23);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Text = "Select Payment Mode ";
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
            this.txtChaqueNo.Location = new System.Drawing.Point(36, 189);
            this.txtChaqueNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtChaqueNo.Name = "txtChaqueNo";
            this.txtChaqueNo.Size = new System.Drawing.Size(204, 29);
            this.txtChaqueNo.TabIndex = 21;
            this.txtChaqueNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Silver;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(36, 46);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(204, 30);
            this.bunifuDatepicker1.TabIndex = 20;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 6, 20, 15, 57, 29, 137);
            // 
            // cmbSubExpenseType
            // 
            this.cmbSubExpenseType.BackColor = System.Drawing.Color.Silver;
            this.cmbSubExpenseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubExpenseType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubExpenseType.ForeColor = System.Drawing.Color.Black;
            this.cmbSubExpenseType.FormatString = "Select";
            this.cmbSubExpenseType.FormattingEnabled = true;
            this.cmbSubExpenseType.Location = new System.Drawing.Point(261, 86);
            this.cmbSubExpenseType.MaxDropDownItems = 5;
            this.cmbSubExpenseType.Name = "cmbSubExpenseType";
            this.cmbSubExpenseType.Size = new System.Drawing.Size(204, 23);
            this.cmbSubExpenseType.Sorted = true;
            this.cmbSubExpenseType.TabIndex = 17;
            this.cmbSubExpenseType.Text = "Select Sub Expense Type";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.BackColor = System.Drawing.Color.Silver;
            this.cmbExpenseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExpenseType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseType.ForeColor = System.Drawing.Color.Black;
            this.cmbExpenseType.FormatString = "Select";
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(36, 86);
            this.cmbExpenseType.MaxDropDownItems = 5;
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(204, 23);
            this.cmbExpenseType.Sorted = true;
            this.cmbExpenseType.TabIndex = 18;
            this.cmbExpenseType.Text = "Select Expense Type";
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.BackColor = System.Drawing.Color.Silver;
            this.comboBoxEmployeeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployeeId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEmployeeId.FormatString = "Select";
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(261, 50);
            this.comboBoxEmployeeId.MaxDropDownItems = 5;
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(204, 23);
            this.comboBoxEmployeeId.Sorted = true;
            this.comboBoxEmployeeId.TabIndex = 19;
            this.comboBoxEmployeeId.Text = "Select Employee";
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
            this.txtAmount.Location = new System.Drawing.Point(36, 116);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(204, 29);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.LblHeading);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 40);
            this.panel2.TabIndex = 5;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 27);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 11);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(12, 7);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(117, 17);
            this.LblHeading.TabIndex = 6;
            this.LblHeading.Text = "Labour Expenses ";
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
            this.btnClose.Location = new System.Drawing.Point(468, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.sepratorFooter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 52);
            this.panel3.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(395, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Orange;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRemove.Location = new System.Drawing.Point(281, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(106, 32);
            this.btnRemove.TabIndex = 18;
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
            this.btnSave.Location = new System.Drawing.Point(189, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sepratorFooter
            // 
            this.sepratorFooter.BackColor = System.Drawing.Color.Transparent;
            this.sepratorFooter.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sepratorFooter.LineThickness = 1;
            this.sepratorFooter.Location = new System.Drawing.Point(0, 4);
            this.sepratorFooter.Name = "sepratorFooter";
            this.sepratorFooter.Size = new System.Drawing.Size(500, 11);
            this.sepratorFooter.TabIndex = 16;
            this.sepratorFooter.Transparency = 255;
            this.sepratorFooter.Vertical = false;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseExpenses;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker ChaqueDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNote;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBankName;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChaqueNo;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.ComboBox cmbSubExpenseType;
        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmount;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemove;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuSeparator sepratorFooter;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeading;
        private System.Windows.Forms.Button btnClose;
    }
}