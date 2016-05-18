using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class DependantAttribute : Attribute 
    {
        protected List<Attribute> _otherAttributes = new List<Attribute>();
         
        public DependantAttribute(int startingValue) : base(startingValue)
        {
            //super(startingValue);             
            //_otherAttributes = [];
        }
         
        public void addAttribute(Attribute attr)
        {
            _otherAttributes.Add(attr);
        }
         
        public void removeAttribute(Attribute attr)
        {
            if (_otherAttributes.IndexOf(attr) >= 0)
            {
                _otherAttributes.Remove(attr);
            }
        }
         
        public override int calculateValue()
        {
            // Specific attribute code goes somewhere in here
            
            base._finalValue = baseValue();

            base.applyRawBonuses();

            base.applyFinalBonuses();
             
            return _finalValue;
        }
    }
}
