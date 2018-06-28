namespace Hotel_Billing_Software.GridPages
{
    partial class SupplierMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierMaster));
            this.elipsSupplierMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridSupplierMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewSupplier = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplierMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsSupplierMaster
            // 
            this.elipsSupplierMaster.ElipseRadius = 5;
            this.elipsSupplierMaster.TargetControl = this;
            // 
            // gridSupplierMaster
            // 
            this.gridSupplierMaster.AllowUserToAddRows = false;
            this.gridSupplierMaster.AllowUserToDeleteRows = false;
            this.gridSupplierMaster.AllowUserToResizeColumns = false;
            this.gridSupplierMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplierMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplierMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSupplierMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSupplierMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridSupplierMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplierMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSupplierMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplierMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplierMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplierMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplierMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupplierMaster.DoubleBuffered = true;
            this.gridSupplierMaster.EnableHeadersVisualStyles = false;
            this.gridSupplierMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridSupplierMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridSupplierMaster.Location = new System.Drawing.Point(0, 55);
            this.gridSupplierMaster.Name = "gridSupplierMaster";
            this.gridSupplierMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSupplierMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplierMaster.Size = new System.Drawing.Size(847, 549);
            this.gridSupplierMaster.TabIndex = 9;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewSupplier);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 8;
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
            // btnNewSupplier
            // 
            this.btnNewSupplier.ActiveBorderThickness = 1;
            this.btnNewSupplier.ActiveCornerRadius = 20;
            this.btnNewSupplier.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewSupplier.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewSupplier.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewSupplier.BackColor = System.Drawing.Color.White;
            this.btnNewSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewSupplier.BackgroundImage")));
            this.btnNewSupplier.ButtonText = "New Supplier";
            this.btnNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplier.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewSupplier.IdleBorderThickness = 1;
            this.btnNewSupplier.IdleCornerRadius = 20;
            this.btnNewSupplier.IdleFillColor = System.Drawing.Color.White;
            this.btnNewSupplier.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewSupplier.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewSupplier.Location = new System.Drawing.Point(610, 15);
            this.btnNewSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(155, 35);
            this.btnNewSupplier.TabIndex = 0;
            this.btnNewSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // SupplierMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridSupplierMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Master";
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplierMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsSupplierMaster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSupplierMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewSupplier;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}