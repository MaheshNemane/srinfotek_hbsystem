namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    partial class ProductMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMaster));
            this.elipsProductMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridProductMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnRemoveProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsProductMaster
            // 
            this.elipsProductMaster.ElipseRadius = 5;
            this.elipsProductMaster.TargetControl = this;
            // 
            // gridProductMaster
            // 
            this.gridProductMaster.AllowUserToAddRows = false;
            this.gridProductMaster.AllowUserToDeleteRows = false;
            this.gridProductMaster.AllowUserToOrderColumns = true;
            this.gridProductMaster.AllowUserToResizeColumns = false;
            this.gridProductMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridProductMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridProductMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductMaster.DoubleBuffered = true;
            this.gridProductMaster.EnableHeadersVisualStyles = false;
            this.gridProductMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridProductMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridProductMaster.Location = new System.Drawing.Point(0, 55);
            this.gridProductMaster.Name = "gridProductMaster";
            this.gridProductMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridProductMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductMaster.Size = new System.Drawing.Size(847, 549);
            this.gridProductMaster.TabIndex = 7;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveProduct);
            this.pnlHeadingButtons.Controls.Add(this.btnEditProduct);
            this.pnlHeadingButtons.Controls.Add(this.btnNewProduct);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 6;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.ActiveBorderThickness = 1;
            this.btnRemoveProduct.ActiveCornerRadius = 20;
            this.btnRemoveProduct.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveProduct.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.White;
            this.btnRemoveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.BackgroundImage")));
            this.btnRemoveProduct.ButtonText = "Remove Product";
            this.btnRemoveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveProduct.IdleBorderThickness = 1;
            this.btnRemoveProduct.IdleCornerRadius = 20;
            this.btnRemoveProduct.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveProduct.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveProduct.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveProduct.Location = new System.Drawing.Point(686, 12);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(155, 35);
            this.btnRemoveProduct.TabIndex = 0;
            this.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.ActiveBorderThickness = 1;
            this.btnEditProduct.ActiveCornerRadius = 20;
            this.btnEditProduct.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditProduct.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.BackColor = System.Drawing.Color.White;
            this.btnEditProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.BackgroundImage")));
            this.btnEditProduct.ButtonText = "Edit Product";
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.IdleBorderThickness = 1;
            this.btnEditProduct.IdleCornerRadius = 20;
            this.btnEditProduct.IdleFillColor = System.Drawing.Color.White;
            this.btnEditProduct.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.Location = new System.Drawing.Point(526, 12);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(155, 35);
            this.btnEditProduct.TabIndex = 0;
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.ActiveBorderThickness = 1;
            this.btnNewProduct.ActiveCornerRadius = 20;
            this.btnNewProduct.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewProduct.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewProduct.BackColor = System.Drawing.Color.White;
            this.btnNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewProduct.BackgroundImage")));
            this.btnNewProduct.ButtonText = "New Product";
            this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewProduct.IdleBorderThickness = 1;
            this.btnNewProduct.IdleCornerRadius = 20;
            this.btnNewProduct.IdleFillColor = System.Drawing.Color.White;
            this.btnNewProduct.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewProduct.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewProduct.Location = new System.Drawing.Point(366, 12);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(155, 35);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridProductMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductMaster";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsProductMaster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridProductMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewProduct;
    }
}