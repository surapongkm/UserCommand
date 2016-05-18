using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandCreateLeader : CommandBase
    {
        string leadername;
        public CommandCreateLeader(string _leadername)
        {
            leadername = _leadername;
        }

        public override void Execute()
        {
            MgrLeader.GetInstance().CreateLeader(leadername);
        }

        public override void UnExecute()
        {
            MgrLeader.GetInstance().DestroyLeader(leadername);
        }
    }
}
