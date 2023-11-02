using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public static class FormUtility
    {
        public static void setBasicStyles(Form form)
        {
            form.Text = "V1.0.0";
            form.FormClosed += (sender, args) => Application.Exit();
        }
    }
}
