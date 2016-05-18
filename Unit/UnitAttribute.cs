using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class UnitAttribute
    {
        public HitpointMax hpmax = new HitpointMax(10);
        public MagicpointMax mpmax = new MagicpointMax(10);

        public AttackSpeed aspd = new AttackSpeed();
        public AttackPoint atkpoint = new AttackPoint();
        public DefensePoint defpoint = new DefensePoint();

        public Attribute baselevel = new Attribute(1);
        public Attribute strenght = new Attribute(10);
        public Attribute agility = new Attribute(10);
        public Attribute dexterity = new Attribute(10);
        public Attribute intelligent = new Attribute(10);
        public Attribute vitality = new Attribute(10);
        public Attribute charisma = new Attribute(10);

        public int bonusAttribuePoint;

        public UnitAttribute()
        {
            aspd.addAttribute(dexterity);
            hpmax.addAttribute(baselevel);
            hpmax.addAttribute(vitality);
            mpmax.addAttribute(intelligent);
        }
    }
}
