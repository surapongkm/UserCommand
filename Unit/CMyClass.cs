using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CMyClass
    {
        public Attribute a1 = new Attribute(10);
        public Attribute a2 = new Attribute(10);
        public Attribute a3 = new Attribute(10);

        public void ShowAttribute()
        {
            a1.addRawBonus(new RawBonus(1, 0.3f));
            a1.addFinalBonus(new FinalBonus(1, 0.3f));

            Console.WriteLine(string.Format("a1 {0}", a1.finalValue() ));
            Console.WriteLine(string.Format("a2 {0}", a2.finalValue()));
            Console.WriteLine(string.Format("a3 {0}", a3.finalValue()));
        }
    }
}
