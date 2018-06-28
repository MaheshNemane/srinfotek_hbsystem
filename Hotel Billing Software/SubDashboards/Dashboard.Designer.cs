namespace Hotel_Billing_Software.SubDashboards
{
    partial class Dashboard
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
            this.elipsDashboard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningTile1 = new Hotel_Billing_Software.User_Control.WarningTile();
            this.successTile1 = new Hotel_Billing_Software.User_Control.SuccessTile();
            this.dangerTile1 = new Hotel_Billing_Software.User_Control.DangerTile();
            this.primaryTile1 = new Hotel_Billing_Software.User_Control.PrimaryTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsDashboard
            // 
            this.elipsDashboard.ElipseRadius = 5;
            this.elipsDashboard.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warningTile1);
            this.panel1.Controls.Add(this.successTile1);
            this.panel1.Controls.Add(this.dangerTile1);
            this.panel1.Controls.Add(this.primaryTile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 125);
            this.panel1.TabIndex = 0;
            // 
            // warningTile1
            // 
            this.warningTile1.BackColor = System.Drawing.Color.White;
            this.warningTile1.Location = new System.Drawing.Point(824, 23);
            this.warningTile1.Name = "warningTile1";
            this.warningTile1.Size = new System.Drawing.Size(260, 85);
            this.warningTile1.TabIndex = 3;
            // 
            // successTile1
            // 
            this.successTile1.BackColor = System.Drawing.Color.White;
            this.successTile1.Location = new System.Drawing.Point(549, 23);
            this.successTile1.Name = "successTile1";
            this.successTile1.Size = new System.Drawing.Size(260, 85);
            this.successTile1.TabIndex = 2;
            // 
            // dangerTile1
            // 
            this.dangerTile1.Location = new System.Drawing.Point(285, 24);
            this.dangerTile1.Name = "dangerTile1";
            this.dangerTile1.Size = new System.Drawing.Size(258, 84);
            this.dangerTile1.TabIndex = 1;
            // 
            // primaryTile1
            // 
            this.primaryTile1.BackColor = System.Drawing.Color.White;
            this.primaryTile1.Location = new System.Drawing.Point(12, 24);
            this.primaryTile1.Name = "primaryTile1";
            this.primaryTile1.Size = new System.Drawing.Size(258, 84);
            this.primaryTile1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 689);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsDashboard;
        private System.Windows.Forms.Panel panel1;
        private User_Control.PrimaryTile primaryTile1;
        private User_Control.WarningTile warningTile1;
        private User_Control.SuccessTile successTile1;
        private User_Control.DangerTile dangerTile1;
    }
}