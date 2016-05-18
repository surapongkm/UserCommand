using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class RequireIntelligent : IRequirement
    {
        Unit unit;
        int reqInt;
        public RequireIntelligent(Unit _unit, int _reqInt)
        {
            unit = _unit;
            reqInt = _reqInt;
        }

        public bool CheckRequirment()
        {
            if (unit.Int >= reqInt)
            {
                return true;
            }
            return false;
        }

        public string GenDescription()
        {
            return "Int:" + reqInt.ToString();
        }
    }
}
