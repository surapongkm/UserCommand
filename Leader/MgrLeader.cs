using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MgrLeader
    {
        static MgrLeader _instance = null;
        public static MgrLeader GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MgrLeader();
            }
            return _instance;
        }

        private Dictionary<string, Leader> ledaers = new Dictionary<string, Leader>();

        public Leader CreateLeader(string name)
        {
            Leader l = null;
            if (ledaers.ContainsKey(name))
            {
                ledaers.TryGetValue(name, out l);
            }
            else
            {
                l = new Leader();
                l.Name = name;                
                ledaers.Add(name, l);
            }
            return l;
        }

        public bool DestroyLeader(string name)
        {
            return ledaers.Remove(name);
        }

        public bool GetLeader(string name, out Leader l)
        {
            return ledaers.TryGetValue(name, out l);
        }
    }
}
