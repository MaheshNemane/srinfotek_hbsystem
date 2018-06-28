namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    partial class PaymentModeMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentModeMaster));
            this.elipsPaymentModeMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridPaymentModeMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewPaymentMode = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaymentModeMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsPaymentModeMaster
            // 
            this.elipsPaymentModeMaster.ElipseRadius = 5;
            this.elipsPaymentModeMaster.TargetControl = this;
            // 
            // gridPaymentModeMaster
            // 
            this.gridPaymentModeMaster.AllowUserToAddRows = false;
            this.gridPaymentModeMaster.AllowUserToDeleteRows = false;
            this.gridPaymentModeMaster.AllowUserToOrderColumns = true;
            this.gridPaymentModeMaster.AllowUserToResizeColumns = false;
            this.gridPaymentModeMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPaymentModeMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPaymentModeMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPaymentModeMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPaymentModeMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridPaymentModeMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPaymentModeMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPaymentModeMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPaymentModeMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPaymentModeMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPaymentModeMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPaymentModeMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPaymentModeMaster.DoubleBuffered = true;
            this.gridPaymentModeMaster.EnableHeadersVisualStyles = false;
            this.gridPaymentModeMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridPaymentModeMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridPaymentModeMaster.Location = new System.Drawing.Point(0, 55);
            this.gridPaymentModeMaster.Name = "gridPaymentModeMaster";
            this.gridPaymentModeMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPaymentModeMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPaymentModeMaster.Size = new System.Drawing.Size(831, 510);
            this.gridPaymentModeMaster.TabIndex = 5;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewPaymentMode);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(831, 55);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(831, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnNewPaymentMode
            // 
            this.btnNewPaymentMode.ActiveBorderThickness = 1;
            this.btnNewPaymentMode.ActiveCornerRadius = 20;
            this.btnNewPaymentMode.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewPaymentMode.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewPaymentMode.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewPaymentMode.BackColor = System.Drawing.Color.White;
            this.btnNewPaymentMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPaymentMode.BackgroundImage")));
            this.btnNewPaymentMode.ButtonText = "New Payment Mode";
            this.btnNewPaymentMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPaymentMode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPaymentMode.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewPaymentMode.IdleBorderThickness = 1;
            this.btnNewPaymentMode.IdleCornerRadius = 20;
            this.btnNewPaymentMode.IdleFillColor = System.Drawing.Color.White;
            this.btnNewPaymentMode.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewPaymentMode.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewPaymentMode.Location = new System.Drawing.Point(610, 15);
            this.btnNewPaymentMode.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewPaymentMode.Name = "btnNewPaymentMode";
            this.btnNewPaymentMode.Size = new System.Drawing.Size(170, 35);
            this.btnNewPaymentMode.TabIndex = 0;
            this.btnNewPaymentMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPaymentMode.Click += new System.EventHandler(this.btnNewPaymentMode_Click);
            // 
            // PaymentModeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.gridPaymentModeMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentModeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentModeMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridPaymentModeMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsPaymentModeMaster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridPaymentModeMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewPaymentMode;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}