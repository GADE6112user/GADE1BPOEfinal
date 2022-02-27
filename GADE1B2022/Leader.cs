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
        private Character target;

        public Character Target
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
        public override MovementEnum ReturnMove(Character target)
        {
            if ((this.x - target.X) < (this.y - target.Y)) {
                if ((this.x + 1 - target.X) < (this.x - target.X)) {
                    return MovementEnum.Left;
                } else {
                    return MovementEnum.Right;
                }
            } else {
                if ((this.y + 1 - target.Y) < (this.y - target.Y)) {
                    return MovementEnum.Up;
                } else {
                    return MovementEnum.Down;
                }
            } 
            //return MovementEnum.No_Movement;
        }
    }
}
