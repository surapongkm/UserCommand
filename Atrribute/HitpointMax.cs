using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class HitpointMax : DependantAttribute
    {
        public HitpointMax(int startingValue)
            : base(startingValue)
        {
        }
         
        public override int calculateValue()
        {
            // Every 5 points in Strenght adds 1 to hp max
            int baselevel = _otherAttributes[0].calculateValue();
            int strenght = _otherAttributes[1].calculateValue();

            _finalValue = (baselevel) * (int)(baseValue() + strenght / 5.0f);
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
