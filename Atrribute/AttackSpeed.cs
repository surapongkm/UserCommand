using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class AttackSpeed : DependantAttribute 
    {
        public AttackSpeed() : base(0)
        {
        }
         
        public override int calculateValue()
        {
            _finalValue = base.baseValue();
             
            // Every 5 points in dexterity adds 1 to attack speed
            int dexterity = _otherAttributes[0].calculateValue();
             
            _finalValue += (int)(dexterity / 5.0f);
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
