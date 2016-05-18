using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandChooseTech : CommandBase
    {
        public string techname = "";
        public CommandChooseTech(string name)
        {
            techname = name;
        }

        public override void Execute()
        {
            CTManager mgr = CTManager.GetInstance();
            mgr.Choose(techname);           
        }

        public override void UnExecute()
        {
        }
    }
}
