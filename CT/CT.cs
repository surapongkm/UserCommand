using System;
using System.Collections.Generic;
using System.Text;

namespace UserCommand
{
    public class CT
    {

#region Attribute
        private string _name;
        public string Name
        {
            get { return _name;  }
            set { _name = value;  }
        }

        private int _nT;
        public int NTMAX;
        public int NT
        {
            get
            {
                return _nT;
            }
        }

        private List<CTRequirement> requirments = new List<CTRequirement>();
#endregion

#region MainMethod
        public string GetDescription()
        {
            string desciption = "";
            desciption = string.Format("{0} NT:{1}/{2} NT:{3}", Name, _nT, NTMAX, GetRequirementString());
            return desciption;
        }
#endregion

#region Description
        public string GetRequirementString()
        {
            string result = "";
            foreach (CTRequirement req in requirments)
            {
                if (string.IsNullOrEmpty(result))
                {
                    result += req.Name;
                }
                else
                {
                    result += ", " + req.Name;
                }
            }
            return result;
        }


        public bool HasAllRequirment()
        {
            foreach (CTRequirement req in requirments)
            {
                if (!req.IsPass())
                {
                    return false;
                }
            }

            return true;
        }
#endregion

#region MyMethod

        public bool Load(string filename)
        {

            return true;
        }

        public void Save(string filename)
        {
        }
#endregion

    }
}
