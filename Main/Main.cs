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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog dlg = new Dialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //User user = User.GetInstance();
            //CommandChooseTech cmd = new CommandChooseTech("");
            //user.Command(cmd);

            CMyClass myclass = new CMyClass();
            myclass.ShowAttribute();
        }
    }
}
