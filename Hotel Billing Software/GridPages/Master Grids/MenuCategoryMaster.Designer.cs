namespace Hotel_Billing_Software.GridPages
{
    partial class MenuCategoryMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCategoryMaster));
            this.elipsMenuCategoryMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridMenuCategoryMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewMenuCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditMenuCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemoveMenuCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenuCategoryMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsMenuCategoryMaster
            // 
            this.elipsMenuCategoryMaster.ElipseRadius = 5;
            this.elipsMenuCategoryMaster.TargetControl = this;
            // 
            // gridMenuCategoryMaster
            // 
            this.gridMenuCategoryMaster.AllowUserToAddRows = false;
            this.gridMenuCategoryMaster.AllowUserToDeleteRows = false;
            this.gridMenuCategoryMaster.AllowUserToResizeColumns = false;
            this.gridMenuCategoryMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridMenuCategoryMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMenuCategoryMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMenuCategoryMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridMenuCategoryMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridMenuCategoryMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMenuCategoryMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridMenuCategoryMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMenuCategoryMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMenuCategoryMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMenuCategoryMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMenuCategoryMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMenuCategoryMaster.DoubleBuffered = true;
            this.gridMenuCategoryMaster.EnableHeadersVisualStyles = false;
            this.gridMenuCategoryMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridMenuCategoryMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridMenuCategoryMaster.Location = new System.Drawing.Point(0, 55);
            this.gridMenuCategoryMaster.Name = "gridMenuCategoryMaster";
            this.gridMenuCategoryMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridMenuCategoryMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMenuCategoryMaster.Size = new System.Drawing.Size(847, 549);
            this.gridMenuCategoryMaster.TabIndex = 5;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveMenuCategory);
            this.pnlHeadingButtons.Controls.Add(this.btnEditMenuCategory);
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewMenuCategory);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 4;
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
            // btnNewMenuCategory
            // 
            this.btnNewMenuCategory.ActiveBorderThickness = 1;
            this.btnNewMenuCategory.ActiveCornerRadius = 20;
            this.btnNewMenuCategory.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewMenuCategory.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewMenuCategory.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewMenuCategory.BackColor = System.Drawing.Color.White;
            this.btnNewMenuCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewMenuCategory.BackgroundImage")));
            this.btnNewMenuCategory.ButtonText = "New Menu Category";
            this.btnNewMenuCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMenuCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMenuCategory.ForeColor = System.Drawing.Color.White;
            this.btnNewMenuCategory.IdleBorderThickness = 1;
            this.btnNewMenuCategory.IdleCornerRadius = 20;
            this.btnNewMenuCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnNewMenuCategory.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewMenuCategory.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewMenuCategory.Location = new System.Drawing.Point(196, 5);
            this.btnNewMenuCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewMenuCategory.Name = "btnNewMenuCategory";
            this.btnNewMenuCategory.Size = new System.Drawing.Size(201, 35);
            this.btnNewMenuCategory.TabIndex = 0;
            this.btnNewMenuCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewMenuCategory.Click += new System.EventHandler(this.btnNewMenuCategory_Click);
            // 
            // btnEditMenuCategory
            // 
            this.btnEditMenuCategory.ActiveBorderThickness = 1;
            this.btnEditMenuCategory.ActiveCornerRadius = 20;
            this.btnEditMenuCategory.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditMenuCategory.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditMenuCategory.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditMenuCategory.BackColor = System.Drawing.Color.White;
            this.btnEditMenuCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditMenuCategory.BackgroundImage")));
            this.btnEditMenuCategory.ButtonText = "Edit Menu Category";
            this.btnEditMenuCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMenuCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenuCategory.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditMenuCategory.IdleBorderThickness = 1;
            this.btnEditMenuCategory.IdleCornerRadius = 20;
            this.btnEditMenuCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnEditMenuCategory.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditMenuCategory.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditMenuCategory.Location = new System.Drawing.Point(407, 5);
            this.btnEditMenuCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditMenuCategory.Name = "btnEditMenuCategory";
            this.btnEditMenuCategory.Size = new System.Drawing.Size(201, 35);
            this.btnEditMenuCategory.TabIndex = 3;
            this.btnEditMenuCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveMenuCategory
            // 
            this.btnRemoveMenuCategory.ActiveBorderThickness = 1;
            this.btnRemoveMenuCategory.ActiveCornerRadius = 20;
            this.btnRemoveMenuCategory.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveMenuCategory.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveMenuCategory.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveMenuCategory.BackColor = System.Drawing.Color.White;
            this.btnRemoveMenuCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveMenuCategory.BackgroundImage")));
            this.btnRemoveMenuCategory.ButtonText = "Remove Menu Category";
            this.btnRemoveMenuCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMenuCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMenuCategory.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveMenuCategory.IdleBorderThickness = 1;
            this.btnRemoveMenuCategory.IdleCornerRadius = 20;
            this.btnRemoveMenuCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveMenuCategory.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveMenuCategory.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveMenuCategory.Location = new System.Drawing.Point(618, 5);
            this.btnRemoveMenuCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveMenuCategory.Name = "btnRemoveMenuCategory";
            this.btnRemoveMenuCategory.Size = new System.Drawing.Size(224, 35);
            this.btnRemoveMenuCategory.TabIndex = 4;
            this.btnRemoveMenuCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuCategoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridMenuCategoryMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCategoryMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Category Master";
            ((System.ComponentModel.ISupportInitialize)(this.gridMenuCategoryMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsMenuCategoryMaster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridMenuCategoryMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewMenuCategory;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditMenuCategory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveMenuCategory;
    }
}