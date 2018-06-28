namespace Hotel_Billing_Software
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.ElipseForgotPassword = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelHeading = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LabelHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnGetPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmailId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPasswordHint = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelHeading.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseForgotPassword
            // 
            this.ElipseForgotPassword.ElipseRadius = 25;
            this.ElipseForgotPassword.TargetControl = this;
            // 
            // PanelHeading
            // 
            this.PanelHeading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeading.BackgroundImage")));
            this.PanelHeading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeading.Controls.Add(this.bunifuSeparator1);
            this.PanelHeading.Controls.Add(this.LabelHeading);
            this.PanelHeading.Controls.Add(this.btnClose);
            this.PanelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeading.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelHeading.GradientBottomRight = System.Drawing.Color.White;
            this.PanelHeading.GradientTopLeft = System.Drawing.Color.White;
            this.PanelHeading.GradientTopRight = System.Drawing.Color.White;
            this.PanelHeading.Location = new System.Drawing.Point(0, 0);
            this.PanelHeading.Name = "PanelHeading";
            this.PanelHeading.Quality = 10;
            this.PanelHeading.Size = new System.Drawing.Size(473, 41);
            this.PanelHeading.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 27);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(470, 11);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LabelHeading
            // 
            this.LabelHeading.AutoSize = true;
            this.LabelHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeading.Location = new System.Drawing.Point(12, 7);
            this.LabelHeading.Name = "LabelHeading";
            this.LabelHeading.Size = new System.Drawing.Size(116, 19);
            this.LabelHeading.TabIndex = 1;
            this.LabelHeading.Text = "Forgot Password";
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
            this.btnClose.Location = new System.Drawing.Point(441, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblLogin);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuGradientPanel1.Controls.Add(this.btnGetPassword);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 147);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(473, 53);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(84, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 19);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(470, 10);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetPassword.BackColor = System.Drawing.Color.Green;
            this.btnGetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetPassword.BorderRadius = 5;
            this.btnGetPassword.ButtonText = "Get Password";
            this.btnGetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGetPassword.Iconimage")));
            this.btnGetPassword.Iconimage_right = null;
            this.btnGetPassword.Iconimage_right_Selected = null;
            this.btnGetPassword.Iconimage_Selected = null;
            this.btnGetPassword.IconMarginLeft = 0;
            this.btnGetPassword.IconMarginRight = 0;
            this.btnGetPassword.IconRightVisible = true;
            this.btnGetPassword.IconRightZoom = 0D;
            this.btnGetPassword.IconVisible = true;
            this.btnGetPassword.IconZoom = 50D;
            this.btnGetPassword.IsTab = false;
            this.btnGetPassword.Location = new System.Drawing.Point(336, 17);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Normalcolor = System.Drawing.Color.Green;
            this.btnGetPassword.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnGetPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetPassword.selected = false;
            this.btnGetPassword.Size = new System.Drawing.Size(124, 33);
            this.btnGetPassword.TabIndex = 0;
            this.btnGetPassword.Text = "Get Password";
            this.btnGetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPassword.Textcolor = System.Drawing.Color.White;
            this.btnGetPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.Controls.Add(this.txtEmailId);
            this.bunifuGradientPanel2.Controls.Add(this.txtPasswordHint);
            this.bunifuGradientPanel2.Controls.Add(this.txtUserName);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 41);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(473, 106);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(221, 60);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(23, 15);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "OR";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailId.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmailId.HintText = "Email ID";
            this.txtEmailId.isPassword = false;
            this.txtEmailId.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtEmailId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmailId.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtEmailId.LineThickness = 2;
            this.txtEmailId.Location = new System.Drawing.Point(259, 52);
            this.txtEmailId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(201, 29);
            this.txtEmailId.TabIndex = 2;
            this.txtEmailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPasswordHint
            // 
            this.txtPasswordHint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordHint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordHint.HintForeColor = System.Drawing.Color.Empty;
            this.txtPasswordHint.HintText = "Password Hint";
            this.txtPasswordHint.isPassword = false;
            this.txtPasswordHint.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtPasswordHint.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPasswordHint.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtPasswordHint.LineThickness = 2;
            this.txtPasswordHint.Location = new System.Drawing.Point(13, 52);
            this.txtPasswordHint.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordHint.Name = "txtPasswordHint";
            this.txtPasswordHint.Size = new System.Drawing.Size(192, 29);
            this.txtPasswordHint.TabIndex = 1;
            this.txtPasswordHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "User Name";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtUserName.LineThickness = 2;
            this.txtUserName.Location = new System.Drawing.Point(13, 16);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 29);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(473, 200);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.PanelHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.PanelHeading.ResumeLayout(false);
            this.PanelHeading.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseForgotPassword;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHeading;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelHeading;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetPassword;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordHint;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
    }
}