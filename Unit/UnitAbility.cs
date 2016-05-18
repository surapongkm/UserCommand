using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class UnitAbility
    {
        List<TalentAbility> lstAbility = new List<TalentAbility>();

        public void Load(string resource)
        {
        }

        public void SetUnitAbility(string ability)
        {
            TalentAbility talent = new TalentAbility(ability);
            lstAbility.Add(talent);
        }
    }
}
