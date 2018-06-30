namespace Hotel_Billing_Software.GridPages
{
    partial class CustomerMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnRemoveCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridCustomerMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveCustomer);
            this.pnlHeadingButtons.Controls.Add(this.btnEditCustomer);
            this.pnlHeadingButtons.Controls.Add(this.btnNewCustomer);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 2;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.ActiveBorderThickness = 1;
            this.btnRemoveCustomer.ActiveCornerRadius = 20;
            this.btnRemoveCustomer.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveCustomer.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveCustomer.BackgroundImage")));
            this.btnRemoveCustomer.ButtonText = "Remove Customer";
            this.btnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveCustomer.IdleBorderThickness = 1;
            this.btnRemoveCustomer.IdleCornerRadius = 20;
            this.btnRemoveCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveCustomer.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(686, 12);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(155, 35);
            this.btnRemoveCustomer.TabIndex = 0;
            this.btnRemoveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.ActiveBorderThickness = 1;
            this.btnEditCustomer.ActiveCornerRadius = 20;
            this.btnEditCustomer.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditCustomer.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCustomer.BackColor = System.Drawing.Color.White;
            this.btnEditCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.BackgroundImage")));
            this.btnEditCustomer.ButtonText = "Edit Customer";
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCustomer.IdleBorderThickness = 1;
            this.btnEditCustomer.IdleCornerRadius = 20;
            this.btnEditCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnEditCustomer.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditCustomer.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCustomer.Location = new System.Drawing.Point(526, 12);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(155, 35);
            this.btnEditCustomer.TabIndex = 0;
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.ActiveBorderThickness = 1;
            this.btnNewCustomer.ActiveCornerRadius = 20;
            this.btnNewCustomer.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewCustomer.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewCustomer.BackColor = System.Drawing.Color.White;
            this.btnNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.BackgroundImage")));
            this.btnNewCustomer.ButtonText = "New Customer";
            this.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewCustomer.IdleBorderThickness = 1;
            this.btnNewCustomer.IdleCornerRadius = 20;
            this.btnNewCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnNewCustomer.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewCustomer.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewCustomer.Location = new System.Drawing.Point(366, 12);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(155, 35);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gridCustomerMaster
            // 
            this.gridCustomerMaster.AllowUserToAddRows = false;
            this.gridCustomerMaster.AllowUserToDeleteRows = false;
            this.gridCustomerMaster.AllowUserToOrderColumns = true;
            this.gridCustomerMaster.AllowUserToResizeColumns = false;
            this.gridCustomerMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomerMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomerMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCustomerMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridCustomerMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCustomerMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCustomerMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCustomerMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomerMaster.DoubleBuffered = true;
            this.gridCustomerMaster.EnableHeadersVisualStyles = false;
            this.gridCustomerMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridCustomerMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridCustomerMaster.Location = new System.Drawing.Point(0, 55);
            this.gridCustomerMaster.Name = "gridCustomerMaster";
            this.gridCustomerMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCustomerMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomerMaster.Size = new System.Drawing.Size(847, 549);
            this.gridCustomerMaster.TabIndex = 5;
            this.gridCustomerMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomerMaster_CellContentClick);
            // 
            // CustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridCustomerMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Master";
            this.pnlHeadingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveCustomer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridCustomerMaster;
    }
}