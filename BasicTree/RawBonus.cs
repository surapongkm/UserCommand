using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class RawBonus : BaseAttribute 
    {
        public RawBonus() : base(0, 0)
        {
            
        }

        public RawBonus(int value, float multiplier)
            : base(value, multiplier)
        {
            //super(value, multiplier);
        }
    }
}
