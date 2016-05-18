using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace UserCommand
{
    class MgrNode
    {
        static MgrNode _instance = null;
        public static MgrNode GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MgrNode();
            }
            return _instance;
        }


        List<Node> lstNode = new List<Node>();

        public void CreateRandomNode(int nNode)
        {
            Node n = new Node();
            lstNode.Add(n);
        }

        private Pen ps = new Pen(Color.Red);
        public void Draw(Graphics g )
        {
            foreach (Node n in lstNode)
            {
                g.DrawEllipse(ps, n.Location.X, n.Location.Y, 20, 20);
            }
        }
    }
}
