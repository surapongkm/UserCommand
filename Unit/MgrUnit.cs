using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MgrUnit
    {
        static MgrUnit _instance = null;
        public static MgrUnit GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MgrUnit();
            }
            return _instance;
        }


        public MgrUnit()
        {
        }

        List<Unit> units = new List<Unit>();
        public Unit CreateUnit()
        {
            Unit unit = new Unit();
            units.Add(unit);
            return unit;
        }
    }
}
