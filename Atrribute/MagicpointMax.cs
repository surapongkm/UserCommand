using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MagicpointMax : DependantAttribute
    {
        public MagicpointMax(int startingValue)
            : base(startingValue)
        {
        }
         
        public override int calculateValue()
        {
            _finalValue = base.baseValue();

            // Every 5 points in intelligent adds 1 to mp max
            int intelligent = _otherAttributes[0].calculateValue();

            _finalValue += (int)(intelligent / 5.0f);
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
