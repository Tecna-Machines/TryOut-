using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.Utilities
{
    public static class FormUtility
    {
        public static void setBasicStyles(Form form)
        {
            form.Text = "V1.0.0";
            form.FormClosed += (sender, args) => Application.Exit();

            form.StartPosition = FormStartPosition.CenterScreen;

            //size
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;


            //colors
            form.BackColor = Color.FromArgb(26, 32, 40);
            form.ForeColor = Color.FromArgb(217, 217, 217);
        }
    }
}
