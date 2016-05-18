using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MagicResistPoint: DependantAttribute
    {
        public MagicResistPoint()
            : base(0)
        {
        }
    }
}
