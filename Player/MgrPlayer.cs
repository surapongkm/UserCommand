using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class MgrPlayer
    {
        private List<Player> lstPlayer = new List<Player>();

        static MgrLeader _instance = null;
        public static MgrLeader GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MgrLeader();
            }
            return _instance;
        }

        public void CreatePlayer(PlayerSettings settings)
        {
            Player _player = new Player(settings);
            lstPlayer.Add(_player);


        }
    }
}
