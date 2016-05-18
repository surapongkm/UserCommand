using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace UserCommand
{
    public partial class NewScrene : Form
    {


        public NewScrene()
        {
            InitializeComponent();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandSelectLeader cmd = new CommandSelectLeader("name");
            User.GetInstance().Command(cmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommandStartApplication cmd = new CommandStartApplication();
            User.GetInstance().Command(cmd);
        }
    }
}
