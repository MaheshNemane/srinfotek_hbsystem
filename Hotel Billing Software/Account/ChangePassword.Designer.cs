namespace Hotel_Billing_Software.Account
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMiddle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOldPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ElipseChangePassword = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMiddle.BackgroundImage")));
            this.PanelMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMiddle.Controls.Add(this.btnSave);
            this.PanelMiddle.Controls.Add(this.txtConfirmPassword);
            this.PanelMiddle.Controls.Add(this.txtNewPassword);
            this.PanelMiddle.Controls.Add(this.txtOldPassword);
            this.PanelMiddle.Controls.Add(this.txtUserName);
            this.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMiddle.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelMiddle.GradientBottomRight = System.Drawing.Color.White;
            this.PanelMiddle.GradientTopLeft = System.Drawing.Color.White;
            this.PanelMiddle.GradientTopRight = System.Drawing.Color.White;
            this.PanelMiddle.Location = new System.Drawing.Point(0, 0);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Quality = 10;
            this.PanelMiddle.Size = new System.Drawing.Size(318, 225);
            this.PanelMiddle.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Tomato;
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Change Password";
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
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(129, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Tomato;
            this.btnSave.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(152, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Change Password";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.HintText = "Confirm Password";
            this.txtConfirmPassword.isPassword = false;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtConfirmPassword.LineThickness = 2;
            this.txtConfirmPassword.Location = new System.Drawing.Point(38, 136);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(223, 29);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.HintText = "New Password";
            this.txtNewPassword.isPassword = false;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtNewPassword.LineThickness = 2;
            this.txtNewPassword.Location = new System.Drawing.Point(38, 99);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(223, 29);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.White;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOldPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtOldPassword.HintText = "Old Password";
            this.txtOldPassword.isPassword = false;
            this.txtOldPassword.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtOldPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOldPassword.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtOldPassword.LineThickness = 2;
            this.txtOldPassword.Location = new System.Drawing.Point(38, 62);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(223, 29);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
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
            this.txtUserName.Location = new System.Drawing.Point(38, 25);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 29);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ElipseChangePassword
            // 
            this.ElipseChangePassword.ElipseRadius = 25;
            this.ElipseChangePassword.TargetControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.PanelMiddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.PanelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelMiddle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOldPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuElipse ElipseChangePassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}