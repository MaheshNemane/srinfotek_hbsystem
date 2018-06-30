namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    partial class UOMMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UOMMaster));
            this.elipsGSTGrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridUOMMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnRemoveUOM = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditUOM = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewUOM = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridUOMMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsGSTGrid
            // 
            this.elipsGSTGrid.ElipseRadius = 5;
            this.elipsGSTGrid.TargetControl = this;
            // 
            // gridUOMMaster
            // 
            this.gridUOMMaster.AllowUserToAddRows = false;
            this.gridUOMMaster.AllowUserToDeleteRows = false;
            this.gridUOMMaster.AllowUserToOrderColumns = true;
            this.gridUOMMaster.AllowUserToResizeColumns = false;
            this.gridUOMMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUOMMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUOMMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUOMMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridUOMMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridUOMMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUOMMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUOMMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUOMMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUOMMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUOMMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUOMMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUOMMaster.DoubleBuffered = true;
            this.gridUOMMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridUOMMaster.EnableHeadersVisualStyles = false;
            this.gridUOMMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridUOMMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridUOMMaster.Location = new System.Drawing.Point(0, 55);
            this.gridUOMMaster.Name = "gridUOMMaster";
            this.gridUOMMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUOMMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUOMMaster.Size = new System.Drawing.Size(847, 549);
            this.gridUOMMaster.TabIndex = 9;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.BackColor = System.Drawing.Color.White;
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveUOM);
            this.pnlHeadingButtons.Controls.Add(this.btnEditUOM);
            this.pnlHeadingButtons.Controls.Add(this.btnNewUOM);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 8;
            // 
            // btnRemoveUOM
            // 
            this.btnRemoveUOM.ActiveBorderThickness = 1;
            this.btnRemoveUOM.ActiveCornerRadius = 20;
            this.btnRemoveUOM.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUOM.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveUOM.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUOM.BackColor = System.Drawing.Color.White;
            this.btnRemoveUOM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveUOM.BackgroundImage")));
            this.btnRemoveUOM.ButtonText = "Remove UOM";
            this.btnRemoveUOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUOM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUOM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUOM.IdleBorderThickness = 1;
            this.btnRemoveUOM.IdleCornerRadius = 20;
            this.btnRemoveUOM.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveUOM.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveUOM.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUOM.Location = new System.Drawing.Point(684, 12);
            this.btnRemoveUOM.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveUOM.Name = "btnRemoveUOM";
            this.btnRemoveUOM.Size = new System.Drawing.Size(155, 35);
            this.btnRemoveUOM.TabIndex = 0;
            this.btnRemoveUOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveUOM.Click += new System.EventHandler(this.btnRemoveUOM_Click);
            // 
            // btnEditUOM
            // 
            this.btnEditUOM.ActiveBorderThickness = 1;
            this.btnEditUOM.ActiveCornerRadius = 20;
            this.btnEditUOM.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUOM.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditUOM.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUOM.BackColor = System.Drawing.Color.White;
            this.btnEditUOM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditUOM.BackgroundImage")));
            this.btnEditUOM.ButtonText = "Edit UOM";
            this.btnEditUOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUOM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUOM.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUOM.IdleBorderThickness = 1;
            this.btnEditUOM.IdleCornerRadius = 20;
            this.btnEditUOM.IdleFillColor = System.Drawing.Color.White;
            this.btnEditUOM.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditUOM.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUOM.Location = new System.Drawing.Point(525, 12);
            this.btnEditUOM.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditUOM.Name = "btnEditUOM";
            this.btnEditUOM.Size = new System.Drawing.Size(155, 35);
            this.btnEditUOM.TabIndex = 0;
            this.btnEditUOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditUOM.Click += new System.EventHandler(this.btnEditUOM_Click);
            // 
            // btnNewUOM
            // 
            this.btnNewUOM.ActiveBorderThickness = 1;
            this.btnNewUOM.ActiveCornerRadius = 20;
            this.btnNewUOM.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewUOM.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewUOM.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewUOM.BackColor = System.Drawing.Color.White;
            this.btnNewUOM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewUOM.BackgroundImage")));
            this.btnNewUOM.ButtonText = "New UOM";
            this.btnNewUOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUOM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUOM.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewUOM.IdleBorderThickness = 1;
            this.btnNewUOM.IdleCornerRadius = 20;
            this.btnNewUOM.IdleFillColor = System.Drawing.Color.White;
            this.btnNewUOM.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewUOM.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewUOM.Location = new System.Drawing.Point(366, 12);
            this.btnNewUOM.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewUOM.Name = "btnNewUOM";
            this.btnNewUOM.Size = new System.Drawing.Size(155, 35);
            this.btnNewUOM.TabIndex = 0;
            this.btnNewUOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewUOM.Click += new System.EventHandler(this.btnNewUOM_Click);
            // 
            // UOMMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridUOMMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UOMMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UOM Master";
            ((System.ComponentModel.ISupportInitialize)(this.gridUOMMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsGSTGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridUOMMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveUOM;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditUOM;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewUOM;
    }
}