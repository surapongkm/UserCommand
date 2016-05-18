using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandSelectLeader : CommandBase
    {
        string leadername;
        public CommandSelectLeader(string _leadername)
        {
            leadername = _leadername;
        }

        public override void Execute()
        {
        }

        public override void UnExecute()
        {
        }
    }
}
