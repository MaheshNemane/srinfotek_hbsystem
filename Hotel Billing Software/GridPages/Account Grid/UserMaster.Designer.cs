namespace Hotel_Billing_Software.GridPages.Account_Grid
{
    partial class UserMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMaster));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gridUserMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRemoveUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlHeadingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnRemoveUser);
            this.pnlHeadingButtons.Controls.Add(this.btnEditUser);
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator2);
            this.pnlHeadingButtons.Controls.Add(this.btnNewUser);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 55);
            this.pnlHeadingButtons.TabIndex = 6;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 45);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(847, 10);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 100;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnNewUser
            // 
            this.btnNewUser.ActiveBorderThickness = 1;
            this.btnNewUser.ActiveCornerRadius = 20;
            this.btnNewUser.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewUser.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.BackColor = System.Drawing.Color.White;
            this.btnNewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewUser.BackgroundImage")));
            this.btnNewUser.ButtonText = "New User";
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.IdleBorderThickness = 1;
            this.btnNewUser.IdleCornerRadius = 20;
            this.btnNewUser.IdleFillColor = System.Drawing.Color.White;
            this.btnNewUser.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.Location = new System.Drawing.Point(358, 12);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(135, 35);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // gridUserMaster
            // 
            this.gridUserMaster.AllowUserToAddRows = false;
            this.gridUserMaster.AllowUserToDeleteRows = false;
            this.gridUserMaster.AllowUserToOrderColumns = true;
            this.gridUserMaster.AllowUserToResizeColumns = false;
            this.gridUserMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUserMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUserMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUserMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridUserMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridUserMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUserMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUserMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUserMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUserMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUserMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUserMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUserMaster.DoubleBuffered = true;
            this.gridUserMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridUserMaster.EnableHeadersVisualStyles = false;
            this.gridUserMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridUserMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridUserMaster.Location = new System.Drawing.Point(0, 55);
            this.gridUserMaster.Name = "gridUserMaster";
            this.gridUserMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUserMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUserMaster.Size = new System.Drawing.Size(847, 549);
            this.gridUserMaster.TabIndex = 7;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.ActiveBorderThickness = 1;
            this.btnRemoveUser.ActiveCornerRadius = 20;
            this.btnRemoveUser.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveUser.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.BackColor = System.Drawing.Color.White;
            this.btnRemoveUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveUser.BackgroundImage")));
            this.btnRemoveUser.ButtonText = "Remove User";
            this.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.IdleBorderThickness = 1;
            this.btnRemoveUser.IdleCornerRadius = 20;
            this.btnRemoveUser.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveUser.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.Location = new System.Drawing.Point(655, 12);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(131, 35);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditUser
            // 
            this.btnEditUser.ActiveBorderThickness = 1;
            this.btnEditUser.ActiveCornerRadius = 20;
            this.btnEditUser.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditUser.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.BackColor = System.Drawing.Color.White;
            this.btnEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditUser.BackgroundImage")));
            this.btnEditUser.ButtonText = "Edit User";
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.IdleBorderThickness = 1;
            this.btnEditUser.IdleCornerRadius = 20;
            this.btnEditUser.IdleFillColor = System.Drawing.Color.White;
            this.btnEditUser.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.Location = new System.Drawing.Point(503, 12);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(142, 35);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridUserMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Master";
            this.pnlHeadingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUserMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewUser;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridUserMaster;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditUser;
    }
}