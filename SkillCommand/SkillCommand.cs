using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class SkillCommand
    {
        SkillBase _skill;
        SkillOwner _owner;
        SkillTarget _target;

        public SkillCommand(SkillBase skill, SkillOwner owner, SkillTarget target)
        {
            _skill = skill;
            _owner = owner;
            _target = target;
        }

        public void Use()
        {
            if (CanUse())
            {

            }
        }

        public bool CanUse()
        {
            return true;
        }
    }
}
