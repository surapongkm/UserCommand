using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class AttackPoint : DependantAttribute 
    {
        public AttackPoint()
            : base(0)
        {
        }
         
        public override int calculateValue()
        {
            _finalValue = base.baseValue();
             
            // Every 5 points in dexterity adds 1 to attack speed
            int strength = _otherAttributes[0].calculateValue();

            _finalValue += (int)(strength / 5.0f);
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
