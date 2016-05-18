using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace UserCommand
{
    public class CommandChooseLeader : CommandBase
    {
        string leadername;
        public CommandChooseLeader(string _leadername)
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
