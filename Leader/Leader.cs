using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class Leader
    {
        

        private String _name = "";
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public List<UnitAbility> unitability = new List<UnitAbility>();
        public void SetUnitAbility(int nUnit, string ability)
        {
            unitability[nUnit].SetUnitAbility(ability);
        }

        public UnitAbility GetUnitAbility(int nUnit)
        {
            return unitability[nUnit];
        }
    }
}
