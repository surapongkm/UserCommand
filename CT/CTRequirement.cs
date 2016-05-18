using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CTRequirement
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsPass()
        {
            return false;
        }
    }
}
