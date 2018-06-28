namespace Hotel_Billing_Software.Reports.Bill_Reports
{
    partial class CustomerWiseBillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerWiseBillReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipseCustomerWiseBillReport = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelMiddle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gridCustomerWiseBillReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chkSelectAllCustomer = new System.Windows.Forms.CheckBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpToDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblCustomer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblToDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpFromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFormDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerWiseBillReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseCustomerWiseBillReport
            // 
            this.ElipseCustomerWiseBillReport.ElipseRadius = 25;
            this.ElipseCustomerWiseBillReport.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 43);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnClose.Location = new System.Drawing.Point(667, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(699, 13);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(171, 17);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Customer Wise Bill Report";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMiddle.BackgroundImage")));
            this.panelMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMiddle.Controls.Add(this.bunifuGradientPanel1);
            this.panelMiddle.Controls.Add(this.panel2);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.GradientBottomLeft = System.Drawing.Color.White;
            this.panelMiddle.GradientBottomRight = System.Drawing.Color.White;
            this.panelMiddle.GradientTopLeft = System.Drawing.Color.White;
            this.panelMiddle.GradientTopRight = System.Drawing.Color.White;
            this.panelMiddle.Location = new System.Drawing.Point(0, 43);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Quality = 10;
            this.panelMiddle.Size = new System.Drawing.Size(699, 555);
            this.panelMiddle.TabIndex = 3;
            this.panelMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMiddle_Paint);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gridCustomerWiseBillReport);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 104);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(699, 451);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // gridCustomerWiseBillReport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridCustomerWiseBillReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomerWiseBillReport.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridCustomerWiseBillReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCustomerWiseBillReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerWiseBillReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomerWiseBillReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerWiseBillReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomerWiseBillReport.DoubleBuffered = true;
            this.gridCustomerWiseBillReport.EnableHeadersVisualStyles = false;
            this.gridCustomerWiseBillReport.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridCustomerWiseBillReport.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridCustomerWiseBillReport.Location = new System.Drawing.Point(0, 0);
            this.gridCustomerWiseBillReport.Name = "gridCustomerWiseBillReport";
            this.gridCustomerWiseBillReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCustomerWiseBillReport.Size = new System.Drawing.Size(699, 451);
            this.gridCustomerWiseBillReport.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.chkSelectAllCustomer);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.lblToDate);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.lblFormDate);
            this.panel2.Controls.Add(this.cmbCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 104);
            this.panel2.TabIndex = 0;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, 88);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(699, 13);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 100;
            this.bunifuSeparator2.Vertical = false;
            // 
            // chkSelectAllCustomer
            // 
            this.chkSelectAllCustomer.AutoSize = true;
            this.chkSelectAllCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAllCustomer.Location = new System.Drawing.Point(357, 71);
            this.chkSelectAllCustomer.Name = "chkSelectAllCustomer";
            this.chkSelectAllCustomer.Size = new System.Drawing.Size(76, 19);
            this.chkSelectAllCustomer.TabIndex = 21;
            this.chkSelectAllCustomer.Text = "Select All";
            this.chkSelectAllCustomer.UseVisualStyleBackColor = true;
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
            this.btnSearch.IconZoom = 40D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(599, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Tomato;
            this.btnSearch.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 15;
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
            this.dtpToDate.Location = new System.Drawing.Point(188, 35);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(139, 27);
            this.dtpToDate.TabIndex = 20;
            this.dtpToDate.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(353, 5);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(114, 19);
            this.lblCustomer.TabIndex = 19;
            this.lblCustomer.Text = "Select Customer";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(184, 5);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(24, 19);
            this.lblToDate.TabIndex = 19;
            this.lblToDate.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.BackColor = System.Drawing.Color.Silver;
            this.dtpFromDate.BorderRadius = 0;
            this.dtpFromDate.ForeColor = System.Drawing.Color.Black;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.FormatCustom = null;
            this.dtpFromDate.Location = new System.Drawing.Point(19, 35);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(139, 27);
            this.dtpFromDate.TabIndex = 18;
            this.dtpFromDate.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // lblFormDate
            // 
            this.lblFormDate.AutoSize = true;
            this.lblFormDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormDate.Location = new System.Drawing.Point(15, 5);
            this.lblFormDate.Name = "lblFormDate";
            this.lblFormDate.Size = new System.Drawing.Size(41, 19);
            this.lblFormDate.TabIndex = 17;
            this.lblFormDate.Text = "From";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.Silver;
            this.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.ForeColor = System.Drawing.Color.Black;
            this.cmbCustomer.FormatString = "Select";
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbCustomer.Location = new System.Drawing.Point(357, 35);
            this.cmbCustomer.MaxDropDownItems = 5;
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(212, 27);
            this.cmbCustomer.Sorted = true;
            this.cmbCustomer.TabIndex = 16;
            this.cmbCustomer.Text = "Select Customer";
            // 
            // CustomerWiseBillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 598);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerWiseBillReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerWiseBillReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerWiseBillReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseCustomerWiseBillReport;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeading;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMiddle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSelectAllCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpToDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCustomer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToDate;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFromDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFormDate;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridCustomerWiseBillReport;
    }
}