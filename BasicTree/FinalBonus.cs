using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class FinalBonus : BaseAttribute 
    {
        public FinalBonus() : base(0, 0)
        {
            
        }

        public FinalBonus(int value, float multiplier)
            : base(value, multiplier)
        {
            //super(value, multiplier);
        }
    }
}
