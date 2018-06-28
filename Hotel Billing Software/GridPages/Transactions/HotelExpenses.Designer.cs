namespace Hotel_Billing_Software.GridPages.Transactions
{
    partial class HotelExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelExpenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipsHotelExpenses = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewExpense = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gridExpenseMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenseMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsHotelExpenses
            // 
            this.elipsHotelExpenses.ElipseRadius = 5;
            this.elipsHotelExpenses.TargetControl = this;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewExpense);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(831, 55);
            this.pnlHeadingButtons.TabIndex = 2;
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
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.ActiveBorderThickness = 1;
            this.btnNewExpense.ActiveCornerRadius = 20;
            this.btnNewExpense.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewExpense.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewExpense.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewExpense.BackColor = System.Drawing.Color.White;
            this.btnNewExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewExpense.BackgroundImage")));
            this.btnNewExpense.ButtonText = "New Expense";
            this.btnNewExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpense.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewExpense.IdleBorderThickness = 1;
            this.btnNewExpense.IdleCornerRadius = 20;
            this.btnNewExpense.IdleFillColor = System.Drawing.Color.White;
            this.btnNewExpense.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewExpense.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewExpense.Location = new System.Drawing.Point(610, 15);
            this.btnNewExpense.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(155, 35);
            this.btnNewExpense.TabIndex = 0;
            this.btnNewExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // gridExpenseMaster
            // 
            this.gridExpenseMaster.AllowUserToAddRows = false;
            this.gridExpenseMaster.AllowUserToDeleteRows = false;
            this.gridExpenseMaster.AllowUserToOrderColumns = true;
            this.gridExpenseMaster.AllowUserToResizeColumns = false;
            this.gridExpenseMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExpenseMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridExpenseMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridExpenseMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridExpenseMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridExpenseMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridExpenseMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridExpenseMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExpenseMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridExpenseMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExpenseMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridExpenseMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridExpenseMaster.DoubleBuffered = true;
            this.gridExpenseMaster.EnableHeadersVisualStyles = false;
            this.gridExpenseMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridExpenseMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridExpenseMaster.Location = new System.Drawing.Point(0, 55);
            this.gridExpenseMaster.Name = "gridExpenseMaster";
            this.gridExpenseMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridExpenseMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExpenseMaster.Size = new System.Drawing.Size(831, 510);
            this.gridExpenseMaster.TabIndex = 6;
            // 
            // HotelExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.gridExpenseMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelExpenses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotelExpenses";
            this.pnlHeadingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenseMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsHotelExpenses;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewExpense;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridExpenseMaster;
    }
}