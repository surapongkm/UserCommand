using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MovementSpeed: DependantAttribute 
    {
        public MovementSpeed(int startingValue)
            : base(startingValue)
        {
        }
         
        public override int calculateValue()
        {
            _finalValue = base.baseValue();
             
            // Every 5 points in dexterity adds 1 to attack speed
            int agility = _otherAttributes[0].calculateValue();
             
            _finalValue += (int)(agility / 5.0f);
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
