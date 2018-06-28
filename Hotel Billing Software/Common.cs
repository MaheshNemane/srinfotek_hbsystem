﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.Framework.UI;

namespace Hotel_Billing_Software
{
    public static class Common
    {
        public static void showPage(Form sourceForm)
        {
            sourceForm.TopLevel = false;            
            sourceForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sourceForm.Dock = DockStyle.Fill;
            sourceForm.AutoScaleMode = AutoScaleMode.None;
            sourceForm.Show();            
        }


        public static BunifuFlatButton setUpdate(BunifuFlatButton btn)
        {          
            btn.Text = "Update";
            btn.Normalcolor = Color.SteelBlue;
            btn.OnHovercolor = Color.RoyalBlue;
            btn.BackColor = Color.SteelBlue;
            btn.Activecolor = Color.SteelBlue;
            return btn;
        }


        public static void showSuccess(string msg)
        {
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showWarning(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showDenger(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showInfo(string msg)
        {
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
