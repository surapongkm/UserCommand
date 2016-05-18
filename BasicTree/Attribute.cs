using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class Attribute : BaseAttribute 
    {
        private List<RawBonus> _rawBonuses = new List<RawBonus>();
        private List<FinalBonus> _finalBonuses = new List<FinalBonus>();
         
        protected int _finalValue;
         
        public Attribute(int startingValue) :base(startingValue, 5)
        {
            //super(startingValue);
             
            //_rawBbonuses = [];
            //_finalBonuses = [];
             
            _finalValue = baseValue();
        }


        public Attribute(BaseAttribute baseatt)
            : base(baseatt.baseValue(), baseatt.baseMultiplier())
        {
            _finalValue = baseValue();
        }
         
        public void addRawBonus(RawBonus bonus)
        {
            _rawBonuses.Add(bonus);
        }
         
        public void addFinalBonus(FinalBonus bonus)
        {
            _finalBonuses.Add(bonus);
        }
         
        public void removeRawBonus(RawBonus bonus)
        {
            if (_rawBonuses.IndexOf(bonus) >= 0)
            {
                _rawBonuses.Remove(bonus);
            }
        }
         
        public void removeFinalBonus(FinalBonus bonus)
        {
            if (_finalBonuses.IndexOf(bonus) >= 0)
            {
                _finalBonuses.Remove(bonus);
            }
        }

        public virtual int calculateValue()
        {
            _finalValue = baseValue();
             
            applyRawBonuses();
             
            applyFinalBonuses();
             
            return _finalValue;
        }


        public override bool  Equals(object obj)
        {
 	         return base.Equals(obj);
        }
         
        //public int calculateValue()
        //{
        //    _finalValue = baseValue();
             
        //    // Adding value from raw
        //    int rawBonusValue = 0;
        //    int rawBonusMultiplier = 0;
             
        //    foreach (RawBonus bonus in _rawBonuses)
        //    {
        //        rawBonusValue += bonus.baseValue();
        //        rawBonusMultiplier += bonus.baseMultiplier();
        //    }
             
        //    _finalValue += rawBonusValue;
        //    _finalValue *= (1 + rawBonusMultiplier);
             
        //    // Adding value from final
        //    int finalBonusValue = 0;
        //    int finalBonusMultiplier = 0;
             
        //    foreach (FinalBonus bonus in _finalBonuses)
        //    {
        //        finalBonusValue += bonus.baseValue();
        //        finalBonusMultiplier += bonus.baseMultiplier();
        //    }
             
        //    _finalValue += finalBonusValue;
        //    _finalValue *= (1 + finalBonusMultiplier);
             
        //    return _finalValue;
        //}

#region Apply
        protected void applyRawBonuses()
        {
            // Adding value from raw
            int rawBonusValue = 0;
            float rawBonusMultiplier = 0;
             
            foreach (RawBonus bonus in _rawBonuses)
            {
                rawBonusValue += bonus.baseValue();
                rawBonusMultiplier += bonus.baseMultiplier();
            }
             
            _finalValue += rawBonusValue;
            _finalValue = (int)(_finalValue + _finalValue * rawBonusMultiplier);
        }
         
        protected void applyFinalBonuses()
        {
            
            // Adding value from final
            int finalBonusValue = 0;
            float finalBonusMultiplier = 0;
             
            foreach (FinalBonus bonus in _finalBonuses)
            {
                finalBonusValue += bonus.baseValue();
                finalBonusMultiplier += bonus.baseMultiplier();
            }
             
            _finalValue += finalBonusValue;
            _finalValue = (int)(_finalValue + _finalValue * finalBonusMultiplier);
             
        }
#endregion

        public int finalValue()
        {
            return calculateValue();
        }

        public static UserCommand.Attribute operator +(UserCommand.Attribute m1, UserCommand.Attribute m2)
        {
            m1._baseValue += m2._baseValue;
            m1._baseMultiplier += m2._baseMultiplier;
            return m1;
        }

        public static UserCommand.Attribute operator +(UserCommand.Attribute m1, int m2)
        {
            m1._baseValue += m2;
            return m1;
        }
    }
}
