using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    [Serializable]
    public class Unit
    {
        private UnitAttribute unitattribute = new UnitAttribute();
        private List<SkillBase> unitskill = new List<SkillBase>();

        public String Id
        {
            get;
            set;
        }

        public Int32 Str
        {
            get { return FinalStrenght(); }
        }

        public Int32 Aspd
        {
            get { return unitattribute.aspd.finalValue();  }
        }

        public Int32 Agi
        {
            get { return FinalAgility(); }
        }

        public Int32 Int
        {
            get { return FinalIntelligent(); }
        }


        public Int32 FinalStrenght()
        {
            int _str = unitattribute.strenght.finalValue();
            return _str;
        }

        public Int32 FinalIntelligent()
        {
            int _int = unitattribute.strenght.finalValue();
            return _int;
        }

        public Int32 FinalAgility()
        {
            int _agi = unitattribute.agility.finalValue();

            return _agi;
        }

        public virtual void Damage(int damage)
        {
        }
    }
}
