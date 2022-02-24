using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Leader : Enemy
    {
        private int x;
        private int y;
        private Tile target;

        public Tile Target
        {
            get { return target; }
            set { target = value; }
        }
        public Leader (int X, int Y)
        {
            x = X;
            y = Y;
            this.hp = 20;
            this.damage = 2;
        }
    }
}
