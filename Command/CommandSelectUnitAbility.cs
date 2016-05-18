using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CommandSelectUnitAbility : CommandBase
    {
        string _leader;
        string _ability;
        public CommandSelectUnitAbility(string leader, string ability)
        {
            _ability = ability;
            _leader = leader;
        }

        public override void Execute()
        {
            Leader leader = null;
            MgrLeader mgrleader = MgrLeader.GetInstance();
            if (mgrleader.GetLeader(_leader, out leader))
            {
                leader.SetUnitAbility(0, _ability);
            }

        }

        public override void UnExecute()
        {
        }
    }
}
