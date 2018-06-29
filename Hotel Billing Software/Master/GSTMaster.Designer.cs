namespace Hotel_Billing_Software.Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSTMaster));
            this.elipsGSTMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtGSTId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGSTPercentage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnl1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSign = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsGSTMaster
            // 
            this.elipsGSTMaster.ElipseRadius = 25;
            this.elipsGSTMaster.TargetControl = this;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.lblSign);
            this.bunifuGradientPanel3.Controls.Add(this.txtGSTId);
            this.bunifuGradientPanel3.Controls.Add(this.txtGSTPercentage);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 46);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(500, 207);
            this.bunifuGradientPanel3.TabIndex = 8;
            // 
            // txtGSTId
            // 
            this.txtGSTId.BackColor = System.Drawing.Color.White;
            this.txtGSTId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGSTId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGSTId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGSTId.HintForeColor = System.Drawing.Color.Empty;
            this.txtGSTId.HintText = "CustomerId";
            this.txtGSTId.isPassword = false;
            this.txtGSTId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGSTId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGSTId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGSTId.LineThickness = 1;
            this.txtGSTId.Location = new System.Drawing.Point(76, 18);
            this.txtGSTId.Margin = new System.Windows.Forms.Padding(4);
            this.txtGSTId.Name = "txtGSTId";
            this.txtGSTId.Size = new System.Drawing.Size(322, 33);
            this.txtGSTId.TabIndex = 5;
            this.txtGSTId.Text = "0";
            this.txtGSTId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGSTId.Visible = false;
            // 
            // txtGSTPercentage
            // 
            this.txtGSTPercentage.BackColor = System.Drawing.Color.White;
            this.txtGSTPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGSTPercentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSTPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGSTPercentage.HintForeColor = System.Drawing.Color.Empty;
            this.txtGSTPercentage.HintText = "GST in(%)";
            this.txtGSTPercentage.isPassword = false;
            this.txtGSTPercentage.LineFocusedColor = System.Drawing.Color.Black;
            this.txtGSTPercentage.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGSTPercentage.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtGSTPercentage.LineThickness = 1;
            this.txtGSTPercentage.Location = new System.Drawing.Point(76, 82);
            this.txtGSTPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.txtGSTPercentage.Name = "txtGSTPercentage";
            this.txtGSTPercentage.Size = new System.Drawing.Size(322, 29);
            this.txtGSTPercentage.TabIndex = 1;
            this.txtGSTPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGSTPercentage.OnValueChanged += new System.EventHandler(this.txtGSTPercentage_OnValueChanged);
            this.txtGSTPercentage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGSTPercentage_MouseClick);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel2.Controls.Add(this.btnSave);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuSeparator2);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 253);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(500, 47);
            this.bunifuGradientPanel2.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Orange;
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(305, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Orange;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Green;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 40D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(404, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(500, 10);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 100;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1.BackgroundImage")));
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl1.Controls.Add(this.bunifuSeparator1);
            this.pnl1.Controls.Add(this.btnClose);
            this.pnl1.Controls.Add(this.lblFormHeading);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.GradientBottomLeft = System.Drawing.Color.White;
            this.pnl1.GradientBottomRight = System.Drawing.Color.White;
            this.pnl1.GradientTopLeft = System.Drawing.Color.White;
            this.pnl1.GradientTopRight = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Quality = 10;
            this.pnl1.Size = new System.Drawing.Size(500, 46);
            this.pnl1.TabIndex = 6;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 10);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(468, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeading.Location = new System.Drawing.Point(12, 13);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(110, 17);
            this.lblFormHeading.TabIndex = 0;
            this.lblFormHeading.Text = "GST Registration";
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.BackColor = System.Drawing.Color.Transparent;
            this.lblSign.Location = new System.Drawing.Point(406, 97);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(32, 13);
            this.lblSign.TabIndex = 6;
            this.lblSign.Text = "in (%)";
            this.lblSign.Visible = false;
            // 
            // GSTMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GSTMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSTMaster";
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsGSTMaster;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtGSTId;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtGSTPercentage;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        public Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFormHeading;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSign;
    }
}