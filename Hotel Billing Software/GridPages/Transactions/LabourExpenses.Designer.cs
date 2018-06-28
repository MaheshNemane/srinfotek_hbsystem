namespace Hotel_Billing_Software.GridPages.Transactions
{
    partial class LabourExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabourExpenses));
            this.elipseLabourExpense = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridLabourExpense = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.elipsHotelExpenses = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewLabourExpense = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabourExpense)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseLabourExpense
            // 
            this.elipseLabourExpense.ElipseRadius = 5;
            this.elipseLabourExpense.TargetControl = this;
            // 
            // gridLabourExpense
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridLabourExpense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLabourExpense.BackgroundColor = System.Drawing.Color.White;
            this.gridLabourExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLabourExpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLabourExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridLabourExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLabourExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLabourExpense.DoubleBuffered = true;
            this.gridLabourExpense.EnableHeadersVisualStyles = false;
            this.gridLabourExpense.HeaderBgColor = System.Drawing.Color.Crimson;
            this.gridLabourExpense.HeaderForeColor = System.Drawing.Color.White;
            this.gridLabourExpense.Location = new System.Drawing.Point(0, 55);
            this.gridLabourExpense.Name = "gridLabourExpense";
            this.gridLabourExpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridLabourExpense.Size = new System.Drawing.Size(783, 490);
            this.gridLabourExpense.TabIndex = 5;
            // 
            // elipsHotelExpenses
            // 
            this.elipsHotelExpenses.ElipseRadius = 5;
            this.elipsHotelExpenses.TargetControl = this;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.BackColor = System.Drawing.Color.White;
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewLabourExpense);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(783, 55);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(783, 10);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnNewLabourExpense
            // 
            this.btnNewLabourExpense.ActiveBorderThickness = 1;
            this.btnNewLabourExpense.ActiveCornerRadius = 20;
            this.btnNewLabourExpense.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewLabourExpense.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewLabourExpense.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewLabourExpense.BackColor = System.Drawing.Color.White;
            this.btnNewLabourExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewLabourExpense.BackgroundImage")));
            this.btnNewLabourExpense.ButtonText = "New Labour Expense";
            this.btnNewLabourExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLabourExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLabourExpense.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewLabourExpense.IdleBorderThickness = 1;
            this.btnNewLabourExpense.IdleCornerRadius = 20;
            this.btnNewLabourExpense.IdleFillColor = System.Drawing.Color.White;
            this.btnNewLabourExpense.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewLabourExpense.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewLabourExpense.Location = new System.Drawing.Point(587, 12);
            this.btnNewLabourExpense.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewLabourExpense.Name = "btnNewLabourExpense";
            this.btnNewLabourExpense.Size = new System.Drawing.Size(182, 35);
            this.btnNewLabourExpense.TabIndex = 0;
            this.btnNewLabourExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabourExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 545);
            this.Controls.Add(this.gridLabourExpense);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LabourExpenses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LabourExpenses";
            ((System.ComponentModel.ISupportInitialize)(this.gridLabourExpense)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseLabourExpense;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridLabourExpense;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewLabourExpense;
        private Bunifu.Framework.UI.BunifuElipse elipsHotelExpenses;
    }
}