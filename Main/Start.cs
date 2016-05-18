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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommandNewApplication cmd = new CommandNewApplication();
            User.GetInstance().Command(cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommandLoadApplication cmd = new CommandLoadApplication();
            User.GetInstance().Command(cmd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommandCloseApplication cmd = new CommandCloseApplication();
            User.GetInstance().Command(cmd);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }
    }
}
