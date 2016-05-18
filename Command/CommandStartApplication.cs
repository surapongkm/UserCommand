using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    class CommandStartApplication : CommandBase
    {
        public CommandStartApplication()
        {
        }

        public override void Execute()
        {
            ScreenManager.ShowScreen("Main");
        }

        public override void UnExecute()
        {
        }
    }
}
