﻿namespace Hotel_Billing_Software.GridPages
{
    partial class EmployeeMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnRemoveEmployee = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditEmployee = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewEmployee = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gridEmployeeMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveEmployee);
            this.pnlHeadingButtons.Controls.Add(this.btnEditEmployee);
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewEmployee);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 3;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.ActiveBorderThickness = 1;
            this.btnRemoveEmployee.ActiveCornerRadius = 20;
            this.btnRemoveEmployee.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveEmployee.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveEmployee.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.White;
            this.btnRemoveEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveEmployee.BackgroundImage")));
            this.btnRemoveEmployee.ButtonText = "Remove Employee";
            this.btnRemoveEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveEmployee.IdleBorderThickness = 1;
            this.btnRemoveEmployee.IdleCornerRadius = 20;
            this.btnRemoveEmployee.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveEmployee.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveEmployee.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(677, 12);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(155, 35);
            this.btnRemoveEmployee.TabIndex = 3;
            this.btnRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.ActiveBorderThickness = 1;
            this.btnEditEmployee.ActiveCornerRadius = 20;
            this.btnEditEmployee.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditEmployee.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditEmployee.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditEmployee.BackColor = System.Drawing.Color.White;
            this.btnEditEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.BackgroundImage")));
            this.btnEditEmployee.ButtonText = "Edit Employee";
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditEmployee.IdleBorderThickness = 1;
            this.btnEditEmployee.IdleCornerRadius = 20;
            this.btnEditEmployee.IdleFillColor = System.Drawing.Color.White;
            this.btnEditEmployee.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditEmployee.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditEmployee.Location = new System.Drawing.Point(512, 12);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(155, 35);
            this.btnEditEmployee.TabIndex = 4;
            this.btnEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(847, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.ActiveBorderThickness = 1;
            this.btnNewEmployee.ActiveCornerRadius = 20;
            this.btnNewEmployee.ActiveFillColor = System.Drawing.Color.White;
            this.btnNewEmployee.ActiveForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewEmployee.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewEmployee.BackColor = System.Drawing.Color.White;
            this.btnNewEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewEmployee.BackgroundImage")));
            this.btnNewEmployee.ButtonText = "New Employee";
            this.btnNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewEmployee.IdleBorderThickness = 1;
            this.btnNewEmployee.IdleCornerRadius = 20;
            this.btnNewEmployee.IdleFillColor = System.Drawing.Color.White;
            this.btnNewEmployee.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewEmployee.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewEmployee.Location = new System.Drawing.Point(347, 12);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(155, 35);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // gridEmployeeMaster
            // 
            this.gridEmployeeMaster.AllowUserToAddRows = false;
            this.gridEmployeeMaster.AllowUserToDeleteRows = false;
            this.gridEmployeeMaster.AllowUserToOrderColumns = true;
            this.gridEmployeeMaster.AllowUserToResizeColumns = false;
            this.gridEmployeeMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployeeMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmployeeMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployeeMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridEmployeeMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridEmployeeMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployeeMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEmployeeMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployeeMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployeeMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployeeMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmployeeMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployeeMaster.DoubleBuffered = true;
            this.gridEmployeeMaster.EnableHeadersVisualStyles = false;
            this.gridEmployeeMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridEmployeeMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridEmployeeMaster.Location = new System.Drawing.Point(0, 55);
            this.gridEmployeeMaster.Name = "gridEmployeeMaster";
            this.gridEmployeeMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmployeeMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployeeMaster.Size = new System.Drawing.Size(847, 549);
            this.gridEmployeeMaster.TabIndex = 4;
            // 
            // EmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridEmployeeMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Master";
            this.pnlHeadingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewEmployee;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridEmployeeMaster;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveEmployee;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditEmployee;
    }
}