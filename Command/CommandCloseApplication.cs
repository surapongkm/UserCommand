using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandCloseApplication : CommandBase
    {
        public CommandCloseApplication()
        {
        }

        public override void Execute()
        {
            System.Windows.Forms.Application.Exit();
        }

        public override void UnExecute()
        {
        }
    }
}
