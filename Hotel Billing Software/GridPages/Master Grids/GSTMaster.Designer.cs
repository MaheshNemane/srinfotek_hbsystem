namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    partial class GSTMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSTMaster));
            this.elipsGSTGrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridGSTMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnRemoveGST = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditGST = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewGST = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridGSTMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsGSTGrid
            // 
            this.elipsGSTGrid.ElipseRadius = 5;
            this.elipsGSTGrid.TargetControl = this;
            // 
            // gridGSTMaster
            // 
            this.gridGSTMaster.AllowUserToAddRows = false;
            this.gridGSTMaster.AllowUserToDeleteRows = false;
            this.gridGSTMaster.AllowUserToOrderColumns = true;
            this.gridGSTMaster.AllowUserToResizeColumns = false;
            this.gridGSTMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGSTMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridGSTMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGSTMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridGSTMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridGSTMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGSTMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridGSTMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGSTMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridGSTMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGSTMaster.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridGSTMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGSTMaster.DoubleBuffered = true;
            this.gridGSTMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridGSTMaster.EnableHeadersVisualStyles = false;
            this.gridGSTMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridGSTMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridGSTMaster.Location = new System.Drawing.Point(0, 55);
            this.gridGSTMaster.Name = "gridGSTMaster";
            this.gridGSTMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridGSTMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGSTMaster.Size = new System.Drawing.Size(847, 549);
            this.gridGSTMaster.TabIndex = 7;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveGST);
            this.pnlHeadingButtons.Controls.Add(this.btnEditGST);
            this.pnlHeadingButtons.Controls.Add(this.btnNewGST);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 6;
            // 
            // btnRemoveGST
            // 
            this.btnRemoveGST.ActiveBorderThickness = 1;
            this.btnRemoveGST.ActiveCornerRadius = 20;
            this.btnRemoveGST.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveGST.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveGST.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveGST.BackColor = System.Drawing.Color.White;
            this.btnRemoveGST.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveGST.BackgroundImage")));
            this.btnRemoveGST.ButtonText = "Remove GST";
            this.btnRemoveGST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveGST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGST.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveGST.IdleBorderThickness = 1;
            this.btnRemoveGST.IdleCornerRadius = 20;
            this.btnRemoveGST.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveGST.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveGST.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveGST.Location = new System.Drawing.Point(686, 12);
            this.btnRemoveGST.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveGST.Name = "btnRemoveGST";
            this.btnRemoveGST.Size = new System.Drawing.Size(155, 35);
            this.btnRemoveGST.TabIndex = 0;
            this.btnRemoveGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditGST
            // 
            this.btnEditGST.ActiveBorderThickness = 1;
            this.btnEditGST.ActiveCornerRadius = 20;
            this.btnEditGST.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditGST.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditGST.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditGST.BackColor = System.Drawing.Color.White;
            this.btnEditGST.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditGST.BackgroundImage")));
            this.btnEditGST.ButtonText = "Edit GST";
            this.btnEditGST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGST.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditGST.IdleBorderThickness = 1;
            this.btnEditGST.IdleCornerRadius = 20;
            this.btnEditGST.IdleFillColor = System.Drawing.Color.White;
            this.btnEditGST.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditGST.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditGST.Location = new System.Drawing.Point(526, 12);
            this.btnEditGST.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditGST.Name = "btnEditGST";
            this.btnEditGST.Size = new System.Drawing.Size(155, 35);
            this.btnEditGST.TabIndex = 0;
            this.btnEditGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGST
            // 
            this.btnNewGST.ActiveBorderThickness = 1;
            this.btnNewGST.ActiveCornerRadius = 20;
            this.btnNewGST.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewGST.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewGST.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewGST.BackColor = System.Drawing.Color.White;
            this.btnNewGST.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewGST.BackgroundImage")));
            this.btnNewGST.ButtonText = "New GST";
            this.btnNewGST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGST.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewGST.IdleBorderThickness = 1;
            this.btnNewGST.IdleCornerRadius = 20;
            this.btnNewGST.IdleFillColor = System.Drawing.Color.White;
            this.btnNewGST.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewGST.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewGST.Location = new System.Drawing.Point(366, 12);
            this.btnNewGST.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewGST.Name = "btnNewGST";
            this.btnNewGST.Size = new System.Drawing.Size(155, 35);
            this.btnNewGST.TabIndex = 0;
            this.btnNewGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewGST.Click += new System.EventHandler(this.btnNewGST_Click);
            // 
            // GSTMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridGSTMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GSTMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GSTMaster";
            ((System.ComponentModel.ISupportInitialize)(this.gridGSTMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsGSTGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridGSTMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveGST;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditGST;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewGST;
    }
}