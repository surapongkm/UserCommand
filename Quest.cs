using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class Quest
    {
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Requirment
        {
            get;
            set;
        }

        public List<IRequirement> list_requires = new List<IRequirement>();
        public string GenRequirementText()
        {
            string result = "";
            foreach (IRequirement req in list_requires)
            {
                result += req.GenDescription();
            }

            return result;
        }
    }
}
