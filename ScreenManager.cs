using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserCommand
{
    public class ScreenManager
    {
        private static Form currentScreen = null;

        public static void ShowScreen(String screenname)
        {
            if (currentScreen != null)
            {
                currentScreen.Close();
            }

            Type t = Type.GetType("UserCommand."+ screenname, true, false);
            currentScreen = (Form) Activator.CreateInstance(t);
            currentScreen.Show();
        }
    }
}
