using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class CTManager
    {

        private List<CT> lstT = new List<CT>();
        private CT selectedT = null;

        static CTManager _TManager = null;
        public static CTManager GetInstance()
        {
            if (_TManager == null)
            {
                _TManager = new CTManager();
            }
            return _TManager;
        }

        #region Method
        public void Init()
        {
            //Load T

            // Build List

        }

        public void Choose(string techname)
        {
            foreach (CT t in lstT)
            {
                if (t.Name == techname)
                {
                    selectedT = t;
                    break;
                }
            }
        }
        #endregion
    }
}
