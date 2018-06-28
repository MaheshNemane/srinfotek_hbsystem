namespace Hotel_Billing_Software.Reports.Bill_Reports
{
    partial class DateWiseBillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateWiseBillReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipseDateWiseBillReport = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelBottom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlSearch = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpToDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblToDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpFromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFormDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelMiddle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlGrid = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gridDateWiseBillReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeading.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDateWiseBillReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseDateWiseBillReport
            // 
            this.ElipseDateWiseBillReport.ElipseRadius = 25;
            this.ElipseDateWiseBillReport.TargetControl = this;
            // 
            // pnlHeading
            // 
            this.pnlHeading.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeading.Controls.Add(this.btnClose);
            this.pnlHeading.Controls.Add(this.bunifuSeparator1);
            this.pnlHeading.Controls.Add(this.lblHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(559, 43);
            this.pnlHeading.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(527, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(556, 13);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(140, 17);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Date Wise Bill Report";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottom.BackgroundImage")));
            this.panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.GradientBottomLeft = System.Drawing.Color.White;
            this.panelBottom.GradientBottomRight = System.Drawing.Color.White;
            this.panelBottom.GradientTopLeft = System.Drawing.Color.White;
            this.panelBottom.GradientTopRight = System.Drawing.Color.White;
            this.panelBottom.Location = new System.Drawing.Point(0, 43);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Quality = 10;
            this.panelBottom.Size = new System.Drawing.Size(559, 493);
            this.panelBottom.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSearch.BackgroundImage")));
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.Controls.Add(this.bunifuSeparator2);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.dtpToDate);
            this.pnlSearch.Controls.Add(this.lblToDate);
            this.pnlSearch.Controls.Add(this.dtpFromDate);
            this.pnlSearch.Controls.Add(this.lblFormDate);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlSearch.GradientBottomRight = System.Drawing.Color.White;
            this.pnlSearch.GradientTopLeft = System.Drawing.Color.White;
            this.pnlSearch.GradientTopRight = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Quality = 10;
            this.pnlSearch.Size = new System.Drawing.Size(559, 100);
            this.pnlSearch.TabIndex = 0;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 84);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(556, 13);
            this.bunifuSeparator2.TabIndex = 26;
            this.bunifuSeparator2.Transparency = 100;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Tomato;
            this.btnSearch.BackColor = System.Drawing.Color.Tomato;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 50D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(408, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Tomato;
            this.btnSearch.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtpToDate
            // 
            this.dtpToDate.BackColor = System.Drawing.Color.Silver;
            this.dtpToDate.BorderRadius = 0;
            this.dtpToDate.ForeColor = System.Drawing.Color.Black;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.FormatCustom = null;
            this.dtpToDate.Location = new System.Drawing.Point(225, 42);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(146, 27);
            this.dtpToDate.TabIndex = 24;
            this.dtpToDate.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(221, 12);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(24, 19);
            this.lblToDate.TabIndex = 23;
            this.lblToDate.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.BackColor = System.Drawing.Color.Silver;
            this.dtpFromDate.BorderRadius = 0;
            this.dtpFromDate.ForeColor = System.Drawing.Color.Black;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.FormatCustom = null;
            this.dtpFromDate.Location = new System.Drawing.Point(43, 42);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(149, 27);
            this.dtpFromDate.TabIndex = 22;
            this.dtpFromDate.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // lblFormDate
            // 
            this.lblFormDate.AutoSize = true;
            this.lblFormDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormDate.Location = new System.Drawing.Point(39, 12);
            this.lblFormDate.Name = "lblFormDate";
            this.lblFormDate.Size = new System.Drawing.Size(41, 19);
            this.lblFormDate.TabIndex = 21;
            this.lblFormDate.Text = "From";
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.Transparent;
            this.panelMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMiddle.BackgroundImage")));
            this.panelMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMiddle.Controls.Add(this.pnlGrid);
            this.panelMiddle.Controls.Add(this.pnlSearch);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.GradientBottomLeft = System.Drawing.Color.White;
            this.panelMiddle.GradientBottomRight = System.Drawing.Color.White;
            this.panelMiddle.GradientTopLeft = System.Drawing.Color.White;
            this.panelMiddle.GradientTopRight = System.Drawing.Color.White;
            this.panelMiddle.Location = new System.Drawing.Point(0, 43);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Quality = 10;
            this.panelMiddle.Size = new System.Drawing.Size(559, 493);
            this.panelMiddle.TabIndex = 4;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGrid.BackgroundImage")));
            this.pnlGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGrid.Controls.Add(this.gridDateWiseBillReport);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlGrid.GradientBottomRight = System.Drawing.Color.White;
            this.pnlGrid.GradientTopLeft = System.Drawing.Color.White;
            this.pnlGrid.GradientTopRight = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(0, 100);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Quality = 10;
            this.pnlGrid.Size = new System.Drawing.Size(559, 393);
            this.pnlGrid.TabIndex = 1;
            // 
            // gridDateWiseBillReport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDateWiseBillReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDateWiseBillReport.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDateWiseBillReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDateWiseBillReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDateWiseBillReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDateWiseBillReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDateWiseBillReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDateWiseBillReport.DoubleBuffered = true;
            this.gridDateWiseBillReport.EnableHeadersVisualStyles = false;
            this.gridDateWiseBillReport.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridDateWiseBillReport.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridDateWiseBillReport.Location = new System.Drawing.Point(0, 0);
            this.gridDateWiseBillReport.Name = "gridDateWiseBillReport";
            this.gridDateWiseBillReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDateWiseBillReport.Size = new System.Drawing.Size(559, 393);
            this.gridDateWiseBillReport.TabIndex = 0;
            // 
            // DateWiseBillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 536);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.pnlHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateWiseBillReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateWiseBillReport";
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDateWiseBillReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseDateWiseBillReport;
        private System.Windows.Forms.Panel pnlHeading;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeading;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMiddle;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlGrid;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSearch;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpToDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToDate;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFromDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFormDate;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBottom;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridDateWiseBillReport;
    }
}