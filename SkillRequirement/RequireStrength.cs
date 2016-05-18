using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class RequireStrength : IRequirement
    {
        Unit unit;
        int reqStrength;
        public RequireStrength(Unit _unit, int _reqStr)
        {
            unit = _unit;
            reqStrength = _reqStr;
        }

        public bool CheckRequirment()
        {
            if (unit.Str >= reqStrength)
            {
                return true;
            }
            return false;
        }

        public string GenDescription()
        {
            return "Str:" + reqStrength.ToString();
        }
    }
}
