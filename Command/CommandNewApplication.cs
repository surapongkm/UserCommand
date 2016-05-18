using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandNewApplication : CommandBase
    {
        public CommandNewApplication()
        {
        }

        public override void Execute()
        {
            ScreenManager.ShowScreen("NewScrene");
        }

        public override void UnExecute()
        {
        }
    }
}
