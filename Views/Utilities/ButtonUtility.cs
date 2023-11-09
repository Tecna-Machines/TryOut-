using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.Utilities
{
    internal class ButtonUtility
    {
        public static void ConfigurationButton(Button button)
        {
            button.BackColor = Color.FromArgb(59, 68, 83);
            button.ForeColor = Color.White;

            button.UseVisualStyleBackColor = false;
            button.FlatStyle = FlatStyle.Flat;

            button.Cursor = Cursors.Hand;
        }

        public static void ConfigurationButtons(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                ConfigurationButton(button);
            }
        }
    }
}
