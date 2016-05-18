using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class BaseAttribute
    {
        protected int _baseValue;
        protected float _baseMultiplier;
         
        public BaseAttribute(int value, float multiplier) 
        {
            _baseValue = value;
            _baseMultiplier = multiplier;
        }
         
        public int baseValue()
        {
            return _baseValue;
        }

        public float baseMultiplier()
        {
            return _baseMultiplier;
        }

        public static BaseAttribute operator +(BaseAttribute m1, BaseAttribute m2)
        {
            return new BaseAttribute(m1._baseValue + m2._baseValue, m1._baseMultiplier * m2._baseMultiplier);
        }

        public static BaseAttribute operator +(BaseAttribute m1, int m2)
        {
            return new BaseAttribute(m1._baseValue + m2, m1._baseMultiplier);
        }
    }
}
